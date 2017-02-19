using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Copyright Shawn M. Crawford [sleepy9090] 2015
namespace GameCubeIsoAnalyzer {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open file...";
            openFileDialog.Filter = "ISO/GCM files (*.iso, *.gcm)|*.iso;*.gcm|All files (*.*)|*.*";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK) {

                textBoxConsoleID.Clear();
                textBoxCountryCode.Clear();
                textBoxDiscID.Clear();
                textBoxDVDMagicWord.Clear();
                textBoxFileName.Clear();
                textBoxFSTSize.Clear();
                textBoxGameCode.Clear();
                textBoxGameName.Clear();
                textBoxMainExecutableOffset.Clear();
                textBoxMakerCode.Clear();
                textBoxMaxFSTSize.Clear();
                textBoxOffsetOfDebugMonitor.Clear();
                textBoxOffsetOfFST.Clear();
                textBoxVersion.Clear();
                textBoxAddressToLoadDebugMonitor.Clear();
                
                textBoxFileName.Text = openFileDialog.FileName;

                string path = textBoxFileName.Text;
                parseIsoFile(path);
            }
        }

        private void parseIsoFile(string path) {
            GCDiscInfo gCDiscInfo = new GCDiscInfo(path);

            textBoxGameName.Text = gCDiscInfo.getGameName();
            textBoxConsoleID.Text = gCDiscInfo.getConsoleId();
            textBoxCountryCode.Text = gCDiscInfo.getCountryCode();
            textBoxDiscID.Text = gCDiscInfo.getDiscId();
            textBoxDVDMagicWord.Text = gCDiscInfo.getDVDMagicWord();
            textBoxFSTSize.Text = gCDiscInfo.getFSTSize();
            textBoxGameCode.Text = gCDiscInfo.getGameCode();
            textBoxMainExecutableOffset.Text = gCDiscInfo.getMainExecutableDOLOffset();
            textBoxMakerCode.Text = gCDiscInfo.getMakerCode();
            textBoxMaxFSTSize.Text = gCDiscInfo.getMaxFSTSize();
            textBoxOffsetOfDebugMonitor.Text = gCDiscInfo.getDebugMonitorOffset();
            textBoxOffsetOfFST.Text = gCDiscInfo.getFSTOffset();
            textBoxVersion.Text = gCDiscInfo.getVersion();
            textBoxAddressToLoadDebugMonitor.Text = gCDiscInfo.getDebugMonitorLoadAddress();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            System.Windows.Forms.Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            AboutBox1 aboutbox = new AboutBox1();
            aboutbox.ShowDialog();
        }
    }
}
