using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Copyright Shawn M. Crawford [sleepy9090] 2015, 2016, 2017
namespace GameCubeIsoAnalyzer {
    class GCDiscInfo {

        string path;

        public GCDiscInfo(string gamePath) {
            path = gamePath;
        }

        public string getGameName() {
            return convertHexToAscii(getHexStringFromFile(00000032, 0x3E0));
        }

        public string getConsoleId() {
            return getHexStringFromFile(00000000, 1);
        }

        public string getGameCode() {
            return convertHexToAscii(getHexStringFromFile(00000001, 2));
        }

        public string getCountryCode() {
            return getHexStringFromFile(00000003, 1);
        }

        public string getMakerCode() {
            return convertHexToAscii(getHexStringFromFile(00000004, 2));
        }

        public string getDiscId() {
            return getHexStringFromFile(00000006, 0x1);
        }

        public string getVersion() {
            return getHexStringFromFile(00000007, 0x1);
        }

        public string getDVDMagicWord() {
            return getHexStringFromFile(00000028, 0x4);
        }

        public string getDebugMonitorOffset() {
            return getHexStringFromFile(00001024, 0x4);
        }

        public string getDebugMonitorLoadAddress() {
            return getHexStringFromFile(00001028, 0x4);
        }

        public string getMainExecutableDOLOffset() {
            return getHexStringFromFile(00001056, 0x4);
        }

        public string getFSTOffset() {
            return getHexStringFromFile(00001060, 0x4);
        }

        public string getFSTSize() {
            return getHexStringFromFile(00001064, 0x4);
        }

        public string getMaxFSTSize() {
            return getHexStringFromFile(00001068, 0x4);
        }

        private static string convertAsciiToHex(String asciiString)
        {
            char[] charValues = asciiString.ToCharArray();
            string hexValue = "";
            foreach (char c in charValues)
            {
                int value = Convert.ToInt32(c);
                hexValue += String.Format("{0:X}", value);
            }
            return hexValue;
        }

        private static string convertHexToAscii(String hexString)
        {
            try
            {
                string ascii = string.Empty;

                for (int i = 0; i < hexString.Length; i += 2)
                {
                    String hs = string.Empty;

                    hs = hexString.Substring(i, 2);
                    uint decval = System.Convert.ToUInt32(hs, 16);
                    char character = System.Convert.ToChar(decval);
                    ascii += character;

                }

                return ascii;
            }
            catch (Exception ex)
            {
                // Console.WriteLine(ex.Message);
            }

            return string.Empty;
        }

        private string getHexStringFromFile(int startPoint, int length)
        {
            string hexString = "";
            using (FileStream fileStream = new FileStream(@path, FileMode.Open, FileAccess.Read))
            {
                long offset = fileStream.Seek(startPoint, SeekOrigin.Begin);

                for (int x = 0; x < length; x++)
                {
                    hexString += fileStream.ReadByte().ToString("X2");
                }

            }

            return hexString;
        }

        private static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        private bool writeByteArrayToFile(string fileName, int startPoint, byte[] byteArray)
        {
            bool result = false;
            try
            {
                using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite))
                {
                    fs.Position = startPoint;
                    fs.Write(byteArray, 0, byteArray.Length);
                    result = true;
                }
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error writing file: {0}", ex);
                result = false;
            }

            return result;
        }
    }
}
