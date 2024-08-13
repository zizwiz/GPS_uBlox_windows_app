#region Namespace Inclusions
using System;
using System.Linq;
using System.IO.Ports;
using System.Windows.Forms;
using System.Collections.Generic;
using uBlox_GPS.ubx;

#endregion

namespace uBlox_GPS
{
    public partial class frmTerminal : Form
    {

        private void tmrCheckComPorts_Tick(object sender, EventArgs e)
        {
            // checks to see if COM ports have been added or removed
            // since it is quite common now with USB-to-Serial adapters
            RefreshComPortList();
        }

        private void RefreshComPortList()
        {
            // Determain if the list of com port names has changed since last checked
            string selected = RefreshComPortList(cmbPortName.Items.Cast<string>(), cmbPortName.SelectedItem as string, comport.IsOpen);

            // If there was an update, then update the control showing the user the list of port names
            if (!String.IsNullOrEmpty(selected))
            {
                cmbPortName.Items.Clear();
                cmbPortName.Items.AddRange(OrderedPortNames());
                cmbPortName.SelectedItem = selected;
            }
        }

        private string[] OrderedPortNames()
        {
            // Just a placeholder for a successful parsing of a string to an integer
            int num;

            // Order the serial port names in numberic order (if possible)
            return SerialPort.GetPortNames().OrderBy(a => a.Length > 3 && int.TryParse(a.Substring(3), out num) ? num : 0).ToArray();
        }

        private string RefreshComPortList(IEnumerable<string> PreviousPortNames, string CurrentSelection, bool PortOpen)
        {
            // Create a new return report to populate
            string selected = null;

            // Retrieve the list of ports currently mounted by the operating system (sorted by name)
            string[] ports = SerialPort.GetPortNames();

            // First determain if there was a change (any additions or removals)
            bool updated = PreviousPortNames.Except(ports).Count() > 0 || ports.Except(PreviousPortNames).Count() > 0;

            // If there was a change, then select an appropriate default port
            if (updated)
            {
                // Use the correctly ordered set of port names
                ports = OrderedPortNames();

                // Find newest port if one or more were added
                string newest = SerialPort.GetPortNames().Except(PreviousPortNames).OrderBy(a => a).LastOrDefault();

                // If the port was already open... (see logic notes and reasoning in Notes.txt)
                if (PortOpen)
                {
                    if (ports.Contains(CurrentSelection)) selected = CurrentSelection;
                    else if (!String.IsNullOrEmpty(newest)) selected = newest;
                    else selected = ports.LastOrDefault();
                }
                else
                {
                    if (!String.IsNullOrEmpty(newest)) selected = newest;
                    else if (ports.Contains(CurrentSelection)) selected = CurrentSelection;
                    else selected = ports.LastOrDefault();
                }
            }

            // If there was a change to the port list, return the recommended default selection
            return selected;
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // If the com port has been closed, do nothing
            if (!comport.IsOpen) return;

            // This method will be called when there is data waiting in the port's buffer

            // Determine which mode (string or binary) the user is in
            if (CurrentDataMode == DataMode.Text)
            {
                // Read all the data waiting in the buffer
                string data = comport.ReadExisting();

                // Display the text to the user in the terminal
                Log(LogMsgType.Incoming, data, rchtxbx_output);
            }
            else
            {
                // Obtain the number of bytes waiting in the port's buffer
                int bytes = comport.BytesToRead;

                // Create a byte array buffer to hold the incoming data
                byte[] buffer = new byte[bytes];

                // Read the data from the port and store it in our buffer
                comport.Read(buffer, 0, bytes);

                // Show the user the incoming data in hex format

                // Log(LogMsgType.Incoming, ByteArrayToHexString(buffer));

                if (chkbx_ascii.Checked)
                {
                    Log(LogMsgType.Incoming, System.Text.Encoding.Default.GetString(buffer), rchtxbx_output);
                }
                else
                {
                    string myReply = ByteArrayToHexString(buffer);

                    if (myReply.Substring(0, 5) == "B5 62") //ubx config reply - note space in string
                    {
                        deCipher_ubx.unpack(myReply.Replace(" ",""), rchtxbx_ubx_output);
                    }
                    else
                    {
                         Log(LogMsgType.Incoming, ByteArrayToHexString(buffer), rchtxbx_output);
                    }
                }

            }

        }

        private void chkDTR_CheckedChanged(object sender, EventArgs e)
        {
            comport.DtrEnable = chkDTR.Checked;
            if (chkDTR.Checked && chkClearWithDTR.Checked) ClearTerminal();
        }

        private void chkRTS_CheckedChanged(object sender, EventArgs e)
        {
            comport.RtsEnable = chkRTS.Checked;
        }
    }
}