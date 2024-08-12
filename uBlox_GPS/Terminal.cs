#region Namespace Inclusions
using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading;
using System.IO;
using System.Reflection;
using System.Text;

#endregion

namespace uBlox_GPS
{
    public partial class frmTerminal : Form
    {

        #region Constructor
        public frmTerminal()
        {
            // Load user settings
            settings.Reload();

            // Build the form
            InitializeComponent();

            // Restore the users settings
            InitializeControlValues();

            // Enable/disable controls based on the current state
            EnableControls();


            // When data is received through the port, call this method
            comport.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            comport.PinChanged += new SerialPinChangedEventHandler(comport_PinChanged);
        }

        void comport_PinChanged(object sender, SerialPinChangedEventArgs e)
        {
            // Show the state of the pins
            UpdatePinState();
        }

        private void UpdatePinState()
        {
            this.Invoke(new ThreadStart(() =>
            {
                // Show the state of the pins
                chkCD.Checked = comport.CDHolding;
                chkCTS.Checked = comport.CtsHolding;
                chkDSR.Checked = comport.DsrHolding;


            }));
        }
        #endregion

        #region Local Methods

        /// <summary> Save the user's settings. </summary>
        private void SaveSettings()
        {
            settings.BaudRate = int.Parse(cmbBaudRate.Text);
            settings.DataBits = int.Parse(cmbDataBits.Text);
            settings.DataMode = CurrentDataMode;
            settings.Parity = (Parity)Enum.Parse(typeof(Parity), cmbParity.Text);
            settings.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cmbStopBits.Text);
            settings.PortName = cmbPortName.Text;
            settings.ClearOnOpen = chkClearOnOpen.Checked;
            settings.ClearWithDTR = chkClearWithDTR.Checked;

            settings.Save();
        }

        /// <summary> Populate the form's controls with default settings. </summary>
        private void InitializeControlValues()
        {
            cmbParity.Items.Clear(); cmbParity.Items.AddRange(Enum.GetNames(typeof(Parity)));
            cmbStopBits.Items.Clear(); cmbStopBits.Items.AddRange(Enum.GetNames(typeof(StopBits)));

            cmbParity.Text = settings.Parity.ToString();
            cmbStopBits.Text = settings.StopBits.ToString();
            cmbDataBits.Text = settings.DataBits.ToString();
            cmbParity.Text = settings.Parity.ToString();
            cmbBaudRate.Text = settings.BaudRate.ToString();
            CurrentDataMode = settings.DataMode;

            RefreshComPortList();

            chkClearOnOpen.Checked = settings.ClearOnOpen;
            chkClearWithDTR.Checked = settings.ClearWithDTR;

            // If it is still avalible, select the last com port used
            if (cmbPortName.Items.Contains(settings.PortName)) cmbPortName.Text = settings.PortName;
            else if (cmbPortName.Items.Count > 0) cmbPortName.SelectedIndex = cmbPortName.Items.Count - 1;
            else
            {
                MessageBox.Show(this, "There are no COM Ports detected on this computer.\nPlease install a COM Port and restart this app.", "No COM Ports Installed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        /// <summary> Enable/disable controls based on the app's current state. </summary>
        private void EnableControls()
        {
            // Enable/disable controls based on whether the port is open or not
            gbPortSettings.Enabled = !comport.IsOpen;
            txtbx_data_to_send.Enabled = btn_send.Enabled = comport.IsOpen;
            //chkDTR.Enabled = chkRTS.Enabled = comport.IsOpen;

            if (comport.IsOpen) btn_open_port.Text = "&Close Port";
            else btn_open_port.Text = "&Open Port";
        }

        private void frmTerminal_Load(object sender, EventArgs e)
        {
            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number
        }

        /// <summary>
        /// Sends data out RS232 port in either text or HexString.
        /// Data is logged to richtextbox which you define.
        /// </summary>
        /// <param name="myDataString"></param>
        /// <param name="myRichTextBox"></param>
        private void SendData(string myDataString, RichTextBox myRichTextBox)
        {
            if (CurrentDataMode == DataMode.Text)
            {
                // Send the user's text straight out the port
                comport.Write(myDataString);

                // Show in the terminal window the user's text
                Log(LogMsgType.Outgoing, myDataString + "\r", myRichTextBox);
            }
            else
            {
                try
                {
                    // Convert the user's string of hex digits (ex: B4 CA E2) to a byte array
                    byte[] data = HexStringToByteArray(myDataString);

                    // Send the binary data out the port
                    comport.Write(data, 0, data.Length);

                    // Show the hex digits on in the terminal window
                    Log(LogMsgType.Outgoing,  ByteArrayToHexString(data) + "\r", myRichTextBox);
                }
                catch (FormatException)
                {
                    // Inform the user if the hex string was not properly formatted
                    Log(LogMsgType.Error, "Not properly formatted hex string: " + myDataString + "\r", myRichTextBox);
                }
            }
        }



        #endregion


        #region Event Handlers


        private void frmTerminal_Shown(object sender, EventArgs e)
        {
            Log(LogMsgType.Normal, String.Format("Application Started at {0}\n", DateTime.Now), rchtxbx_output);
        }
        private void frmTerminal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // The form is closing, save the user's preferences
            SaveSettings();
        }

        private void rbText_CheckedChanged(object sender, EventArgs e)
        { if (rdobtn_text.Checked) CurrentDataMode = DataMode.Text; }

        private void rbHex_CheckedChanged(object sender, EventArgs e)
        { if (rdobtn_hex.Checked) CurrentDataMode = DataMode.Hex; }

        private void cmbBaudRate_Validating(object sender, CancelEventArgs e)
        { int x; e.Cancel = !int.TryParse(cmbBaudRate.Text, out x); }

        private void cmbDataBits_Validating(object sender, CancelEventArgs e)
        { int x; e.Cancel = !int.TryParse(cmbDataBits.Text, out x); }

        private void btn_open_port_Click(object sender, EventArgs e)
       {
            bool error = false;

            // If the port is open, close it.
            if (comport.IsOpen)
            {
                comport.Close();
                chkDTR.Checked = false; dtr_led.BackColor = System.Drawing.Color.Red;
                chkRTS.Checked = false; rts_led.BackColor = System.Drawing.Color.Red;
                chkCTS.Checked = false; cts_led.BackColor = System.Drawing.Color.Red;
                chkDSR.Checked = false; dsr_led.BackColor = System.Drawing.Color.Red;
                chkCD.Checked = false; cd_led.BackColor = System.Drawing.Color.Red;

            }
            else
            {
                // Set the port's settings
                comport.BaudRate = int.Parse(cmbBaudRate.Text);
                comport.DataBits = int.Parse(cmbDataBits.Text);
                comport.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cmbStopBits.Text);
                comport.Parity = (Parity)Enum.Parse(typeof(Parity), cmbParity.Text);
                comport.PortName = cmbPortName.Text;
                //UpdatePinState();





                try
                {
                    // Open the port
                    comport.Open();
                }
                catch (UnauthorizedAccessException) { error = true; }
                catch (IOException) { error = true; }
                catch (ArgumentException) { error = true; }

                if (error) MessageBox.Show(this, "Could not open the COM port.  Most likely it is already in use, has been removed, or is unavailable.", "COM Port Unavalible", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {
                    // Show the initial pin states
                    UpdatePinState();
                    chkDTR.Checked = comport.DtrEnable;
                    chkRTS.Checked = comport.RtsEnable;


                    if (chkDTR.Checked) { dtr_led.BackColor = System.Drawing.Color.Lime; } else { dtr_led.BackColor = System.Drawing.Color.Red; }
                    if (chkRTS.Checked) { rts_led.BackColor = System.Drawing.Color.Lime; } else { rts_led.BackColor = System.Drawing.Color.Red; }
                    if (comport.CtsHolding) { chkCTS.Checked = true; cts_led.BackColor = System.Drawing.Color.Lime; } else { chkCTS.Checked = false; cts_led.BackColor = System.Drawing.Color.Red; }
                    if (comport.DsrHolding) { chkDSR.Checked = true; dsr_led.BackColor = System.Drawing.Color.Lime; } else { chkDSR.Checked = false; dsr_led.BackColor = System.Drawing.Color.Red; }
                    if (comport.CDHolding) { chkCD.Checked = true; cd_led.BackColor = System.Drawing.Color.Lime; } else { chkCD.Checked = false; cd_led.BackColor = System.Drawing.Color.Red; }


                }
            }

            // Change the state of the form's controls
            EnableControls();

            // If the port is open, send focus to the send data box
            if (comport.IsOpen)
            {
                txtbx_data_to_send.Focus();
                if (chkClearOnOpen.Checked) ClearTerminal();
            }
        }

        private void txtSendData_KeyDown(object sender, KeyEventArgs e)
        {
            // If the user presses [ENTER], send the data now
            if (KeyHandled = e.KeyCode == Keys.Enter) { e.Handled = true; SendData(txtbx_data_to_send.Text, rchtxbx_output); }
        }

        private void txtSendData_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = KeyHandled;
        }

        #endregion



        private void ClearTerminal()
        {
            rchtxbx_output.Clear();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            SendData(txtbx_data_to_send.Text, rchtxbx_output);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearTerminal();
        }

        private void btn_convert_data_Click(object sender, EventArgs e)
        {
            rdobtn_hex.Checked = true;
            txtbx_data_to_send.Text = BitConverter.ToString(Encoding.UTF8.GetBytes(txtbx_convert_data.Text)).Replace("-","");

            if (chkbx_add_0A0D.Checked)
            {
                txtbx_data_to_send.Text += "0D0A";
            }
        }

        private void btn_stop_output_Click(object sender, EventArgs e)
        {

            string myData =
                "B56206010800F0000000000000010024B56206010200F000F911B56206010800F001000000000001012BB56206010200F001FA12B56206010800F0020000000000010232B56206010200F002FB13B56206010800F0030000000000010339B56206010200F003FC14B56206010800F0040000000000010440B56206010200F004FD15B56206010800F0050000000000010547B56206010200F005FE16";
            
            // Convert the user's string of hex digits (ex: B4 CA E2) to a byte array
            byte[] data = HexStringToByteArray(myData);

            // Send the binary data out the port
            comport.Write(data, 0, data.Length);

            // Show the hex digits on in the terminal window
            Log(LogMsgType.Outgoing, "\n" + ByteArrayToHexString(data) + "\n", rchtxbx_output);
        }

       
    }

}