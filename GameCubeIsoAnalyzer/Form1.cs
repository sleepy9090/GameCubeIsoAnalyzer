using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Copyright Shawn M. Crawford [sleepy9090] 2015, 2016, 2017
namespace GameCubeIsoAnalyzer {
    public partial class Form1 : Form {

        string gamePath = "";
        bool useCustomConsoleID = false;
        bool useCustomMakerCode = false;
        bool useCustomCountryCode = false;

        public Form1() {
            InitializeComponent();
            populateComboBoxMakerCode();
            populateComboBoxCountryCode();
            populateComboBoxConsoleID();

            comboBoxConsoleID.Enabled = false;
            comboBoxCountryCode.Enabled = false;
            comboBoxMakerCode.Enabled = false;

            textBoxConsoleID.Enabled = false;
            textBoxCountryCode.Enabled = false;
            textBoxDiscID.Enabled = false;
            textBoxDVDMagicWord.Enabled = false;
            textBoxFileName.Enabled = false;
            textBoxFSTSize.Enabled = false;
            textBoxGameCode.Enabled = false;
            textBoxGameName.Enabled = false;
            textBoxMainExecutableOffset.Enabled = false;
            textBoxMakerCode.Enabled = false;
            textBoxMaxFSTSize.Enabled = false;
            textBoxOffsetOfDebugMonitor.Enabled = false;
            textBoxOffsetOfFST.Enabled = false;
            textBoxVersion.Enabled = false;
            textBoxAddressToLoadDebugMonitor.Enabled = false;

            textBoxConsoleID.MaxLength = 0x2;
            textBoxCountryCode.MaxLength = 0x2;
            textBoxDiscID.MaxLength = 0x2;
            textBoxDVDMagicWord.MaxLength = 0x8;
            textBoxFSTSize.MaxLength = 0x8;
            textBoxGameCode.MaxLength = 0x2;
            textBoxGameName.MaxLength = 0x3E0;
            textBoxMainExecutableOffset.MaxLength = 0x8;
            textBoxMakerCode.MaxLength = 0x2;
            textBoxMaxFSTSize.MaxLength = 0x8;
            textBoxOffsetOfDebugMonitor.MaxLength = 0x8;
            textBoxOffsetOfFST.MaxLength = 0x8;
            textBoxVersion.MaxLength = 0x2;
            textBoxAddressToLoadDebugMonitor.MaxLength = 0x8;

            checkBoxCustomConsoleID.Enabled = false;
            checkBoxCustomCountryCode.Enabled = false;
            checkBoxCustomMakerCode.Enabled = false;

            writeISOToolStripMenuItem.Enabled = false;

        }

        private void populateComboBoxMakerCode()
        {
            Dictionary<string, string> makerCodes = new Dictionary<string, string>();

            makerCodes.Add("01", "01 - Nintendo");
            makerCodes.Add("08", "08 - Capcom");
            makerCodes.Add("41", "41 - Ubisoft");
            makerCodes.Add("4F", "4F - Eidos");
            makerCodes.Add("51", "51 - Acclaim");
            makerCodes.Add("52", "52 - Activision");
            makerCodes.Add("5D", "5D - Midway");
            makerCodes.Add("5G", "5G - Hudson");
            makerCodes.Add("64", "64 - Lucas Arts");
            makerCodes.Add("69", "69 - Electronic Arts");
            makerCodes.Add("6S", "6S - TDK Mediactive");
            makerCodes.Add("8P", "8P - Sega");
            makerCodes.Add("A4", "A4 - Mirage Studios");
            makerCodes.Add("AF", "AF - Namco");
            makerCodes.Add("B2", "B2 - Bandai");
            makerCodes.Add("DA", "DA - Tomy");
            makerCodes.Add("EM", "EM - Konami");
            makerCodes.Add("??", "?? - Unknown");

            comboBoxMakerCode.DataSource = new BindingSource(makerCodes, null);
            comboBoxMakerCode.DisplayMember = "Value";
            comboBoxMakerCode.ValueMember = "Key";
        }

        private void populateComboBoxCountryCode()
        {
            Dictionary<string, string> countryCodes = new Dictionary<string, string>();

            countryCodes.Add("45", "45h - E - USA/NTSC");
            countryCodes.Add("4A", "4Ah - J - Japan/NTSC");
            countryCodes.Add("50", "50h - P - Europe/PAL");
            countryCodes.Add("55", "55h - U - Europe/PAL (LoZ Oot (MQ))?");
            countryCodes.Add("??", "??h - Unknown");

            comboBoxCountryCode.DataSource = new BindingSource(countryCodes, null);
            comboBoxCountryCode.DisplayMember = "Value";
            comboBoxCountryCode.ValueMember = "Key";
        }

        private void populateComboBoxConsoleID()
        {
            Dictionary<string, string> consoleIDs = new Dictionary<string, string>();

            consoleIDs.Add("44", "44h - D - Emulated/Ported/Promotional");
            consoleIDs.Add("47", "47h - G - Gamecube");
            consoleIDs.Add("55", "55h - U - GBA-Player Boot CD");
            consoleIDs.Add("??", "??h - Unknown");

            comboBoxConsoleID.DataSource = new BindingSource(consoleIDs, null);
            comboBoxConsoleID.DisplayMember = "Value";
            comboBoxConsoleID.ValueMember = "Key";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open file...";
            openFileDialog.Filter = "ISO/GCM files (*.iso, *.gcm)|*.iso;*.gcm|All files (*.*)|*.*";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK) {

                textBoxConsoleID.Enabled = true;
                textBoxCountryCode.Enabled = true;
                textBoxDiscID.Enabled = true;
                textBoxDVDMagicWord.Enabled = true;
                textBoxFileName.Enabled = true;
                textBoxFSTSize.Enabled = true;
                textBoxGameCode.Enabled = true;
                textBoxGameName.Enabled = true;
                textBoxMainExecutableOffset.Enabled = true;
                textBoxMakerCode.Enabled = true;
                textBoxMaxFSTSize.Enabled = true;
                textBoxOffsetOfDebugMonitor.Enabled = true;
                textBoxOffsetOfFST.Enabled = true;
                textBoxVersion.Enabled = true;
                textBoxAddressToLoadDebugMonitor.Enabled = true;

                checkBoxCustomConsoleID.Enabled = true;
                checkBoxCustomCountryCode.Enabled = true;
                checkBoxCustomMakerCode.Enabled = true;

                writeISOToolStripMenuItem.Enabled = true;

                comboBoxConsoleID.Enabled = true;
                comboBoxCountryCode.Enabled = true;
                comboBoxMakerCode.Enabled = true;

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

                textBoxFileName.ReadOnly = true;
                textBoxConsoleID.ReadOnly = true;
                textBoxCountryCode.ReadOnly = true;
                textBoxMakerCode.ReadOnly = true;

                textBoxFileName.Text = openFileDialog.FileName;

                string path = textBoxFileName.Text;
                gamePath = path;
                parseIsoFile(path);
            }
        }

        private void parseIsoFile(string path) {
            GCDiscInfo gCDiscInfo = new GCDiscInfo(path);

            string consoleID = gCDiscInfo.getConsoleId();
            string countryCode = gCDiscInfo.getCountryCode();
            string makerCode = gCDiscInfo.getMakerCode();

            textBoxGameName.Text = gCDiscInfo.getGameName();
            textBoxConsoleID.Text = consoleID;
            textBoxCountryCode.Text = countryCode;
            textBoxDiscID.Text = gCDiscInfo.getDiscId();
            textBoxDVDMagicWord.Text = gCDiscInfo.getDVDMagicWord();
            textBoxFSTSize.Text = gCDiscInfo.getFSTSize();
            textBoxGameCode.Text = gCDiscInfo.getGameCode();
            textBoxMainExecutableOffset.Text = gCDiscInfo.getMainExecutableDOLOffset();
            textBoxMakerCode.Text = makerCode;
            textBoxMaxFSTSize.Text = gCDiscInfo.getMaxFSTSize();
            textBoxOffsetOfDebugMonitor.Text = gCDiscInfo.getDebugMonitorOffset();
            textBoxOffsetOfFST.Text = gCDiscInfo.getFSTOffset();
            textBoxVersion.Text = gCDiscInfo.getVersion();
            textBoxAddressToLoadDebugMonitor.Text = gCDiscInfo.getDebugMonitorLoadAddress();

            setComboBoxConsoleID(consoleID);
            setComboBoxCountryCode(countryCode);
            setComboBoxMakerCode(makerCode);
        }

        private void setComboBoxConsoleID(string consoleID)
        {
            switch(consoleID)
            {
                case "44":
                    comboBoxConsoleID.SelectedIndex = 0;
                    break;
                case "47":
                    comboBoxConsoleID.SelectedIndex = 1;
                    break;
                case "55":
                    comboBoxConsoleID.SelectedIndex = 2;
                    break;
                default:
                    comboBoxConsoleID.SelectedIndex = 3;
                    break;
            }
        }

        private void setComboBoxCountryCode(string countryCode)
        {
            switch(countryCode)
            {
                case "45":
                    comboBoxCountryCode.SelectedIndex = 0;
                    break;
                case "4A":
                    comboBoxCountryCode.SelectedIndex = 1;
                    break;
                case "50":
                    comboBoxCountryCode.SelectedIndex = 2;
                    break;
                case "55":
                    comboBoxCountryCode.SelectedIndex = 3;
                    break;
                default:
                    comboBoxCountryCode.SelectedIndex = 4;
                    break;
            }
        }

        private void setComboBoxMakerCode(string makerCode)
        {
            switch(makerCode)
            {
                case "01":
                    comboBoxMakerCode.SelectedIndex = 0;
                    break;
                case "08":
                    comboBoxMakerCode.SelectedIndex = 1;
                    break;
                case "41":
                    comboBoxMakerCode.SelectedIndex = 2;
                    break;
                case "4F":
                    comboBoxMakerCode.SelectedIndex = 3;
                    break;
                case "51":
                    comboBoxMakerCode.SelectedIndex = 4;
                    break;
                case "52":
                    comboBoxMakerCode.SelectedIndex = 5;
                    break;
                case "5D":
                    comboBoxMakerCode.SelectedIndex = 6;
                    break;
                case "5G":
                    comboBoxMakerCode.SelectedIndex = 7;
                    break;
                case "64":
                    comboBoxMakerCode.SelectedIndex = 8;
                    break;
                case "69":
                    comboBoxMakerCode.SelectedIndex = 9;
                    break;
                case "6S":
                    comboBoxMakerCode.SelectedIndex = 10;
                    break;
                case "8P":
                    comboBoxMakerCode.SelectedIndex = 11;
                    break;
                case "A4":
                    comboBoxMakerCode.SelectedIndex = 12;
                    break;
                case "AF":
                    comboBoxMakerCode.SelectedIndex = 13;
                    break;
                case "B2":
                    comboBoxMakerCode.SelectedIndex = 14;
                    break;
                case "DA":
                    comboBoxMakerCode.SelectedIndex = 15;
                    break;
                case "EM":
                    comboBoxMakerCode.SelectedIndex = 16;
                    break;
                default:
                    comboBoxMakerCode.SelectedIndex = 17;
                    break;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            System.Windows.Forms.Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            AboutBox1 aboutbox = new AboutBox1();
            aboutbox.ShowDialog();
        }

        public void validateHexInput(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar >= 'A' && e.KeyChar <= 'F' || e.KeyChar >= 'a' && e.KeyChar <= 'f' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void checkBoxCustomConsoleID_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxCustomConsoleID.Checked)
            {
                textBoxConsoleID.ReadOnly = false;
                useCustomConsoleID = true;
            }
            else
            {
                textBoxConsoleID.ReadOnly = true;
                useCustomConsoleID = false;
            }
        }

        private void checkBoxCustomMakerCode_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCustomMakerCode.Checked)
            {
                textBoxMakerCode.ReadOnly = false;
                useCustomMakerCode = true;
            }
            else
            {
                textBoxMakerCode.ReadOnly = true;
                useCustomMakerCode = false;
            }
        }

        private void checkBoxCustomCountryCode_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCustomCountryCode.Checked)
            {
                textBoxCountryCode.ReadOnly = false;
                useCustomCountryCode = true;
            }
            else
            {
                textBoxCountryCode.ReadOnly = true;
                useCustomCountryCode = false;
            }
        }


    }
}
