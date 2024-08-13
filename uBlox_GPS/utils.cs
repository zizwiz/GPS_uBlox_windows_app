#region Namespace Inclusions
using System;
using System.Text;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

using uBlox_GPS.Properties;
#endregion

namespace uBlox_GPS
{

    public enum DataMode { Text, Hex };

    public enum LogMsgType { Incoming, Outgoing, Normal, Warning, Error, Data };

    public enum OutputTo {General, UBX, NMEA};

    public partial class frmTerminal : Form
    {
 
        // The main control for communicating through the RS-232 port
        private SerialPort comport = new SerialPort();

        // Various colors for logging info
        public static Color[] LogMsgTypeColor = { Color.Yellow, Color.LightGreen, Color.White, Color.Orange, Color.Red, Color.Purple };

        // Temp holder for whether a key was pressed
        private bool KeyHandled = false;

        private Settings settings = Settings.Default;

        /// <summary> Log data to the terminal window. </summary>
        /// <param name="msgtype"> The type of message to be written. </param>
        /// <param name="msg"> The string containing the message to be shown. </param>
        public static void Log(LogMsgType msgtype, string msg, RichTextBox myRichTextBox)
        {
            myRichTextBox.Invoke(new EventHandler(delegate
            {
                myRichTextBox.SelectedText = string.Empty;
                myRichTextBox.SelectionFont = new Font(myRichTextBox.SelectionFont, FontStyle.Bold);
                myRichTextBox.SelectionColor = LogMsgTypeColor[(int)msgtype];
                myRichTextBox.AppendText(msg);
                myRichTextBox.ScrollToCaret();
            }));
        }

        /// <summary> Convert a string of hex digits (ex: E4 CA B2) to a byte array. </summary>
        /// <param name="s"> The string containing the hex digits (with or without spaces). </param>
        /// <returns> Returns an array of bytes. </returns>
        private byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
        }

        /// <summary> Converts an array of bytes into a formatted string of hex digits (ex: E4 CA B2)</summary>
        /// <param name="data"> The array of bytes to be translated into a string of hex digits. </param>
        /// <returns> Returns a well formatted string of hex digits with spacing. </returns>
        private string ByteArrayToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0').PadRight(3, ' '));
            return sb.ToString().ToUpper();
        }

        private DataMode CurrentDataMode
        {
            get
            {
                if (rdobtn_hex.Checked)
                {
                    return DataMode.Hex;
                }
                else
                {
                    return DataMode.Text;
                }
            }
            
            set
            {
                if (value == DataMode.Text)
                {
                    rdobtn_text.Checked = true;
                }
                else
                {
                    rdobtn_hex.Checked = true;
                }
            }
        }

    }
}