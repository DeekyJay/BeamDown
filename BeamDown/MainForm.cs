using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;
using System.Diagnostics;
using MetroFramework.Forms;
using System.Threading;
using MetroFramework;
using System.Drawing;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace BeamDown
{
    public partial class MainForm : MetroForm
    {
        //Video Variables
        private string channelId;
        private string username;
        private string file_url;
        private string v_url;
        private string p_url;
        private string status;
        private Color col;

        //Downloading Variables
        private WebClient web = new WebClient();
        private BackgroundWorker bw = new BackgroundWorker();
        private DateTime lastUpdateTime = new DateTime();
        private double speed = 0;
        private double lastUpdateDownloadedSize = 0;
        private bool running = false;
        private bool cancelled = false;
        private double totalBytes = 0.0;
        private double bytesIn = 0.0;

        /// <summary>
        /// Default Constructor
        /// Initializes the program, setups up label text, and creates events
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            //Make Sure About Section is at the back
            this.mpAbout.SendToBack();

            //Clear Default Text
            this.mlbChannelEdit.Text = "";
            this.mlbProgressEdit.Text = "";
            this.mlbSpeedEdit.Text = "";
            this.mlbPercent.Text = "";
            this.mlbTitleEdit.Text = "";
            this.mlbDateEdit.Text = "";
            this.mlbStatus.Text = "";

            //Setup Background Worker for Timing
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(this.bw_DoWork);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bw_RunWorkerCompleted);
            bw.ProgressChanged += new ProgressChangedEventHandler(this.bw_ProgressChanged);

            //Setup WebClient
            web.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_downloadProgressChanged);
            web.DownloadFileCompleted += new AsyncCompletedEventHandler(client_downloadCompleted);
            web.Encoding = Encoding.UTF8;
        }

        /// <summary>
        /// While the download is happening, continue to report progress every 100ms
        /// to update the speed, percentage, and current bytes down.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            while(this.running)
            {
                bw.ReportProgress(0);
                Thread.Sleep(100);
            }
        }

        /// <summary>
        /// Called when BackgroundWorker reports a progress
        /// Gets currently downloading speed, percentage of completion, and total number of bytes
        /// downloaded and updates the labels to show the data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Update the speed
            DateTime now = DateTime.Now;
            TimeSpan interval = now - lastUpdateTime;
            double timeDiff = interval.TotalSeconds;
            double sizeDiff = totalBytes + bytesIn - lastUpdateDownloadedSize;
            this.speed = (sizeDiff / 1024d) / timeDiff;
            this.lastUpdateDownloadedSize = totalBytes + bytesIn;
            this.lastUpdateTime = now;
            this.mlbSpeedEdit.Text = string.Format("{0:0.00} KB/s", this.speed);

            //Update the current downloaded size
            double megabytesIn = bytesIn / 1024d / 1024d;
            double totalMegabytes = totalBytes / 1024d / 1024d;
            string s = String.Format("{0:0.00}MB of {1:0.00}MB", megabytesIn, totalMegabytes);
            this.mlbProgressEdit.Text = s;

            //Update the percentage of completion
            double percentage = (this.bytesIn / this.totalBytes) * 100.00;
            this.mlbPercent.Text = string.Format("{0:0.00}%", percentage);  
        }

        /// <summary>
        /// Called once the BackgroundWorker has completed (When the download has completed/stopped)
        /// Resets proper label to show the result of the download.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.mlbSpeedEdit.Text = "";
            //If the user cancelled the download
            if(cancelled)
            {
                this.mlbProgressEdit.Text = "Aborted.";
                this.mlbPercent.Text = "";
                this.mpbDownload.Value = 0;
            }
            //The download was successful, show a feel good number
            else
            {
                this.mlbPercent.Text = "100.00%";
                this.mlbProgressEdit.Text = "Completed!";
                this.mbtnPlay.Enabled = true;
            }

            this.cancelled = false;     
        }

        /// <summary>
        /// Called when the user clicks "Get Channel Video" Button
        /// Takes the username and looks up the channel id, title, and thumbnail
        /// of the last stream on the channel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetVideo_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            //Get the result from the url lookup that displays channel info
            this.username = this.mtbUsername.Text;
            string url = "https://beam.pro/api/v1/channels/" + username;

            string json = "";

            try
            {
                json = web.DownloadString(url);

                JToken jt = JObject.Parse(json);

                this.channelId = (string) jt.SelectToken("id");
                bool online = (bool)jt.SelectToken("online");
                string name = (string)jt.SelectToken("name");
                string date = (string)jt.SelectToken("updatedAt");

                //Get the url of the video and the image to set as our preview
                this.v_url = "https://dist-vod.beam.pro/dash/" + this.channelId + "/source.mp4";

                //If the user is live, get the thumbnail rather than the last stream picture
                if (online)
                {
                    this.p_url = "https://thumbs.beam.pro/channel/" + this.channelId + ".small.jpg";
                    this.status = "LIVE";
                    this.col = Color.Green;
                } 
                else
                {
                    this.p_url = "https://dist-vod.beam.pro/dash/" + this.channelId + "/source.jpg";
                    this.status = "OFFLINE";
                    this.col = Color.Gray;
                }
                    

                //Update the UI with the new info and allow them to download the video
                this.mlbChannelEdit.Text = channelId;
                this.mlbTitleEdit.Text = name;
                this.mlbDateEdit.Text = date;
                this.mbtnDownload.Enabled = true;
                this.pbPreview.ImageLocation = p_url;
                this.mlbStatus.Text = status;
                this.mlbStatus.ForeColor = col;
            }
            catch(WebException we)
            {
                if (we.Message.Contains("404"))
                    MetroMessageBox.Show(this, "Channel does not exist!", "Channel Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MetroMessageBox.Show(this, "Error: " + we.Message, "Beam Stream Down Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.mbtnPlay.Enabled = false;
                this.mlbProgressEdit.Text = "";
                this.mlbPercent.Text = "";
                this.mlbLocation.Text = "Save Location";
                this.mpbDownload.Value = 0;
                Cursor.Current = Cursors.Default;
            } 
        }

        /// <summary>
        /// Called when the user clicks "Download"
        /// Asks the user where they want to save the file then proceeds
        /// to download the file to that directory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDownload_Click(object sender, EventArgs e)
        {
            //Default the name of the file to the username
            savDia.FileName = this.username + ".mp4";
            DialogResult res = savDia.ShowDialog();
            
            //Check to see if the user did choose a save location and did not cancel
            if (res == DialogResult.OK)
            {
                this.file_url = savDia.FileName;
                this.mlbLocation.Text = "Save Location   " + this.file_url;
                this.mbtnDownload.Enabled = false;
                this.mbtnCancel.Enabled = true;
                this.running = true;
                
                //Starts the download
                web.DownloadFileAsync(new Uri(v_url), this.file_url);             
            }
        }

        /// <summary>
        /// Called when the download has finished
        /// Sets the UI to show that the download has finished
        /// and if the reason was because of proper completion or abortion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void client_downloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.mbtnDownload.Enabled = true;
            this.mbtnCancel.Enabled = false;
            this.running = false;
            this.speed = 0;
            this.mlbSpeedEdit.Text = "";

            //Call the BackgroundWorker to stop working, just in case
            bw.CancelAsync();

            //If the user cancelled the download, set cancel to true
            //So the BackgroundWorker knows what happened and how to update
            //the UI
            if (e.Cancelled)
                this.cancelled = true;
        }

        /// <summary>
        /// Called when the video is downloading and bytes have been received
        /// Sets the bytes in and the total bytes at the time, updates the
        /// progress bar of the download, and if the BackgroundWorker
        /// is not running, starts it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void client_downloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.bytesIn = double.Parse(e.BytesReceived.ToString());
            this.totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            
            if(!bw.IsBusy)
            {
                bw.RunWorkerAsync();
            }
                  
            mpbDownload.Value = e.ProgressPercentage;
        }

        /// <summary>
        /// Called when the user clicks the "Cancel" Button
        /// Aborts the download and sets the UI in a state to download again.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            web.CancelAsync();
            this.mbtnDownload.Enabled = true;
            this.mbtnCancel.Enabled = false;
            this.mbtnPlay.Enabled = false;
        }

        /// <summary>
        /// Called when the user clicks the "Play" Button
        /// Simply attempts to execute the video downloaded. (Just like double clicking it)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            Process.Start(file_url);
        }

        /// <summary>
        /// Called when the user clicks the "About" Button
        /// Displays the About section
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mbtnAbout_Click(object sender, EventArgs e)
        {
            this.mbtnAbout.Enabled = false;
            //Brings the panel to the front
            this.mpAbout.BringToFront();
        }

        /// <summary>
        /// Called when the user clicks the GitHub Image
        /// Opens up my GitHub page in the default browser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbGit_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Leviathan5");
        }

        /// <summary>
        /// Called when the user clicks the "Beam.Pro/Leviathan5" Link
        /// Opens up my channel in the default browser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mlinkLeviathan_Click(object sender, EventArgs e)
        {
            Process.Start("https://beam.pro/Leviathan5");
        }

        /// <summary>
        /// Called when the user clicks the "Beam.Pro/BastionConquers" Link
        /// Opens up BastionConquers' channel in the default browser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mlinkBastion_Click(object sender, EventArgs e)
        {
            Process.Start("https://beam.pro/BastionConquers");
        }

        /// <summary>
        /// Called when the user clicks the "Back" Button on the About Section
        /// Sends the About Page to the background and shows the main area
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mbtnAboutBack_Click(object sender, EventArgs e)
        {
            this.mbtnAbout.Enabled = true;
            //Sends the panel to the back to hide it
            this.mpAbout.SendToBack();
        }
    }
}
