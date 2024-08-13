using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;


namespace uBlox_GPS.ubx
{
    partial class deCipher_ubx
    {
        public static void unpack(string ReceivedData, RichTextBox myRichTextBox)
        {
            string data = "";

            /*
             * myData string is as ascii string so take two characters from it for each byte.
             *
             * Byte 1 = Sync1
             * Byte 2 = Sync2
             * Byte 3 = Class
             * Byte 4 = ID
             * Byte 5 and 6 = Little endian length of payload e.g 0800 = 8
             * Byte 7 ..... Byte n = Payload
             * StringLength-2byte = Check Digit A   
             * StringLength-1byte = Check Digit B
             */

            // ToDo check checksum is correct and therefore data integrity is correct.

            List<int> list = GetPositions(ReceivedData, "B562"); //Find the start of each substring, "zero is start" 
            int numStrings = list.Count; // find how many substrings there are.

            for (int i = 0; i < numStrings; i++) //parse through the strings and get the info for each string.  
            {
                int length;

                if (i == numStrings - 1)
                {
                    length = ReceivedData.Length - list[i];
                }
                else
                {
                    length = list[i + 1] - list[i];
                }

                string myData = ReceivedData.Substring(list[i], length); //extract the substring from the string.

                string decipheredData = "Data received = " + myData + "\r";

                //sync chars
                decipheredData += myData.Substring(0, 2) + " = UBX Sync Character 1\r";
                decipheredData += myData.Substring(2, 2) + " = UBX Sync Character 2\r";

                // Class IDs, there are two of them
                data = myData.Substring(4, 2);
                decipheredData += data + " = " + GetUBXClassID(data) + "\r";

                data = myData.Substring(6, 2);
                decipheredData += data + " = " + GetUBXClassID(data) + "\r";

                //payload length
                data = myData.Substring(10, 2);
                data += myData.Substring(8, 2);
                decipheredData += "Length of payload = " + data + "\r";

                //Payload
                // ToDo work out the payload.
                decipheredData += "\rPayload = " + myData.Substring(12, myData.Length - 16) + "\r\r";

                //Checksum
                decipheredData += myData.Substring(myData.Length - 4, 2) + " = Check Digit A\r";
                decipheredData += myData.Substring(myData.Length - 2, 2) + " = Check Digit B\r";


                uBlox_GPS.frmTerminal.Log(LogMsgType.Incoming, decipheredData + "\r", myRichTextBox);
            }
        }

        public static List<int> GetPositions(string source, string searchString)
        {
            List<int> ret = new List<int>();
            int len = searchString.Length;
            int start = -len;
            while (true)
            {
                start = source.IndexOf(searchString, start + len);
                if (start == -1)
                {
                    break;
                }
                else
                {
                    ret.Add(start);
                }
            }
            return ret;
        }
    }
}
