using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Copyright Shawn M. Crawford [sleepy9090] 2015
namespace GameCubeIsoAnalyzer {
    class GCDiscInfo {

        string path;

        public GCDiscInfo(string gamePath) {
            path = gamePath;
        }

        public string getGameName() {
            return convertHexToAscii(getHexStringFromFile(00000032, 992));
        }

        public string getConsoleId() {

            string consoleIdPretty;
            string consoleId = getHexStringFromFile(00000000, 1);

            switch (consoleId) {
                case "44":
                    consoleIdPretty = "D - Emulated/Ported/Promotional";
                    break;
                case "47":
                    consoleIdPretty = "G - Gamecube";
                    break;
                case "55":
                    consoleIdPretty = "U - GBA-Player Boot CD";
                    break;
                default:
                    consoleIdPretty = "Unknown";
                    break;
            }

            return consoleIdPretty;
        }

        public string getGameCode() {
            return convertHexToAscii(getHexStringFromFile(00000001, 2));
        }

        public string getCountryCode() {

            string countryCodePretty;
            string countryCodeId = getHexStringFromFile(00000003, 1);

            switch (countryCodeId) {
                case "45":
                    countryCodePretty = "E - USA/NTSC";
                    break;
                case "50":
                    countryCodePretty = "P - Europe/PAL";
                    break;
                case "4A":
                    countryCodePretty = "J - Japan/NTSC";
                    break;
                case "55":
                    countryCodePretty = "U - Europe/PAL (LoZ Oot (MQ))?";
                    break;
                default:
                    countryCodePretty = "Unknown";
                    break;
            }

            return countryCodePretty;
        }

        public string getMakerCode() {

            string makerCodeAscii = convertHexToAscii(getHexStringFromFile(00000004, 2));
            string vendor = "";

            switch (makerCodeAscii) {
                case "01":
                    vendor = "Nintendo";
                    break;
                case "08":
                    vendor = "Capcom";
                    break;
                case "41":
                    vendor = "Ubisoft";
                    break;
                case "4F":
                    vendor = "Eidos";
                    break;
                case "51":
                    vendor = "Acclaim";
                    break;
                case "52":
                    vendor = "Activision";
                    break;
                case "5D":
                    vendor = "Midway";
                    break;
                case "5G":
                    vendor = "Hudson";
                    break;
                case "64":
                    vendor = "Lucas Arts";
                    break;
                case "69":
                    vendor = "Electronic Arts";
                    break;
                case "6S":
                    vendor = "TDK Mediactive";
                    break;
                case "8P":
                    vendor = "Sega";
                    break;
                case "A4":
                    vendor = "Mirage Studios";
                    break;
                case "AF":
                    vendor = "Namco";
                    break;
                case "B2":
                    vendor = "Bandai";
                    break;
                case "DA":
                    vendor = "Tomy";
                    break;
                case "EM":
                    vendor = "Konami";
                    break;
                default:
                    vendor = "Unknown";
                    break;
            }

            return vendor;
        }

        public string getDiscId() {
            return getHexStringFromFile(00000006, 1);
        }

        public string getVersion() {
            return getHexStringFromFile(00000007, 1);
        }

        public string getDVDMagicWord() {
            return "0x" + getHexStringFromFile(00000028, 4);
        }

        public string getDebugMonitorOffset() {
            return "0x" + getHexStringFromFile(00001024, 4);
        }

        public string getDebugMonitorLoadAddress() {
            return "0x" + getHexStringFromFile(00001028, 4);
        }

        public string getMainExecutableDOLOffset() {
            return "0x" + getHexStringFromFile(00001056, 4);
        }

        public string getFSTOffset() {
            return "0x" + getHexStringFromFile(00001060, 4);
        }

        public string getFSTSize() {
            return "0x" + getHexStringFromFile(00001064, 4);
        }

        public string getMaxFSTSize() {
            return "0x" + getHexStringFromFile(00001068, 4);
        }

        private static string convertHexToAscii(String hexString) {
            try {
                string ascii = string.Empty;

                for (int i = 0; i < hexString.Length; i += 2) {
                    String hs = string.Empty;

                    hs = hexString.Substring(i, 2);
                    uint decval = System.Convert.ToUInt32(hs, 16);
                    char character = System.Convert.ToChar(decval);
                    ascii += character;

                }

                return ascii;
            } catch (Exception ex) { Console.WriteLine(ex.Message); }

            return string.Empty;
        }

        private string getHexStringFromFile(int startPoint, int length) {

            string hexString = "";

            FileStream fileStream = new FileStream(@path, FileMode.Open, FileAccess.Read);
            long offset = fileStream.Seek(startPoint, SeekOrigin.Begin);

            for (int x = 0; x < length; x++) {
                hexString += fileStream.ReadByte().ToString("X2");
            }

            fileStream.Close();

            return hexString;
        }
    }
}
