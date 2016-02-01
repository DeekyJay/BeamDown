namespace BeamDown
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.savDia = new System.Windows.Forms.SaveFileDialog();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.mlbDateEdit = new MetroFramework.Controls.MetroLabel();
            this.mlbLastUpdated = new MetroFramework.Controls.MetroLabel();
            this.mlbTitleEdit = new MetroFramework.Controls.MetroLabel();
            this.mlbTitle = new MetroFramework.Controls.MetroLabel();
            this.spltDownSave = new System.Windows.Forms.Splitter();
            this.mlbLocation = new MetroFramework.Controls.MetroLabel();
            this.mlbPercent = new MetroFramework.Controls.MetroLabel();
            this.mlbSpeedEdit = new MetroFramework.Controls.MetroLabel();
            this.mlbSpeed = new MetroFramework.Controls.MetroLabel();
            this.mbtnCancel = new MetroFramework.Controls.MetroButton();
            this.mbtnDownload = new MetroFramework.Controls.MetroButton();
            this.mbtnPlay = new MetroFramework.Controls.MetroButton();
            this.mlbProgress = new MetroFramework.Controls.MetroLabel();
            this.mlbProgressEdit = new MetroFramework.Controls.MetroLabel();
            this.mlbChannelEdit = new MetroFramework.Controls.MetroLabel();
            this.mlbChannel = new MetroFramework.Controls.MetroLabel();
            this.mlbUsername = new MetroFramework.Controls.MetroLabel();
            this.mtbUsername = new MetroFramework.Controls.MetroTextBox();
            this.mbtnGetVideo = new MetroFramework.Controls.MetroButton();
            this.spltVert = new System.Windows.Forms.Splitter();
            this.mlbPreview = new MetroFramework.Controls.MetroLabel();
            this.spltChanDown = new System.Windows.Forms.Splitter();
            this.mpbDownload = new MetroFramework.Controls.MetroProgressBar();
            this.msm = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mbtnAbout = new MetroFramework.Controls.MetroButton();
            this.mlbInfo = new MetroFramework.Controls.MetroLabel();
            this.mpAbout = new MetroFramework.Controls.MetroPanel();
            this.tableAbout = new System.Windows.Forms.TableLayoutPanel();
            this.mbtnAboutBack = new MetroFramework.Controls.MetroButton();
            this.mlinkBastion = new MetroFramework.Controls.MetroLink();
            this.mlbStream = new MetroFramework.Controls.MetroLabel();
            this.spltDevStream = new System.Windows.Forms.Splitter();
            this.mlbLeviathan = new MetroFramework.Controls.MetroLabel();
            this.mlbDeveloper = new MetroFramework.Controls.MetroLabel();
            this.spltAbout = new System.Windows.Forms.Splitter();
            this.mlbAbout = new MetroFramework.Controls.MetroLabel();
            this.pbGit = new System.Windows.Forms.PictureBox();
            this.mlinkLeviathan = new MetroFramework.Controls.MetroLink();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msm)).BeginInit();
            this.mpAbout.SuspendLayout();
            this.tableAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGit)).BeginInit();
            this.SuspendLayout();
            // 
            // savDia
            // 
            this.savDia.DefaultExt = "mp4";
            this.savDia.Filter = "Video files | *.mp4";
            // 
            // table
            // 
            this.table.ColumnCount = 5;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 480F));
            this.table.Controls.Add(this.pbPreview, 4, 1);
            this.table.Controls.Add(this.mlbDateEdit, 1, 3);
            this.table.Controls.Add(this.mlbLastUpdated, 0, 3);
            this.table.Controls.Add(this.mlbTitleEdit, 1, 2);
            this.table.Controls.Add(this.mlbTitle, 0, 2);
            this.table.Controls.Add(this.spltDownSave, 0, 10);
            this.table.Controls.Add(this.mlbLocation, 0, 11);
            this.table.Controls.Add(this.mlbPercent, 1, 9);
            this.table.Controls.Add(this.mlbSpeedEdit, 1, 7);
            this.table.Controls.Add(this.mlbSpeed, 0, 7);
            this.table.Controls.Add(this.mbtnCancel, 2, 5);
            this.table.Controls.Add(this.mbtnDownload, 1, 5);
            this.table.Controls.Add(this.mbtnPlay, 0, 5);
            this.table.Controls.Add(this.mlbProgress, 0, 6);
            this.table.Controls.Add(this.mlbProgressEdit, 1, 6);
            this.table.Controls.Add(this.mlbChannelEdit, 1, 1);
            this.table.Controls.Add(this.mlbChannel, 0, 1);
            this.table.Controls.Add(this.mlbUsername, 0, 0);
            this.table.Controls.Add(this.mtbUsername, 1, 0);
            this.table.Controls.Add(this.mbtnGetVideo, 2, 0);
            this.table.Controls.Add(this.spltVert, 3, 0);
            this.table.Controls.Add(this.mlbPreview, 4, 0);
            this.table.Controls.Add(this.spltChanDown, 0, 4);
            this.table.Controls.Add(this.mpbDownload, 0, 8);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 60);
            this.table.Name = "table";
            this.table.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.table.RowCount = 12;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.Size = new System.Drawing.Size(896, 334);
            this.table.TabIndex = 9;
            // 
            // pbPreview
            // 
            this.pbPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPreview.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbPreview.ErrorImage")));
            this.pbPreview.InitialImage = null;
            this.pbPreview.Location = new System.Drawing.Point(401, 30);
            this.pbPreview.Margin = new System.Windows.Forms.Padding(5, 0, 0, 2);
            this.pbPreview.Name = "pbPreview";
            this.table.SetRowSpan(this.pbPreview, 11);
            this.pbPreview.Size = new System.Drawing.Size(475, 302);
            this.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPreview.TabIndex = 19;
            this.pbPreview.TabStop = false;
            // 
            // mlbDateEdit
            // 
            this.mlbDateEdit.AutoSize = true;
            this.table.SetColumnSpan(this.mlbDateEdit, 2);
            this.mlbDateEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.mlbDateEdit.Location = new System.Drawing.Point(115, 95);
            this.mlbDateEdit.Margin = new System.Windows.Forms.Padding(5);
            this.mlbDateEdit.Name = "mlbDateEdit";
            this.mlbDateEdit.Size = new System.Drawing.Size(41, 20);
            this.mlbDateEdit.TabIndex = 42;
            this.mlbDateEdit.Text = "None";
            // 
            // mlbLastUpdated
            // 
            this.mlbLastUpdated.AutoSize = true;
            this.mlbLastUpdated.Dock = System.Windows.Forms.DockStyle.Right;
            this.mlbLastUpdated.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbLastUpdated.Location = new System.Drawing.Point(67, 95);
            this.mlbLastUpdated.Margin = new System.Windows.Forms.Padding(5);
            this.mlbLastUpdated.Name = "mlbLastUpdated";
            this.mlbLastUpdated.Size = new System.Drawing.Size(38, 20);
            this.mlbLastUpdated.TabIndex = 41;
            this.mlbLastUpdated.Text = "Date";
            // 
            // mlbTitleEdit
            // 
            this.mlbTitleEdit.AutoSize = true;
            this.table.SetColumnSpan(this.mlbTitleEdit, 2);
            this.mlbTitleEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.mlbTitleEdit.Location = new System.Drawing.Point(115, 65);
            this.mlbTitleEdit.Margin = new System.Windows.Forms.Padding(5);
            this.mlbTitleEdit.Name = "mlbTitleEdit";
            this.mlbTitleEdit.Size = new System.Drawing.Size(41, 20);
            this.mlbTitleEdit.TabIndex = 40;
            this.mlbTitleEdit.Text = "None";
            // 
            // mlbTitle
            // 
            this.mlbTitle.AutoSize = true;
            this.mlbTitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.mlbTitle.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbTitle.Location = new System.Drawing.Point(71, 65);
            this.mlbTitle.Margin = new System.Windows.Forms.Padding(5);
            this.mlbTitle.Name = "mlbTitle";
            this.mlbTitle.Size = new System.Drawing.Size(34, 20);
            this.mlbTitle.TabIndex = 39;
            this.mlbTitle.Text = "Title";
            // 
            // spltDownSave
            // 
            this.spltDownSave.BackColor = System.Drawing.Color.Gray;
            this.spltDownSave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.table.SetColumnSpan(this.spltDownSave, 3);
            this.spltDownSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.spltDownSave.Location = new System.Drawing.Point(22, 293);
            this.spltDownSave.Margin = new System.Windows.Forms.Padding(2, 7, 2, 7);
            this.spltDownSave.Name = "spltDownSave";
            this.spltDownSave.Size = new System.Drawing.Size(355, 3);
            this.spltDownSave.TabIndex = 38;
            this.spltDownSave.TabStop = false;
            // 
            // mlbLocation
            // 
            this.mlbLocation.AutoSize = true;
            this.table.SetColumnSpan(this.mlbLocation, 3);
            this.mlbLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.mlbLocation.Location = new System.Drawing.Point(25, 308);
            this.mlbLocation.Margin = new System.Windows.Forms.Padding(5);
            this.mlbLocation.Name = "mlbLocation";
            this.mlbLocation.Size = new System.Drawing.Size(349, 19);
            this.mlbLocation.TabIndex = 37;
            this.mlbLocation.Text = "Save Location";
            // 
            // mlbPercent
            // 
            this.mlbPercent.AutoSize = true;
            this.mlbPercent.Dock = System.Windows.Forms.DockStyle.Top;
            this.mlbPercent.Location = new System.Drawing.Point(110, 266);
            this.mlbPercent.Margin = new System.Windows.Forms.Padding(0);
            this.mlbPercent.Name = "mlbPercent";
            this.mlbPercent.Size = new System.Drawing.Size(155, 19);
            this.mlbPercent.TabIndex = 33;
            this.mlbPercent.Text = "%";
            this.mlbPercent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mlbSpeedEdit
            // 
            this.mlbSpeedEdit.AutoSize = true;
            this.mlbSpeedEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.mlbSpeedEdit.Location = new System.Drawing.Point(115, 202);
            this.mlbSpeedEdit.Margin = new System.Windows.Forms.Padding(5);
            this.mlbSpeedEdit.Name = "mlbSpeedEdit";
            this.mlbSpeedEdit.Size = new System.Drawing.Size(41, 20);
            this.mlbSpeedEdit.TabIndex = 28;
            this.mlbSpeedEdit.Text = "None";
            // 
            // mlbSpeed
            // 
            this.mlbSpeed.AutoSize = true;
            this.mlbSpeed.Dock = System.Windows.Forms.DockStyle.Right;
            this.mlbSpeed.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbSpeed.Location = new System.Drawing.Point(59, 202);
            this.mlbSpeed.Margin = new System.Windows.Forms.Padding(5);
            this.mlbSpeed.Name = "mlbSpeed";
            this.mlbSpeed.Size = new System.Drawing.Size(46, 20);
            this.mlbSpeed.TabIndex = 27;
            this.mlbSpeed.Text = "Speed";
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mbtnCancel.Enabled = false;
            this.mbtnCancel.Location = new System.Drawing.Point(267, 139);
            this.mbtnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.mbtnCancel.Name = "mbtnCancel";
            this.mbtnCancel.Size = new System.Drawing.Size(110, 26);
            this.mbtnCancel.TabIndex = 24;
            this.mbtnCancel.Text = "Cancel";
            this.mbtnCancel.UseSelectable = true;
            this.mbtnCancel.UseStyleColors = true;
            this.mbtnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // mbtnDownload
            // 
            this.mbtnDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mbtnDownload.Enabled = false;
            this.mbtnDownload.Location = new System.Drawing.Point(112, 139);
            this.mbtnDownload.Margin = new System.Windows.Forms.Padding(2);
            this.mbtnDownload.Name = "mbtnDownload";
            this.mbtnDownload.Size = new System.Drawing.Size(151, 26);
            this.mbtnDownload.TabIndex = 22;
            this.mbtnDownload.Text = "Download";
            this.mbtnDownload.UseSelectable = true;
            this.mbtnDownload.UseStyleColors = true;
            this.mbtnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // mbtnPlay
            // 
            this.mbtnPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mbtnPlay.Enabled = false;
            this.mbtnPlay.Location = new System.Drawing.Point(22, 139);
            this.mbtnPlay.Margin = new System.Windows.Forms.Padding(2);
            this.mbtnPlay.Name = "mbtnPlay";
            this.mbtnPlay.Size = new System.Drawing.Size(86, 26);
            this.mbtnPlay.TabIndex = 21;
            this.mbtnPlay.Text = "Play";
            this.mbtnPlay.UseSelectable = true;
            this.mbtnPlay.UseStyleColors = true;
            this.mbtnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // mlbProgress
            // 
            this.mlbProgress.AutoSize = true;
            this.mlbProgress.Dock = System.Windows.Forms.DockStyle.Right;
            this.mlbProgress.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbProgress.Location = new System.Drawing.Point(43, 172);
            this.mlbProgress.Margin = new System.Windows.Forms.Padding(5);
            this.mlbProgress.Name = "mlbProgress";
            this.mlbProgress.Size = new System.Drawing.Size(62, 20);
            this.mlbProgress.TabIndex = 15;
            this.mlbProgress.Text = "Progress";
            // 
            // mlbProgressEdit
            // 
            this.mlbProgressEdit.AutoSize = true;
            this.mlbProgressEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.mlbProgressEdit.Location = new System.Drawing.Point(115, 172);
            this.mlbProgressEdit.Margin = new System.Windows.Forms.Padding(5);
            this.mlbProgressEdit.Name = "mlbProgressEdit";
            this.mlbProgressEdit.Size = new System.Drawing.Size(41, 20);
            this.mlbProgressEdit.TabIndex = 14;
            this.mlbProgressEdit.Text = "None";
            // 
            // mlbChannelEdit
            // 
            this.mlbChannelEdit.AutoSize = true;
            this.mlbChannelEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.mlbChannelEdit.Location = new System.Drawing.Point(115, 35);
            this.mlbChannelEdit.Margin = new System.Windows.Forms.Padding(5);
            this.mlbChannelEdit.Name = "mlbChannelEdit";
            this.mlbChannelEdit.Size = new System.Drawing.Size(44, 20);
            this.mlbChannelEdit.TabIndex = 13;
            this.mlbChannelEdit.Text = "00000";
            // 
            // mlbChannel
            // 
            this.mlbChannel.AutoSize = true;
            this.mlbChannel.Dock = System.Windows.Forms.DockStyle.Right;
            this.mlbChannel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbChannel.Location = new System.Drawing.Point(28, 35);
            this.mlbChannel.Margin = new System.Windows.Forms.Padding(5);
            this.mlbChannel.Name = "mlbChannel";
            this.mlbChannel.Size = new System.Drawing.Size(77, 20);
            this.mlbChannel.TabIndex = 12;
            this.mlbChannel.Text = "Channel ID";
            // 
            // mlbUsername
            // 
            this.mlbUsername.AutoSize = true;
            this.mlbUsername.Dock = System.Windows.Forms.DockStyle.Right;
            this.mlbUsername.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbUsername.Location = new System.Drawing.Point(34, 5);
            this.mlbUsername.Margin = new System.Windows.Forms.Padding(5);
            this.mlbUsername.Name = "mlbUsername";
            this.mlbUsername.Size = new System.Drawing.Size(71, 20);
            this.mlbUsername.TabIndex = 10;
            this.mlbUsername.Text = "Username";
            // 
            // mtbUsername
            // 
            this.mtbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtbUsername.CustomButton.Image = null;
            this.mtbUsername.CustomButton.Location = new System.Drawing.Point(127, 2);
            this.mtbUsername.CustomButton.Name = "";
            this.mtbUsername.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.mtbUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbUsername.CustomButton.TabIndex = 1;
            this.mtbUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtbUsername.CustomButton.UseSelectable = true;
            this.mtbUsername.CustomButton.Visible = false;
            this.mtbUsername.Lines = new string[] {
        "Leviathan5"};
            this.mtbUsername.Location = new System.Drawing.Point(113, 3);
            this.mtbUsername.MaxLength = 32767;
            this.mtbUsername.Name = "mtbUsername";
            this.mtbUsername.PasswordChar = '\0';
            this.mtbUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbUsername.SelectedText = "";
            this.mtbUsername.SelectionLength = 0;
            this.mtbUsername.SelectionStart = 0;
            this.mtbUsername.Size = new System.Drawing.Size(149, 24);
            this.mtbUsername.TabIndex = 11;
            this.mtbUsername.Text = "Leviathan5";
            this.mtbUsername.UseSelectable = true;
            this.mtbUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mbtnGetVideo
            // 
            this.mbtnGetVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mbtnGetVideo.Location = new System.Drawing.Point(267, 2);
            this.mbtnGetVideo.Margin = new System.Windows.Forms.Padding(2);
            this.mbtnGetVideo.Name = "mbtnGetVideo";
            this.mbtnGetVideo.Size = new System.Drawing.Size(110, 26);
            this.mbtnGetVideo.TabIndex = 16;
            this.mbtnGetVideo.Text = "Get Channel Video";
            this.mbtnGetVideo.UseSelectable = true;
            this.mbtnGetVideo.UseStyleColors = true;
            this.mbtnGetVideo.Click += new System.EventHandler(this.btnGetVideo_Click);
            // 
            // spltVert
            // 
            this.spltVert.BackColor = System.Drawing.Color.Gray;
            this.spltVert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spltVert.Dock = System.Windows.Forms.DockStyle.Right;
            this.spltVert.Location = new System.Drawing.Point(386, 2);
            this.spltVert.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.spltVert.Name = "spltVert";
            this.table.SetRowSpan(this.spltVert, 12);
            this.spltVert.Size = new System.Drawing.Size(3, 330);
            this.spltVert.TabIndex = 17;
            this.spltVert.TabStop = false;
            // 
            // mlbPreview
            // 
            this.mlbPreview.AutoSize = true;
            this.mlbPreview.Dock = System.Windows.Forms.DockStyle.Left;
            this.mlbPreview.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlbPreview.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlbPreview.Location = new System.Drawing.Point(396, 0);
            this.mlbPreview.Margin = new System.Windows.Forms.Padding(0);
            this.mlbPreview.Name = "mlbPreview";
            this.mlbPreview.Size = new System.Drawing.Size(79, 30);
            this.mlbPreview.TabIndex = 18;
            this.mlbPreview.Text = "Preview";
            // 
            // spltChanDown
            // 
            this.spltChanDown.BackColor = System.Drawing.Color.Gray;
            this.spltChanDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.table.SetColumnSpan(this.spltChanDown, 3);
            this.spltChanDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.spltChanDown.Location = new System.Drawing.Point(22, 127);
            this.spltChanDown.Margin = new System.Windows.Forms.Padding(2, 7, 2, 7);
            this.spltChanDown.Name = "spltChanDown";
            this.spltChanDown.Size = new System.Drawing.Size(355, 3);
            this.spltChanDown.TabIndex = 20;
            this.spltChanDown.TabStop = false;
            // 
            // mpbDownload
            // 
            this.table.SetColumnSpan(this.mpbDownload, 3);
            this.mpbDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpbDownload.Location = new System.Drawing.Point(23, 230);
            this.mpbDownload.Name = "mpbDownload";
            this.mpbDownload.Size = new System.Drawing.Size(353, 33);
            this.mpbDownload.TabIndex = 10;
            // 
            // msm
            // 
            this.msm.Owner = this;
            this.msm.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mbtnAbout
            // 
            this.mbtnAbout.Location = new System.Drawing.Point(792, 11);
            this.mbtnAbout.Name = "mbtnAbout";
            this.mbtnAbout.Size = new System.Drawing.Size(41, 15);
            this.mbtnAbout.TabIndex = 11;
            this.mbtnAbout.Text = "About";
            this.mbtnAbout.UseSelectable = true;
            this.mbtnAbout.UseStyleColors = true;
            this.mbtnAbout.Click += new System.EventHandler(this.mbtnAbout_Click);
            // 
            // mlbInfo
            // 
            this.mlbInfo.AutoSize = true;
            this.mlbInfo.Location = new System.Drawing.Point(941, 191);
            this.mlbInfo.Name = "mlbInfo";
            this.mlbInfo.Size = new System.Drawing.Size(70, 19);
            this.mlbInfo.TabIndex = 10;
            this.mlbInfo.Text = "Leviathan5";
            // 
            // mpAbout
            // 
            this.mpAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.mpAbout.Controls.Add(this.tableAbout);
            this.mpAbout.Controls.Add(this.metroLabel1);
            this.mpAbout.Controls.Add(this.mlbInfo);
            this.mpAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpAbout.ForeColor = System.Drawing.Color.Transparent;
            this.mpAbout.HorizontalScrollbarBarColor = true;
            this.mpAbout.HorizontalScrollbarHighlightOnWheel = false;
            this.mpAbout.HorizontalScrollbarSize = 10;
            this.mpAbout.Location = new System.Drawing.Point(0, 60);
            this.mpAbout.Name = "mpAbout";
            this.mpAbout.Padding = new System.Windows.Forms.Padding(300, 5, 300, 5);
            this.mpAbout.Size = new System.Drawing.Size(896, 334);
            this.mpAbout.Style = MetroFramework.MetroColorStyle.Blue;
            this.mpAbout.TabIndex = 12;
            this.mpAbout.UseCustomBackColor = true;
            this.mpAbout.VerticalScrollbarBarColor = true;
            this.mpAbout.VerticalScrollbarHighlightOnWheel = false;
            this.mpAbout.VerticalScrollbarSize = 10;
            // 
            // tableAbout
            // 
            this.tableAbout.BackColor = System.Drawing.Color.Transparent;
            this.tableAbout.ColumnCount = 1;
            this.tableAbout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableAbout.Controls.Add(this.mbtnAboutBack, 0, 10);
            this.tableAbout.Controls.Add(this.mlinkBastion, 0, 8);
            this.tableAbout.Controls.Add(this.mlbStream, 0, 6);
            this.tableAbout.Controls.Add(this.spltDevStream, 0, 5);
            this.tableAbout.Controls.Add(this.mlbLeviathan, 0, 3);
            this.tableAbout.Controls.Add(this.mlbDeveloper, 0, 2);
            this.tableAbout.Controls.Add(this.spltAbout, 0, 1);
            this.tableAbout.Controls.Add(this.mlbAbout, 0, 0);
            this.tableAbout.Controls.Add(this.pbGit, 0, 4);
            this.tableAbout.Controls.Add(this.mlinkLeviathan, 0, 7);
            this.tableAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableAbout.Location = new System.Drawing.Point(300, 5);
            this.tableAbout.Name = "tableAbout";
            this.tableAbout.RowCount = 12;
            this.tableAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableAbout.Size = new System.Drawing.Size(296, 324);
            this.tableAbout.TabIndex = 13;
            // 
            // mbtnAboutBack
            // 
            this.mbtnAboutBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mbtnAboutBack.Location = new System.Drawing.Point(100, 278);
            this.mbtnAboutBack.Margin = new System.Windows.Forms.Padding(100, 10, 100, 10);
            this.mbtnAboutBack.Name = "mbtnAboutBack";
            this.mbtnAboutBack.Size = new System.Drawing.Size(96, 26);
            this.mbtnAboutBack.TabIndex = 29;
            this.mbtnAboutBack.Text = "Back";
            this.mbtnAboutBack.UseSelectable = true;
            this.mbtnAboutBack.UseStyleColors = true;
            this.mbtnAboutBack.Click += new System.EventHandler(this.mbtnAboutBack_Click);
            // 
            // mlinkBastion
            // 
            this.mlinkBastion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlinkBastion.Location = new System.Drawing.Point(3, 220);
            this.mlinkBastion.Name = "mlinkBastion";
            this.mlinkBastion.Size = new System.Drawing.Size(290, 24);
            this.mlinkBastion.TabIndex = 28;
            this.mlinkBastion.Text = "Beam.Pro/BastionConquers";
            this.mlinkBastion.UseCustomBackColor = true;
            this.mlinkBastion.UseSelectable = true;
            this.mlinkBastion.Click += new System.EventHandler(this.mlinkBastion_Click);
            // 
            // mlbStream
            // 
            this.mlbStream.AutoSize = true;
            this.mlbStream.BackColor = System.Drawing.Color.Transparent;
            this.mlbStream.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlbStream.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlbStream.Location = new System.Drawing.Point(3, 169);
            this.mlbStream.Name = "mlbStream";
            this.mlbStream.Size = new System.Drawing.Size(290, 18);
            this.mlbStream.TabIndex = 26;
            this.mlbStream.Text = "Streams";
            this.mlbStream.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mlbStream.UseCustomBackColor = true;
            // 
            // spltDevStream
            // 
            this.spltDevStream.BackColor = System.Drawing.Color.DarkCyan;
            this.tableAbout.SetColumnSpan(this.spltDevStream, 3);
            this.spltDevStream.Dock = System.Windows.Forms.DockStyle.Top;
            this.spltDevStream.Location = new System.Drawing.Point(40, 158);
            this.spltDevStream.Margin = new System.Windows.Forms.Padding(40, 7, 40, 7);
            this.spltDevStream.Name = "spltDevStream";
            this.spltDevStream.Size = new System.Drawing.Size(216, 3);
            this.spltDevStream.TabIndex = 25;
            this.spltDevStream.TabStop = false;
            // 
            // mlbLeviathan
            // 
            this.mlbLeviathan.AutoSize = true;
            this.mlbLeviathan.BackColor = System.Drawing.Color.Transparent;
            this.mlbLeviathan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlbLeviathan.Location = new System.Drawing.Point(3, 86);
            this.mlbLeviathan.Name = "mlbLeviathan";
            this.mlbLeviathan.Size = new System.Drawing.Size(290, 26);
            this.mlbLeviathan.TabIndex = 22;
            this.mlbLeviathan.Text = "Leviathan5";
            this.mlbLeviathan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mlbLeviathan.UseCustomBackColor = true;
            // 
            // mlbDeveloper
            // 
            this.mlbDeveloper.AutoSize = true;
            this.mlbDeveloper.BackColor = System.Drawing.Color.Transparent;
            this.mlbDeveloper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlbDeveloper.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlbDeveloper.Location = new System.Drawing.Point(3, 68);
            this.mlbDeveloper.Name = "mlbDeveloper";
            this.mlbDeveloper.Size = new System.Drawing.Size(290, 18);
            this.mlbDeveloper.TabIndex = 14;
            this.mlbDeveloper.Text = "Developer";
            this.mlbDeveloper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mlbDeveloper.UseCustomBackColor = true;
            // 
            // spltAbout
            // 
            this.spltAbout.BackColor = System.Drawing.Color.DarkCyan;
            this.tableAbout.SetColumnSpan(this.spltAbout, 3);
            this.spltAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.spltAbout.Location = new System.Drawing.Point(2, 57);
            this.spltAbout.Margin = new System.Windows.Forms.Padding(2, 7, 2, 7);
            this.spltAbout.Name = "spltAbout";
            this.spltAbout.Size = new System.Drawing.Size(292, 3);
            this.spltAbout.TabIndex = 21;
            this.spltAbout.TabStop = false;
            // 
            // mlbAbout
            // 
            this.mlbAbout.AutoSize = true;
            this.mlbAbout.BackColor = System.Drawing.Color.Transparent;
            this.mlbAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlbAbout.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlbAbout.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlbAbout.Location = new System.Drawing.Point(3, 0);
            this.mlbAbout.Name = "mlbAbout";
            this.mlbAbout.Size = new System.Drawing.Size(290, 50);
            this.mlbAbout.TabIndex = 12;
            this.mlbAbout.Text = "About";
            this.mlbAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mlbAbout.UseCustomBackColor = true;
            // 
            // pbGit
            // 
            this.pbGit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pbGit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbGit.BackgroundImage")));
            this.pbGit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbGit.Location = new System.Drawing.Point(131, 115);
            this.pbGit.Name = "pbGit";
            this.pbGit.Size = new System.Drawing.Size(33, 33);
            this.pbGit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGit.TabIndex = 23;
            this.pbGit.TabStop = false;
            this.pbGit.Click += new System.EventHandler(this.pbGit_Click);
            // 
            // mlinkLeviathan
            // 
            this.mlinkLeviathan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlinkLeviathan.Location = new System.Drawing.Point(3, 190);
            this.mlinkLeviathan.Name = "mlinkLeviathan";
            this.mlinkLeviathan.Size = new System.Drawing.Size(290, 24);
            this.mlinkLeviathan.TabIndex = 27;
            this.mlinkLeviathan.Text = "Beam.Pro/Leviathan5";
            this.mlinkLeviathan.UseCustomBackColor = true;
            this.mlinkLeviathan.UseSelectable = true;
            this.mlinkLeviathan.Click += new System.EventHandler(this.mlinkLeviathan_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(895, 110);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 25);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Developer";
            // 
            // MainForm
            // 
            this.AcceptButton = this.mbtnGetVideo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 414);
            this.Controls.Add(this.mbtnAbout);
            this.Controls.Add(this.table);
            this.Controls.Add(this.mpAbout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 20);
            this.Resizable = false;
            this.Text = "Beam Stream Down";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msm)).EndInit();
            this.mpAbout.ResumeLayout(false);
            this.mpAbout.PerformLayout();
            this.tableAbout.ResumeLayout(false);
            this.tableAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog savDia;
        private System.Windows.Forms.TableLayoutPanel table;
        private MetroFramework.Controls.MetroLabel mlbUsername;
        private MetroFramework.Components.MetroStyleManager msm;
        private MetroFramework.Controls.MetroLabel mlbChannel;
        private MetroFramework.Controls.MetroTextBox mtbUsername;
        private MetroFramework.Controls.MetroLabel mlbChannelEdit;
        private MetroFramework.Controls.MetroLabel mlbProgressEdit;
        private MetroFramework.Controls.MetroLabel mlbProgress;
        private MetroFramework.Controls.MetroButton mbtnGetVideo;
        private MetroFramework.Controls.MetroProgressBar mpbDownload;
        private System.Windows.Forms.Splitter spltVert;
        private System.Windows.Forms.Splitter spltChanDown;
        private MetroFramework.Controls.MetroButton mbtnCancel;
        private MetroFramework.Controls.MetroButton mbtnDownload;
        private MetroFramework.Controls.MetroButton mbtnPlay;
        private MetroFramework.Controls.MetroLabel mlbSpeedEdit;
        private MetroFramework.Controls.MetroLabel mlbSpeed;
        private MetroFramework.Controls.MetroLabel mlbPercent;
        private System.Windows.Forms.Splitter spltDownSave;
        private MetroFramework.Controls.MetroLabel mlbLocation;
        private MetroFramework.Controls.MetroLabel mlbDateEdit;
        private MetroFramework.Controls.MetroLabel mlbLastUpdated;
        private MetroFramework.Controls.MetroLabel mlbTitleEdit;
        private MetroFramework.Controls.MetroLabel mlbTitle;
        private MetroFramework.Controls.MetroButton mbtnAbout;
        private MetroFramework.Controls.MetroPanel mpAbout;
        private MetroFramework.Controls.MetroLabel mlbInfo;
        private System.Windows.Forms.TableLayoutPanel tableAbout;
        private MetroFramework.Controls.MetroLabel mlbAbout;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Splitter spltAbout;
        private MetroFramework.Controls.MetroLabel mlbLeviathan;
        private MetroFramework.Controls.MetroLabel mlbDeveloper;
        private System.Windows.Forms.PictureBox pbGit;
        private System.Windows.Forms.Splitter spltDevStream;
        private MetroFramework.Controls.MetroLabel mlbStream;
        private MetroFramework.Controls.MetroLink mlinkBastion;
        private MetroFramework.Controls.MetroLink mlinkLeviathan;
        private MetroFramework.Controls.MetroButton mbtnAboutBack;
        private System.Windows.Forms.PictureBox pbPreview;
        private MetroFramework.Controls.MetroLabel mlbPreview;
    }
}

