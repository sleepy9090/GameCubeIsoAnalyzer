namespace GameCubeIsoAnalyzer {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelConsoleID = new System.Windows.Forms.Label();
            this.textBoxConsoleID = new System.Windows.Forms.TextBox();
            this.labelGameCode = new System.Windows.Forms.Label();
            this.textBoxGameCode = new System.Windows.Forms.TextBox();
            this.textBoxCountryCode = new System.Windows.Forms.TextBox();
            this.labelCountryCode = new System.Windows.Forms.Label();
            this.labelMakerCode = new System.Windows.Forms.Label();
            this.textBoxMakerCode = new System.Windows.Forms.TextBox();
            this.labelDiscID = new System.Windows.Forms.Label();
            this.textBoxDiscID = new System.Windows.Forms.TextBox();
            this.textBoxVersion = new System.Windows.Forms.TextBox();
            this.labelVersion = new System.Windows.Forms.Label();
            this.textBoxDVDMagicWord = new System.Windows.Forms.TextBox();
            this.labelDVDMagicWord = new System.Windows.Forms.Label();
            this.textBoxGameName = new System.Windows.Forms.TextBox();
            this.labelGameName = new System.Windows.Forms.Label();
            this.textBoxOffsetOfDebugMonitor = new System.Windows.Forms.TextBox();
            this.labelDebugMonitorOffset = new System.Windows.Forms.Label();
            this.textBoxAddressToLoadDebugMonitor = new System.Windows.Forms.TextBox();
            this.labelAddressToLoadDebugMonitor = new System.Windows.Forms.Label();
            this.textBoxMainExecutableOffset = new System.Windows.Forms.TextBox();
            this.labelOffsetOfMainExecutable = new System.Windows.Forms.Label();
            this.textBoxOffsetOfFST = new System.Windows.Forms.TextBox();
            this.labelOffsetOfFST = new System.Windows.Forms.Label();
            this.textBoxFSTSize = new System.Windows.Forms.TextBox();
            this.labelFSTSize = new System.Windows.Forms.Label();
            this.textBoxMaxFSTSize = new System.Windows.Forms.TextBox();
            this.labelMaxFSTSize = new System.Windows.Forms.Label();
            this.labelFileName = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.textBoxFileName);
            this.groupBox1.Controls.Add(this.labelFileName);
            this.groupBox1.Controls.Add(this.labelMaxFSTSize);
            this.groupBox1.Controls.Add(this.textBoxMaxFSTSize);
            this.groupBox1.Controls.Add(this.labelFSTSize);
            this.groupBox1.Controls.Add(this.textBoxFSTSize);
            this.groupBox1.Controls.Add(this.labelOffsetOfFST);
            this.groupBox1.Controls.Add(this.textBoxOffsetOfFST);
            this.groupBox1.Controls.Add(this.labelOffsetOfMainExecutable);
            this.groupBox1.Controls.Add(this.textBoxMainExecutableOffset);
            this.groupBox1.Controls.Add(this.labelAddressToLoadDebugMonitor);
            this.groupBox1.Controls.Add(this.textBoxAddressToLoadDebugMonitor);
            this.groupBox1.Controls.Add(this.labelDebugMonitorOffset);
            this.groupBox1.Controls.Add(this.textBoxOffsetOfDebugMonitor);
            this.groupBox1.Controls.Add(this.labelGameName);
            this.groupBox1.Controls.Add(this.textBoxGameName);
            this.groupBox1.Controls.Add(this.labelDVDMagicWord);
            this.groupBox1.Controls.Add(this.textBoxDVDMagicWord);
            this.groupBox1.Controls.Add(this.labelVersion);
            this.groupBox1.Controls.Add(this.textBoxVersion);
            this.groupBox1.Controls.Add(this.textBoxDiscID);
            this.groupBox1.Controls.Add(this.labelDiscID);
            this.groupBox1.Controls.Add(this.textBoxMakerCode);
            this.groupBox1.Controls.Add(this.labelMakerCode);
            this.groupBox1.Controls.Add(this.labelCountryCode);
            this.groupBox1.Controls.Add(this.textBoxCountryCode);
            this.groupBox1.Controls.Add(this.textBoxGameCode);
            this.groupBox1.Controls.Add(this.labelGameCode);
            this.groupBox1.Controls.Add(this.textBoxConsoleID);
            this.groupBox1.Controls.Add(this.labelConsoleID);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 377);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.openToolStripMenuItem.Text = "&Open GameCube ISO/GCM";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // labelConsoleID
            // 
            this.labelConsoleID.AutoSize = true;
            this.labelConsoleID.Location = new System.Drawing.Point(6, 72);
            this.labelConsoleID.Name = "labelConsoleID";
            this.labelConsoleID.Size = new System.Drawing.Size(62, 13);
            this.labelConsoleID.TabIndex = 0;
            this.labelConsoleID.Text = "Console ID:";
            // 
            // textBoxConsoleID
            // 
            this.textBoxConsoleID.Location = new System.Drawing.Point(81, 69);
            this.textBoxConsoleID.Name = "textBoxConsoleID";
            this.textBoxConsoleID.ReadOnly = true;
            this.textBoxConsoleID.Size = new System.Drawing.Size(100, 20);
            this.textBoxConsoleID.TabIndex = 3;
            // 
            // labelGameCode
            // 
            this.labelGameCode.AutoSize = true;
            this.labelGameCode.Location = new System.Drawing.Point(6, 98);
            this.labelGameCode.Name = "labelGameCode";
            this.labelGameCode.Size = new System.Drawing.Size(66, 13);
            this.labelGameCode.TabIndex = 2;
            this.labelGameCode.Text = "Game Code:";
            // 
            // textBoxGameCode
            // 
            this.textBoxGameCode.Location = new System.Drawing.Point(81, 95);
            this.textBoxGameCode.Name = "textBoxGameCode";
            this.textBoxGameCode.ReadOnly = true;
            this.textBoxGameCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxGameCode.TabIndex = 6;
            // 
            // textBoxCountryCode
            // 
            this.textBoxCountryCode.Location = new System.Drawing.Point(81, 121);
            this.textBoxCountryCode.Name = "textBoxCountryCode";
            this.textBoxCountryCode.ReadOnly = true;
            this.textBoxCountryCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxCountryCode.TabIndex = 8;
            // 
            // labelCountryCode
            // 
            this.labelCountryCode.AutoSize = true;
            this.labelCountryCode.Location = new System.Drawing.Point(6, 124);
            this.labelCountryCode.Name = "labelCountryCode";
            this.labelCountryCode.Size = new System.Drawing.Size(74, 13);
            this.labelCountryCode.TabIndex = 5;
            this.labelCountryCode.Text = "Country Code:";
            // 
            // labelMakerCode
            // 
            this.labelMakerCode.AutoSize = true;
            this.labelMakerCode.Location = new System.Drawing.Point(205, 72);
            this.labelMakerCode.Name = "labelMakerCode";
            this.labelMakerCode.Size = new System.Drawing.Size(68, 13);
            this.labelMakerCode.TabIndex = 6;
            this.labelMakerCode.Text = "Maker Code:";
            // 
            // textBoxMakerCode
            // 
            this.textBoxMakerCode.Location = new System.Drawing.Point(279, 69);
            this.textBoxMakerCode.Name = "textBoxMakerCode";
            this.textBoxMakerCode.ReadOnly = true;
            this.textBoxMakerCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxMakerCode.TabIndex = 4;
            // 
            // labelDiscID
            // 
            this.labelDiscID.AutoSize = true;
            this.labelDiscID.Location = new System.Drawing.Point(205, 98);
            this.labelDiscID.Name = "labelDiscID";
            this.labelDiscID.Size = new System.Drawing.Size(45, 13);
            this.labelDiscID.TabIndex = 8;
            this.labelDiscID.Text = "Disc ID:";
            // 
            // textBoxDiscID
            // 
            this.textBoxDiscID.Location = new System.Drawing.Point(279, 95);
            this.textBoxDiscID.Name = "textBoxDiscID";
            this.textBoxDiscID.ReadOnly = true;
            this.textBoxDiscID.Size = new System.Drawing.Size(100, 20);
            this.textBoxDiscID.TabIndex = 7;
            // 
            // textBoxVersion
            // 
            this.textBoxVersion.Location = new System.Drawing.Point(279, 121);
            this.textBoxVersion.Name = "textBoxVersion";
            this.textBoxVersion.ReadOnly = true;
            this.textBoxVersion.Size = new System.Drawing.Size(100, 20);
            this.textBoxVersion.TabIndex = 9;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(205, 124);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(45, 13);
            this.labelVersion.TabIndex = 11;
            this.labelVersion.Text = "Version:";
            // 
            // textBoxDVDMagicWord
            // 
            this.textBoxDVDMagicWord.Location = new System.Drawing.Point(494, 69);
            this.textBoxDVDMagicWord.Name = "textBoxDVDMagicWord";
            this.textBoxDVDMagicWord.ReadOnly = true;
            this.textBoxDVDMagicWord.Size = new System.Drawing.Size(100, 20);
            this.textBoxDVDMagicWord.TabIndex = 5;
            // 
            // labelDVDMagicWord
            // 
            this.labelDVDMagicWord.AutoSize = true;
            this.labelDVDMagicWord.Location = new System.Drawing.Point(394, 72);
            this.labelDVDMagicWord.Name = "labelDVDMagicWord";
            this.labelDVDMagicWord.Size = new System.Drawing.Size(94, 13);
            this.labelDVDMagicWord.TabIndex = 13;
            this.labelDVDMagicWord.Text = "DVD Magic Word:";
            // 
            // textBoxGameName
            // 
            this.textBoxGameName.Location = new System.Drawing.Point(81, 41);
            this.textBoxGameName.Name = "textBoxGameName";
            this.textBoxGameName.ReadOnly = true;
            this.textBoxGameName.Size = new System.Drawing.Size(513, 20);
            this.textBoxGameName.TabIndex = 2;
            // 
            // labelGameName
            // 
            this.labelGameName.AutoSize = true;
            this.labelGameName.Location = new System.Drawing.Point(6, 44);
            this.labelGameName.Name = "labelGameName";
            this.labelGameName.Size = new System.Drawing.Size(69, 13);
            this.labelGameName.TabIndex = 15;
            this.labelGameName.Text = "Game Name:";
            // 
            // textBoxOffsetOfDebugMonitor
            // 
            this.textBoxOffsetOfDebugMonitor.Location = new System.Drawing.Point(208, 149);
            this.textBoxOffsetOfDebugMonitor.Name = "textBoxOffsetOfDebugMonitor";
            this.textBoxOffsetOfDebugMonitor.ReadOnly = true;
            this.textBoxOffsetOfDebugMonitor.Size = new System.Drawing.Size(100, 20);
            this.textBoxOffsetOfDebugMonitor.TabIndex = 10;
            // 
            // labelDebugMonitorOffset
            // 
            this.labelDebugMonitorOffset.AutoSize = true;
            this.labelDebugMonitorOffset.Location = new System.Drawing.Point(6, 152);
            this.labelDebugMonitorOffset.Name = "labelDebugMonitorOffset";
            this.labelDebugMonitorOffset.Size = new System.Drawing.Size(149, 13);
            this.labelDebugMonitorOffset.TabIndex = 17;
            this.labelDebugMonitorOffset.Text = "Debug Monitor Offset (dh.bin):";
            // 
            // textBoxAddressToLoadDebugMonitor
            // 
            this.textBoxAddressToLoadDebugMonitor.Location = new System.Drawing.Point(208, 175);
            this.textBoxAddressToLoadDebugMonitor.Name = "textBoxAddressToLoadDebugMonitor";
            this.textBoxAddressToLoadDebugMonitor.ReadOnly = true;
            this.textBoxAddressToLoadDebugMonitor.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddressToLoadDebugMonitor.TabIndex = 12;
            // 
            // labelAddressToLoadDebugMonitor
            // 
            this.labelAddressToLoadDebugMonitor.AutoSize = true;
            this.labelAddressToLoadDebugMonitor.Location = new System.Drawing.Point(6, 178);
            this.labelAddressToLoadDebugMonitor.Name = "labelAddressToLoadDebugMonitor";
            this.labelAddressToLoadDebugMonitor.Size = new System.Drawing.Size(160, 13);
            this.labelAddressToLoadDebugMonitor.TabIndex = 19;
            this.labelAddressToLoadDebugMonitor.Text = "Address to Load Debug Monitor:";
            // 
            // textBoxMainExecutableOffset
            // 
            this.textBoxMainExecutableOffset.Location = new System.Drawing.Point(208, 201);
            this.textBoxMainExecutableOffset.Name = "textBoxMainExecutableOffset";
            this.textBoxMainExecutableOffset.ReadOnly = true;
            this.textBoxMainExecutableOffset.Size = new System.Drawing.Size(100, 20);
            this.textBoxMainExecutableOffset.TabIndex = 14;
            // 
            // labelOffsetOfMainExecutable
            // 
            this.labelOffsetOfMainExecutable.AutoSize = true;
            this.labelOffsetOfMainExecutable.Location = new System.Drawing.Point(6, 204);
            this.labelOffsetOfMainExecutable.Name = "labelOffsetOfMainExecutable";
            this.labelOffsetOfMainExecutable.Size = new System.Drawing.Size(200, 13);
            this.labelOffsetOfMainExecutable.TabIndex = 21;
            this.labelOffsetOfMainExecutable.Text = "Offset of Main Executable DOL (bootfile):";
            // 
            // textBoxOffsetOfFST
            // 
            this.textBoxOffsetOfFST.Location = new System.Drawing.Point(466, 149);
            this.textBoxOffsetOfFST.Name = "textBoxOffsetOfFST";
            this.textBoxOffsetOfFST.ReadOnly = true;
            this.textBoxOffsetOfFST.Size = new System.Drawing.Size(100, 20);
            this.textBoxOffsetOfFST.TabIndex = 11;
            // 
            // labelOffsetOfFST
            // 
            this.labelOffsetOfFST.AutoSize = true;
            this.labelOffsetOfFST.Location = new System.Drawing.Point(332, 152);
            this.labelOffsetOfFST.Name = "labelOffsetOfFST";
            this.labelOffsetOfFST.Size = new System.Drawing.Size(128, 13);
            this.labelOffsetOfFST.TabIndex = 23;
            this.labelOffsetOfFST.Text = "Offset of the FST (fst.bin):";
            // 
            // textBoxFSTSize
            // 
            this.textBoxFSTSize.Location = new System.Drawing.Point(466, 175);
            this.textBoxFSTSize.Name = "textBoxFSTSize";
            this.textBoxFSTSize.ReadOnly = true;
            this.textBoxFSTSize.Size = new System.Drawing.Size(100, 20);
            this.textBoxFSTSize.TabIndex = 13;
            // 
            // labelFSTSize
            // 
            this.labelFSTSize.AutoSize = true;
            this.labelFSTSize.Location = new System.Drawing.Point(332, 178);
            this.labelFSTSize.Name = "labelFSTSize";
            this.labelFSTSize.Size = new System.Drawing.Size(53, 13);
            this.labelFSTSize.TabIndex = 25;
            this.labelFSTSize.Text = "FST Size:";
            // 
            // textBoxMaxFSTSize
            // 
            this.textBoxMaxFSTSize.Location = new System.Drawing.Point(466, 201);
            this.textBoxMaxFSTSize.Name = "textBoxMaxFSTSize";
            this.textBoxMaxFSTSize.ReadOnly = true;
            this.textBoxMaxFSTSize.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxFSTSize.TabIndex = 15;
            // 
            // labelMaxFSTSize
            // 
            this.labelMaxFSTSize.AutoSize = true;
            this.labelMaxFSTSize.Location = new System.Drawing.Point(332, 204);
            this.labelMaxFSTSize.Name = "labelMaxFSTSize";
            this.labelMaxFSTSize.Size = new System.Drawing.Size(76, 13);
            this.labelMaxFSTSize.TabIndex = 27;
            this.labelMaxFSTSize.Text = "Max FST Size:";
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(6, 16);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(52, 13);
            this.labelFileName.TabIndex = 28;
            this.labelFileName.Text = "Filename:";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(81, 13);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.ReadOnly = true;
            this.textBoxFileName.Size = new System.Drawing.Size(513, 20);
            this.textBoxFileName.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 238);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(576, 129);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(215, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 417);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "GameCube Iso Analyzer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label labelOffsetOfMainExecutable;
        private System.Windows.Forms.TextBox textBoxMainExecutableOffset;
        private System.Windows.Forms.Label labelAddressToLoadDebugMonitor;
        private System.Windows.Forms.TextBox textBoxAddressToLoadDebugMonitor;
        private System.Windows.Forms.Label labelDebugMonitorOffset;
        private System.Windows.Forms.TextBox textBoxOffsetOfDebugMonitor;
        private System.Windows.Forms.Label labelGameName;
        private System.Windows.Forms.TextBox textBoxGameName;
        private System.Windows.Forms.Label labelDVDMagicWord;
        private System.Windows.Forms.TextBox textBoxDVDMagicWord;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.TextBox textBoxVersion;
        private System.Windows.Forms.TextBox textBoxDiscID;
        private System.Windows.Forms.Label labelDiscID;
        private System.Windows.Forms.TextBox textBoxMakerCode;
        private System.Windows.Forms.Label labelMakerCode;
        private System.Windows.Forms.Label labelCountryCode;
        private System.Windows.Forms.TextBox textBoxCountryCode;
        private System.Windows.Forms.TextBox textBoxGameCode;
        private System.Windows.Forms.Label labelGameCode;
        private System.Windows.Forms.TextBox textBoxConsoleID;
        private System.Windows.Forms.Label labelConsoleID;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Label labelMaxFSTSize;
        private System.Windows.Forms.TextBox textBoxMaxFSTSize;
        private System.Windows.Forms.Label labelFSTSize;
        private System.Windows.Forms.TextBox textBoxFSTSize;
        private System.Windows.Forms.Label labelOffsetOfFST;
        private System.Windows.Forms.TextBox textBoxOffsetOfFST;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

