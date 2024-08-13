namespace uBlox_GPS
{
  partial class frmTerminal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTerminal));
            this.rchtxbx_output = new System.Windows.Forms.RichTextBox();
            this.txtbx_data_to_send = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.rdobtn_hex = new System.Windows.Forms.RadioButton();
            this.rdobtn_text = new System.Windows.Forms.RadioButton();
            this.gbMode = new System.Windows.Forms.GroupBox();
            this.lblComPort = new System.Windows.Forms.Label();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.lblDataBits = new System.Windows.Forms.Label();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.lblStopBits = new System.Windows.Forms.Label();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.btn_open_port = new System.Windows.Forms.Button();
            this.gbPortSettings = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cd_led = new uBlox_GPS.RoundButton2();
            this.dsr_led = new uBlox_GPS.RoundButton2();
            this.cts_led = new uBlox_GPS.RoundButton2();
            this.rts_led = new uBlox_GPS.RoundButton2();
            this.dtr_led = new uBlox_GPS.RoundButton2();
            this.chkRTS = new System.Windows.Forms.CheckBox();
            this.chkCD = new System.Windows.Forms.CheckBox();
            this.chkDSR = new System.Windows.Forms.CheckBox();
            this.chkCTS = new System.Windows.Forms.CheckBox();
            this.chkDTR = new System.Windows.Forms.CheckBox();
            this.lbl_cd = new System.Windows.Forms.Label();
            this.lbl_dsr = new System.Windows.Forms.Label();
            this.lbl_cts = new System.Windows.Forms.Label();
            this.lbl_rts = new System.Windows.Forms.Label();
            this.lbl_dtr = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.chkClearOnOpen = new System.Windows.Forms.CheckBox();
            this.chkClearWithDTR = new System.Windows.Forms.CheckBox();
            this.tmrCheckComPorts = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gbclear = new System.Windows.Forms.GroupBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.grbx_send_data = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_connection = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tab_output = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_stop_output = new System.Windows.Forms.Button();
            this.chkbx_ascii = new System.Windows.Forms.CheckBox();
            this.grpbx_convert_data = new System.Windows.Forms.GroupBox();
            this.chkbx_add_0A0D = new System.Windows.Forms.CheckBox();
            this.btn_convert_data = new System.Windows.Forms.Button();
            this.txtbx_convert_data = new System.Windows.Forms.TextBox();
            this.tab_checksums = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rchtxtbx_checksum_output = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_check_ubx_Checksum = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbx_ubx_data_with_checksum = new System.Windows.Forms.TextBox();
            this.grpbx_nmea = new System.Windows.Forms.GroupBox();
            this.btn_check_nmea_Checksum = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbx_nmea_data_with_checksum = new System.Windows.Forms.TextBox();
            this.btn_add_nmea_Checksum = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_nmea_data_without_checksum = new System.Windows.Forms.TextBox();
            this.btn_convertToDecimal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbobx_nmea_strings = new System.Windows.Forms.ComboBox();
            this.tab_ubx = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rchtxbx_ubx_output = new System.Windows.Forms.RichTextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.grpbx_ubx_msg_config = new System.Windows.Forms.GroupBox();
            this.lbl_ubx_rate_second = new System.Windows.Forms.Label();
            this.txtbx_ubx_rate = new System.Windows.Forms.TextBox();
            this.lbl_ubx_rate = new System.Windows.Forms.Label();
            this.btn_ubx_msg_config_go = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdobtn_ubx_set_msg_config = new System.Windows.Forms.RadioButton();
            this.rdobtn_ubx_get_msg_config = new System.Windows.Forms.RadioButton();
            this.grpbx_msgconfig_ID = new System.Windows.Forms.GroupBox();
            this.rdobtn_ubx_VLW_config = new System.Windows.Forms.RadioButton();
            this.rdobtn_ubx_THS_config = new System.Windows.Forms.RadioButton();
            this.rdobtn_ubx_GNS_config = new System.Windows.Forms.RadioButton();
            this.rdobtn_ubx_DTM_config = new System.Windows.Forms.RadioButton();
            this.rdobtn_ubx_GBS_config = new System.Windows.Forms.RadioButton();
            this.rdobtn_ubx_ZDA_config = new System.Windows.Forms.RadioButton();
            this.rdobtn_ubx_GST_config = new System.Windows.Forms.RadioButton();
            this.rdobtn_ubx_VTG_config = new System.Windows.Forms.RadioButton();
            this.rdobtn_ubx_GLL_config = new System.Windows.Forms.RadioButton();
            this.rdobtn_ubx_GSA_config = new System.Windows.Forms.RadioButton();
            this.rdobtn_ubx_GSV_config = new System.Windows.Forms.RadioButton();
            this.rdobtn_ubx_RMC_config = new System.Windows.Forms.RadioButton();
            this.rdobtn_ubx_GRS_config = new System.Windows.Forms.RadioButton();
            this.rdobtn_ubx_GGA_config = new System.Windows.Forms.RadioButton();
            this.cmbobx_ubx_commands = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gbMode.SuspendLayout();
            this.gbPortSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbclear.SuspendLayout();
            this.grbx_send_data.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_connection.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tab_output.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpbx_convert_data.SuspendLayout();
            this.tab_checksums.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.grpbx_nmea.SuspendLayout();
            this.tab_ubx.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.grpbx_ubx_msg_config.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpbx_msgconfig_ID.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rchtxbx_output
            // 
            this.rchtxbx_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rchtxbx_output.BackColor = System.Drawing.Color.Black;
            this.rchtxbx_output.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rchtxbx_output.Location = new System.Drawing.Point(589, 5);
            this.rchtxbx_output.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rchtxbx_output.Name = "rchtxbx_output";
            this.rchtxbx_output.Size = new System.Drawing.Size(800, 537);
            this.rchtxbx_output.TabIndex = 0;
            this.rchtxbx_output.Text = "";
            // 
            // txtbx_data_to_send
            // 
            this.txtbx_data_to_send.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbx_data_to_send.Location = new System.Drawing.Point(12, 54);
            this.txtbx_data_to_send.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_data_to_send.Name = "txtbx_data_to_send";
            this.txtbx_data_to_send.Size = new System.Drawing.Size(379, 26);
            this.txtbx_data_to_send.TabIndex = 2;
            this.txtbx_data_to_send.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSendData_KeyDown);
            this.txtbx_data_to_send.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSendData_KeyPress);
            // 
            // btn_send
            // 
            this.btn_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_send.Location = new System.Drawing.Point(415, 45);
            this.btn_send.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(112, 35);
            this.btn_send.TabIndex = 3;
            this.btn_send.Text = "Send";
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // cmbPortName
            // 
            this.cmbPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6"});
            this.cmbPortName.Location = new System.Drawing.Point(20, 54);
            this.cmbPortName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(98, 28);
            this.cmbPortName.TabIndex = 1;
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmbBaudRate.Location = new System.Drawing.Point(129, 54);
            this.cmbBaudRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(102, 28);
            this.cmbBaudRate.TabIndex = 3;
            this.cmbBaudRate.Validating += new System.ComponentModel.CancelEventHandler(this.cmbBaudRate_Validating);
            // 
            // rdobtn_hex
            // 
            this.rdobtn_hex.AutoSize = true;
            this.rdobtn_hex.Checked = true;
            this.rdobtn_hex.Location = new System.Drawing.Point(18, 60);
            this.rdobtn_hex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdobtn_hex.Name = "rdobtn_hex";
            this.rdobtn_hex.Size = new System.Drawing.Size(62, 24);
            this.rdobtn_hex.TabIndex = 1;
            this.rdobtn_hex.TabStop = true;
            this.rdobtn_hex.Text = "Hex";
            this.rdobtn_hex.CheckedChanged += new System.EventHandler(this.rbHex_CheckedChanged);
            // 
            // rdobtn_text
            // 
            this.rdobtn_text.AutoSize = true;
            this.rdobtn_text.Location = new System.Drawing.Point(18, 29);
            this.rdobtn_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdobtn_text.Name = "rdobtn_text";
            this.rdobtn_text.Size = new System.Drawing.Size(64, 24);
            this.rdobtn_text.TabIndex = 0;
            this.rdobtn_text.Text = "Text";
            this.rdobtn_text.CheckedChanged += new System.EventHandler(this.rbText_CheckedChanged);
            // 
            // gbMode
            // 
            this.gbMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbMode.Controls.Add(this.rdobtn_text);
            this.gbMode.Controls.Add(this.rdobtn_hex);
            this.gbMode.Location = new System.Drawing.Point(257, 429);
            this.gbMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbMode.Name = "gbMode";
            this.gbMode.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbMode.Size = new System.Drawing.Size(134, 98);
            this.gbMode.TabIndex = 5;
            this.gbMode.TabStop = false;
            this.gbMode.Text = "Data &Mode";
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Location = new System.Drawing.Point(18, 29);
            this.lblComPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(82, 20);
            this.lblComPort.TabIndex = 0;
            this.lblComPort.Text = "COM Port:";
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(128, 29);
            this.lblBaudRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(90, 20);
            this.lblBaudRate.TabIndex = 2;
            this.lblBaudRate.Text = "Baud Rate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Parity:";
            // 
            // cmbParity
            // 
            this.cmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.cmbParity.Location = new System.Drawing.Point(242, 54);
            this.cmbParity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(88, 28);
            this.cmbParity.TabIndex = 5;
            // 
            // lblDataBits
            // 
            this.lblDataBits.AutoSize = true;
            this.lblDataBits.Location = new System.Drawing.Point(344, 29);
            this.lblDataBits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(79, 20);
            this.lblDataBits.TabIndex = 6;
            this.lblDataBits.Text = "Data Bits:";
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.cmbDataBits.Location = new System.Drawing.Point(340, 54);
            this.cmbDataBits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(88, 28);
            this.cmbDataBits.TabIndex = 7;
            this.cmbDataBits.Validating += new System.ComponentModel.CancelEventHandler(this.cmbDataBits_Validating);
            // 
            // lblStopBits
            // 
            this.lblStopBits.AutoSize = true;
            this.lblStopBits.Location = new System.Drawing.Point(442, 29);
            this.lblStopBits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStopBits.Name = "lblStopBits";
            this.lblStopBits.Size = new System.Drawing.Size(78, 20);
            this.lblStopBits.TabIndex = 8;
            this.lblStopBits.Text = "Stop Bits:";
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStopBits.FormattingEnabled = true;
            this.cmbStopBits.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbStopBits.Location = new System.Drawing.Point(440, 54);
            this.cmbStopBits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(96, 28);
            this.cmbStopBits.TabIndex = 9;
            // 
            // btn_open_port
            // 
            this.btn_open_port.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_open_port.Location = new System.Drawing.Point(1140, 319);
            this.btn_open_port.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_open_port.Name = "btn_open_port";
            this.btn_open_port.Size = new System.Drawing.Size(112, 35);
            this.btn_open_port.TabIndex = 6;
            this.btn_open_port.Text = "&Open Port";
            this.btn_open_port.Click += new System.EventHandler(this.btn_open_port_Click);
            // 
            // gbPortSettings
            // 
            this.gbPortSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbPortSettings.Controls.Add(this.cmbPortName);
            this.gbPortSettings.Controls.Add(this.cmbBaudRate);
            this.gbPortSettings.Controls.Add(this.cmbStopBits);
            this.gbPortSettings.Controls.Add(this.cmbParity);
            this.gbPortSettings.Controls.Add(this.cmbDataBits);
            this.gbPortSettings.Controls.Add(this.lblComPort);
            this.gbPortSettings.Controls.Add(this.lblStopBits);
            this.gbPortSettings.Controls.Add(this.lblBaudRate);
            this.gbPortSettings.Controls.Add(this.lblDataBits);
            this.gbPortSettings.Controls.Add(this.label1);
            this.gbPortSettings.Location = new System.Drawing.Point(43, 167);
            this.gbPortSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbPortSettings.Name = "gbPortSettings";
            this.gbPortSettings.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbPortSettings.Size = new System.Drawing.Size(555, 98);
            this.gbPortSettings.TabIndex = 4;
            this.gbPortSettings.TabStop = false;
            this.gbPortSettings.Text = "COM Serial Port Settings";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.cd_led);
            this.groupBox1.Controls.Add(this.dsr_led);
            this.groupBox1.Controls.Add(this.cts_led);
            this.groupBox1.Controls.Add(this.rts_led);
            this.groupBox1.Controls.Add(this.dtr_led);
            this.groupBox1.Controls.Add(this.chkRTS);
            this.groupBox1.Controls.Add(this.chkCD);
            this.groupBox1.Controls.Add(this.chkDSR);
            this.groupBox1.Controls.Add(this.chkCTS);
            this.groupBox1.Controls.Add(this.chkDTR);
            this.groupBox1.Location = new System.Drawing.Point(628, 362);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(408, 120);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "&Line Signals";
            // 
            // cd_led
            // 
            this.cd_led.BackColor = System.Drawing.Color.Red;
            this.cd_led.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cd_led.Location = new System.Drawing.Point(344, 62);
            this.cd_led.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cd_led.Name = "cd_led";
            this.cd_led.Size = new System.Drawing.Size(38, 38);
            this.cd_led.TabIndex = 14;
            this.cd_led.UseVisualStyleBackColor = false;
            // 
            // dsr_led
            // 
            this.dsr_led.BackColor = System.Drawing.Color.Red;
            this.dsr_led.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dsr_led.Location = new System.Drawing.Point(266, 62);
            this.dsr_led.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dsr_led.Name = "dsr_led";
            this.dsr_led.Size = new System.Drawing.Size(38, 38);
            this.dsr_led.TabIndex = 13;
            this.dsr_led.UseVisualStyleBackColor = false;
            // 
            // cts_led
            // 
            this.cts_led.BackColor = System.Drawing.Color.Red;
            this.cts_led.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cts_led.Location = new System.Drawing.Point(188, 62);
            this.cts_led.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cts_led.Name = "cts_led";
            this.cts_led.Size = new System.Drawing.Size(38, 38);
            this.cts_led.TabIndex = 12;
            this.cts_led.UseVisualStyleBackColor = false;
            // 
            // rts_led
            // 
            this.rts_led.BackColor = System.Drawing.Color.Red;
            this.rts_led.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rts_led.Location = new System.Drawing.Point(112, 62);
            this.rts_led.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rts_led.Name = "rts_led";
            this.rts_led.Size = new System.Drawing.Size(38, 38);
            this.rts_led.TabIndex = 11;
            this.rts_led.UseVisualStyleBackColor = false;
            // 
            // dtr_led
            // 
            this.dtr_led.BackColor = System.Drawing.Color.Red;
            this.dtr_led.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dtr_led.Location = new System.Drawing.Point(21, 62);
            this.dtr_led.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtr_led.Name = "dtr_led";
            this.dtr_led.Size = new System.Drawing.Size(38, 38);
            this.dtr_led.TabIndex = 10;
            this.dtr_led.UseVisualStyleBackColor = false;
            // 
            // chkRTS
            // 
            this.chkRTS.AutoSize = true;
            this.chkRTS.Location = new System.Drawing.Point(98, 31);
            this.chkRTS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkRTS.Name = "chkRTS";
            this.chkRTS.Size = new System.Drawing.Size(67, 24);
            this.chkRTS.TabIndex = 1;
            this.chkRTS.Text = "RTS";
            this.toolTip.SetToolTip(this.chkRTS, "Pin 7 on DB9, Output, Request to Send");
            this.chkRTS.UseVisualStyleBackColor = true;
            this.chkRTS.CheckedChanged += new System.EventHandler(this.chkRTS_CheckedChanged);
            // 
            // chkCD
            // 
            this.chkCD.AutoSize = true;
            this.chkCD.Enabled = false;
            this.chkCD.Location = new System.Drawing.Point(339, 31);
            this.chkCD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkCD.Name = "chkCD";
            this.chkCD.Size = new System.Drawing.Size(58, 24);
            this.chkCD.TabIndex = 4;
            this.chkCD.Text = "CD";
            this.toolTip.SetToolTip(this.chkCD, "Pin 1 on DB9, Input, Data Carrier Detect");
            this.chkCD.UseVisualStyleBackColor = true;
            // 
            // chkDSR
            // 
            this.chkDSR.AutoSize = true;
            this.chkDSR.Enabled = false;
            this.chkDSR.Location = new System.Drawing.Point(258, 31);
            this.chkDSR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkDSR.Name = "chkDSR";
            this.chkDSR.Size = new System.Drawing.Size(70, 24);
            this.chkDSR.TabIndex = 3;
            this.chkDSR.Text = "DSR";
            this.toolTip.SetToolTip(this.chkDSR, "Pin 6 on DB9, Input, Data Set Ready");
            this.chkDSR.UseVisualStyleBackColor = true;
            // 
            // chkCTS
            // 
            this.chkCTS.AutoSize = true;
            this.chkCTS.Enabled = false;
            this.chkCTS.Location = new System.Drawing.Point(178, 31);
            this.chkCTS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkCTS.Name = "chkCTS";
            this.chkCTS.Size = new System.Drawing.Size(66, 24);
            this.chkCTS.TabIndex = 2;
            this.chkCTS.Text = "CTS";
            this.toolTip.SetToolTip(this.chkCTS, "Pin 8 on DB9, Input, Clear to Send");
            this.chkCTS.UseVisualStyleBackColor = true;
            // 
            // chkDTR
            // 
            this.chkDTR.AutoSize = true;
            this.chkDTR.Location = new System.Drawing.Point(15, 31);
            this.chkDTR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkDTR.Name = "chkDTR";
            this.chkDTR.Size = new System.Drawing.Size(68, 24);
            this.chkDTR.TabIndex = 0;
            this.chkDTR.Text = "DTR";
            this.toolTip.SetToolTip(this.chkDTR, "Pin 4 on DB9, Output, Data Terminal Ready");
            this.chkDTR.UseVisualStyleBackColor = true;
            this.chkDTR.CheckedChanged += new System.EventHandler(this.chkDTR_CheckedChanged);
            // 
            // lbl_cd
            // 
            this.lbl_cd.AutoSize = true;
            this.lbl_cd.Location = new System.Drawing.Point(258, 102);
            this.lbl_cd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cd.Name = "lbl_cd";
            this.lbl_cd.Size = new System.Drawing.Size(32, 20);
            this.lbl_cd.TabIndex = 9;
            this.lbl_cd.Text = "CD";
            // 
            // lbl_dsr
            // 
            this.lbl_dsr.AutoSize = true;
            this.lbl_dsr.Location = new System.Drawing.Point(180, 102);
            this.lbl_dsr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dsr.Name = "lbl_dsr";
            this.lbl_dsr.Size = new System.Drawing.Size(44, 20);
            this.lbl_dsr.TabIndex = 8;
            this.lbl_dsr.Text = "DSR";
            // 
            // lbl_cts
            // 
            this.lbl_cts.AutoSize = true;
            this.lbl_cts.Location = new System.Drawing.Point(120, 102);
            this.lbl_cts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cts.Name = "lbl_cts";
            this.lbl_cts.Size = new System.Drawing.Size(40, 20);
            this.lbl_cts.TabIndex = 7;
            this.lbl_cts.Text = "CTS";
            // 
            // lbl_rts
            // 
            this.lbl_rts.AutoSize = true;
            this.lbl_rts.Location = new System.Drawing.Point(64, 102);
            this.lbl_rts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_rts.Name = "lbl_rts";
            this.lbl_rts.Size = new System.Drawing.Size(41, 20);
            this.lbl_rts.TabIndex = 6;
            this.lbl_rts.Text = "RTS";
            // 
            // lbl_dtr
            // 
            this.lbl_dtr.AutoSize = true;
            this.lbl_dtr.Location = new System.Drawing.Point(10, 102);
            this.lbl_dtr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dtr.Name = "lbl_dtr";
            this.lbl_dtr.Size = new System.Drawing.Size(42, 20);
            this.lbl_dtr.TabIndex = 5;
            this.lbl_dtr.Text = "DTR";
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clear.Location = new System.Drawing.Point(445, 507);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(112, 35);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "&Clear";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // chkClearOnOpen
            // 
            this.chkClearOnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkClearOnOpen.AutoSize = true;
            this.chkClearOnOpen.Location = new System.Drawing.Point(9, 31);
            this.chkClearOnOpen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkClearOnOpen.Name = "chkClearOnOpen";
            this.chkClearOnOpen.Size = new System.Drawing.Size(137, 24);
            this.chkClearOnOpen.TabIndex = 10;
            this.chkClearOnOpen.Text = "Clear on Open";
            this.chkClearOnOpen.UseVisualStyleBackColor = true;
            // 
            // chkClearWithDTR
            // 
            this.chkClearWithDTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkClearWithDTR.AutoSize = true;
            this.chkClearWithDTR.Location = new System.Drawing.Point(9, 64);
            this.chkClearWithDTR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkClearWithDTR.Name = "chkClearWithDTR";
            this.chkClearWithDTR.Size = new System.Drawing.Size(141, 24);
            this.chkClearWithDTR.TabIndex = 11;
            this.chkClearWithDTR.Text = "Clear with DTR";
            this.chkClearWithDTR.UseVisualStyleBackColor = true;
            // 
            // tmrCheckComPorts
            // 
            this.tmrCheckComPorts.Enabled = true;
            this.tmrCheckComPorts.Interval = 500;
            this.tmrCheckComPorts.Tick += new System.EventHandler(this.tmrCheckComPorts_Tick);
            // 
            // gbclear
            // 
            this.gbclear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbclear.Controls.Add(this.chkClearOnOpen);
            this.gbclear.Controls.Add(this.chkClearWithDTR);
            this.gbclear.Location = new System.Drawing.Point(43, 439);
            this.gbclear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbclear.Name = "gbclear";
            this.gbclear.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbclear.Size = new System.Drawing.Size(171, 98);
            this.gbclear.TabIndex = 12;
            this.gbclear.TabStop = false;
            this.gbclear.Text = "Clear Mode";
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_close.Location = new System.Drawing.Point(1349, 5);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(112, 44);
            this.btn_close.TabIndex = 13;
            this.btn_close.Text = "C&lose";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // grbx_send_data
            // 
            this.grbx_send_data.Controls.Add(this.btn_send);
            this.grbx_send_data.Controls.Add(this.lbl_cd);
            this.grbx_send_data.Controls.Add(this.txtbx_data_to_send);
            this.grbx_send_data.Controls.Add(this.lbl_dsr);
            this.grbx_send_data.Controls.Add(this.lbl_dtr);
            this.grbx_send_data.Controls.Add(this.lbl_cts);
            this.grbx_send_data.Controls.Add(this.lbl_rts);
            this.grbx_send_data.Location = new System.Drawing.Point(13, 35);
            this.grbx_send_data.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbx_send_data.Name = "grbx_send_data";
            this.grbx_send_data.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbx_send_data.Size = new System.Drawing.Size(553, 151);
            this.grbx_send_data.TabIndex = 14;
            this.grbx_send_data.TabStop = false;
            this.grbx_send_data.Text = "Send Data";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_connection);
            this.tabControl1.Controls.Add(this.tab_output);
            this.tabControl1.Controls.Add(this.tab_checksums);
            this.tabControl1.Controls.Add(this.tab_ubx);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1470, 621);
            this.tabControl1.TabIndex = 15;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tab_connection
            // 
            this.tab_connection.Controls.Add(this.panel1);
            this.tab_connection.Location = new System.Drawing.Point(4, 29);
            this.tab_connection.Name = "tab_connection";
            this.tab_connection.Padding = new System.Windows.Forms.Padding(3);
            this.tab_connection.Size = new System.Drawing.Size(1399, 588);
            this.tab_connection.TabIndex = 0;
            this.tab_connection.Text = "Connection";
            this.tab_connection.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbPortSettings);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btn_open_port);
            this.panel1.Controls.Add(this.gbclear);
            this.panel1.Controls.Add(this.gbMode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1393, 582);
            this.panel1.TabIndex = 0;
            // 
            // tab_output
            // 
            this.tab_output.Controls.Add(this.panel2);
            this.tab_output.Location = new System.Drawing.Point(4, 29);
            this.tab_output.Name = "tab_output";
            this.tab_output.Padding = new System.Windows.Forms.Padding(3);
            this.tab_output.Size = new System.Drawing.Size(1399, 588);
            this.tab_output.TabIndex = 1;
            this.tab_output.Text = "Output";
            this.tab_output.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_stop_output);
            this.panel2.Controls.Add(this.chkbx_ascii);
            this.panel2.Controls.Add(this.grpbx_convert_data);
            this.panel2.Controls.Add(this.grbx_send_data);
            this.panel2.Controls.Add(this.rchtxbx_output);
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1393, 582);
            this.panel2.TabIndex = 0;
            // 
            // btn_stop_output
            // 
            this.btn_stop_output.Location = new System.Drawing.Point(53, 448);
            this.btn_stop_output.Name = "btn_stop_output";
            this.btn_stop_output.Size = new System.Drawing.Size(144, 44);
            this.btn_stop_output.TabIndex = 19;
            this.btn_stop_output.Text = "Stop Output";
            this.btn_stop_output.UseVisualStyleBackColor = true;
            this.btn_stop_output.Click += new System.EventHandler(this.btn_stop_output_Click);
            // 
            // chkbx_ascii
            // 
            this.chkbx_ascii.AutoSize = true;
            this.chkbx_ascii.Location = new System.Drawing.Point(42, 375);
            this.chkbx_ascii.Name = "chkbx_ascii";
            this.chkbx_ascii.Size = new System.Drawing.Size(130, 24);
            this.chkbx_ascii.TabIndex = 18;
            this.chkbx_ascii.Text = "Log as ASCII";
            this.chkbx_ascii.UseVisualStyleBackColor = true;
            // 
            // grpbx_convert_data
            // 
            this.grpbx_convert_data.Controls.Add(this.chkbx_add_0A0D);
            this.grpbx_convert_data.Controls.Add(this.btn_convert_data);
            this.grpbx_convert_data.Controls.Add(this.txtbx_convert_data);
            this.grpbx_convert_data.Location = new System.Drawing.Point(17, 216);
            this.grpbx_convert_data.Name = "grpbx_convert_data";
            this.grpbx_convert_data.Size = new System.Drawing.Size(548, 131);
            this.grpbx_convert_data.TabIndex = 17;
            this.grpbx_convert_data.TabStop = false;
            this.grpbx_convert_data.Text = "Convert Data";
            // 
            // chkbx_add_0A0D
            // 
            this.chkbx_add_0A0D.AutoSize = true;
            this.chkbx_add_0A0D.Location = new System.Drawing.Point(10, 78);
            this.chkbx_add_0A0D.Name = "chkbx_add_0A0D";
            this.chkbx_add_0A0D.Size = new System.Drawing.Size(109, 24);
            this.chkbx_add_0A0D.TabIndex = 19;
            this.chkbx_add_0A0D.Text = "Add 0A0D";
            this.chkbx_add_0A0D.UseVisualStyleBackColor = true;
            // 
            // btn_convert_data
            // 
            this.btn_convert_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_convert_data.Location = new System.Drawing.Point(397, 23);
            this.btn_convert_data.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_convert_data.Name = "btn_convert_data";
            this.btn_convert_data.Size = new System.Drawing.Size(112, 35);
            this.btn_convert_data.TabIndex = 16;
            this.btn_convert_data.Text = "Convert";
            this.btn_convert_data.Click += new System.EventHandler(this.btn_convert_data_Click);
            // 
            // txtbx_convert_data
            // 
            this.txtbx_convert_data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbx_convert_data.Location = new System.Drawing.Point(10, 27);
            this.txtbx_convert_data.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_convert_data.Name = "txtbx_convert_data";
            this.txtbx_convert_data.Size = new System.Drawing.Size(379, 26);
            this.txtbx_convert_data.TabIndex = 15;
            // 
            // tab_checksums
            // 
            this.tab_checksums.Controls.Add(this.tableLayoutPanel3);
            this.tab_checksums.Location = new System.Drawing.Point(4, 29);
            this.tab_checksums.Name = "tab_checksums";
            this.tab_checksums.Padding = new System.Windows.Forms.Padding(3);
            this.tab_checksums.Size = new System.Drawing.Size(1399, 588);
            this.tab_checksums.TabIndex = 2;
            this.tab_checksums.Text = "Checksums";
            this.tab_checksums.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1393, 582);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rchtxtbx_checksum_output);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(690, 576);
            this.panel4.TabIndex = 0;
            // 
            // rchtxtbx_checksum_output
            // 
            this.rchtxtbx_checksum_output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchtxtbx_checksum_output.Location = new System.Drawing.Point(0, 0);
            this.rchtxtbx_checksum_output.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rchtxtbx_checksum_output.Name = "rchtxtbx_checksum_output";
            this.rchtxtbx_checksum_output.ReadOnly = true;
            this.rchtxtbx_checksum_output.Size = new System.Drawing.Size(690, 576);
            this.rchtxtbx_checksum_output.TabIndex = 1;
            this.rchtxtbx_checksum_output.Text = "";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_check_ubx_Checksum);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txtbx_ubx_data_with_checksum);
            this.panel5.Controls.Add(this.grpbx_nmea);
            this.panel5.Controls.Add(this.btn_convertToDecimal);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.cmbobx_nmea_strings);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(699, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(691, 576);
            this.panel5.TabIndex = 1;
            // 
            // btn_check_ubx_Checksum
            // 
            this.btn_check_ubx_Checksum.Location = new System.Drawing.Point(499, 362);
            this.btn_check_ubx_Checksum.Name = "btn_check_ubx_Checksum";
            this.btn_check_ubx_Checksum.Size = new System.Drawing.Size(104, 54);
            this.btn_check_ubx_Checksum.TabIndex = 20;
            this.btn_check_ubx_Checksum.Text = "Check UBX Checksum";
            this.btn_check_ubx_Checksum.UseVisualStyleBackColor = true;
            this.btn_check_ubx_Checksum.Click += new System.EventHandler(this.btn_check_ubx_Checksum_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Data including checksum";
            // 
            // txtbx_ubx_data_with_checksum
            // 
            this.txtbx_ubx_data_with_checksum.Location = new System.Drawing.Point(246, 373);
            this.txtbx_ubx_data_with_checksum.Name = "txtbx_ubx_data_with_checksum";
            this.txtbx_ubx_data_with_checksum.Size = new System.Drawing.Size(247, 26);
            this.txtbx_ubx_data_with_checksum.TabIndex = 18;
            // 
            // grpbx_nmea
            // 
            this.grpbx_nmea.Controls.Add(this.btn_check_nmea_Checksum);
            this.grpbx_nmea.Controls.Add(this.label4);
            this.grpbx_nmea.Controls.Add(this.txtbx_nmea_data_with_checksum);
            this.grpbx_nmea.Controls.Add(this.btn_add_nmea_Checksum);
            this.grpbx_nmea.Controls.Add(this.label2);
            this.grpbx_nmea.Controls.Add(this.txtbx_nmea_data_without_checksum);
            this.grpbx_nmea.Location = new System.Drawing.Point(28, 136);
            this.grpbx_nmea.Name = "grpbx_nmea";
            this.grpbx_nmea.Size = new System.Drawing.Size(603, 171);
            this.grpbx_nmea.TabIndex = 17;
            this.grpbx_nmea.TabStop = false;
            this.grpbx_nmea.Text = "NMEA Checksums";
            // 
            // btn_check_nmea_Checksum
            // 
            this.btn_check_nmea_Checksum.Location = new System.Drawing.Point(471, 17);
            this.btn_check_nmea_Checksum.Name = "btn_check_nmea_Checksum";
            this.btn_check_nmea_Checksum.Size = new System.Drawing.Size(126, 54);
            this.btn_check_nmea_Checksum.TabIndex = 15;
            this.btn_check_nmea_Checksum.Text = "Check NMEA Checksum";
            this.btn_check_nmea_Checksum.UseVisualStyleBackColor = true;
            this.btn_check_nmea_Checksum.Click += new System.EventHandler(this.btn_check_nmea_Checksum_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Data including checksum";
            // 
            // txtbx_nmea_data_with_checksum
            // 
            this.txtbx_nmea_data_with_checksum.Location = new System.Drawing.Point(218, 28);
            this.txtbx_nmea_data_with_checksum.Name = "txtbx_nmea_data_with_checksum";
            this.txtbx_nmea_data_with_checksum.Size = new System.Drawing.Size(247, 26);
            this.txtbx_nmea_data_with_checksum.TabIndex = 13;
            // 
            // btn_add_nmea_Checksum
            // 
            this.btn_add_nmea_Checksum.Location = new System.Drawing.Point(471, 95);
            this.btn_add_nmea_Checksum.Name = "btn_add_nmea_Checksum";
            this.btn_add_nmea_Checksum.Size = new System.Drawing.Size(104, 54);
            this.btn_add_nmea_Checksum.TabIndex = 11;
            this.btn_add_nmea_Checksum.Text = "Add NMEA Checksum";
            this.btn_add_nmea_Checksum.UseVisualStyleBackColor = true;
            this.btn_add_nmea_Checksum.Click += new System.EventHandler(this.btn_add_nmea_Checksum_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data minus checksum";
            // 
            // txtbx_nmea_data_without_checksum
            // 
            this.txtbx_nmea_data_without_checksum.Location = new System.Drawing.Point(218, 106);
            this.txtbx_nmea_data_without_checksum.Name = "txtbx_nmea_data_without_checksum";
            this.txtbx_nmea_data_without_checksum.Size = new System.Drawing.Size(247, 26);
            this.txtbx_nmea_data_without_checksum.TabIndex = 0;
            // 
            // btn_convertToDecimal
            // 
            this.btn_convertToDecimal.Location = new System.Drawing.Point(354, 73);
            this.btn_convertToDecimal.Name = "btn_convertToDecimal";
            this.btn_convertToDecimal.Size = new System.Drawing.Size(100, 39);
            this.btn_convertToDecimal.TabIndex = 16;
            this.btn_convertToDecimal.Text = "button1";
            this.btn_convertToDecimal.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "NMEA Input Messages";
            // 
            // cmbobx_nmea_strings
            // 
            this.cmbobx_nmea_strings.FormattingEnabled = true;
            this.cmbobx_nmea_strings.Location = new System.Drawing.Point(234, 23);
            this.cmbobx_nmea_strings.Name = "cmbobx_nmea_strings";
            this.cmbobx_nmea_strings.Size = new System.Drawing.Size(308, 28);
            this.cmbobx_nmea_strings.TabIndex = 2;
            // 
            // tab_ubx
            // 
            this.tab_ubx.Controls.Add(this.tableLayoutPanel4);
            this.tab_ubx.Location = new System.Drawing.Point(4, 29);
            this.tab_ubx.Name = "tab_ubx";
            this.tab_ubx.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ubx.Size = new System.Drawing.Size(1462, 588);
            this.tab_ubx.TabIndex = 3;
            this.tab_ubx.Text = "UBX Comms";
            this.tab_ubx.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1456, 550);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rchtxbx_ubx_output);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(585, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(868, 544);
            this.panel3.TabIndex = 0;
            // 
            // rchtxbx_ubx_output
            // 
            this.rchtxbx_ubx_output.BackColor = System.Drawing.Color.Black;
            this.rchtxbx_ubx_output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchtxbx_ubx_output.Location = new System.Drawing.Point(0, 0);
            this.rchtxbx_ubx_output.Name = "rchtxbx_ubx_output";
            this.rchtxbx_ubx_output.Size = new System.Drawing.Size(868, 544);
            this.rchtxbx_ubx_output.TabIndex = 0;
            this.rchtxbx_ubx_output.Text = "";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.grpbx_ubx_msg_config);
            this.panel6.Controls.Add(this.cmbobx_ubx_commands);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(576, 544);
            this.panel6.TabIndex = 1;
            // 
            // grpbx_ubx_msg_config
            // 
            this.grpbx_ubx_msg_config.Controls.Add(this.lbl_ubx_rate_second);
            this.grpbx_ubx_msg_config.Controls.Add(this.txtbx_ubx_rate);
            this.grpbx_ubx_msg_config.Controls.Add(this.lbl_ubx_rate);
            this.grpbx_ubx_msg_config.Controls.Add(this.btn_ubx_msg_config_go);
            this.grpbx_ubx_msg_config.Controls.Add(this.groupBox3);
            this.grpbx_ubx_msg_config.Controls.Add(this.grpbx_msgconfig_ID);
            this.grpbx_ubx_msg_config.Location = new System.Drawing.Point(3, 72);
            this.grpbx_ubx_msg_config.Name = "grpbx_ubx_msg_config";
            this.grpbx_ubx_msg_config.Size = new System.Drawing.Size(606, 332);
            this.grpbx_ubx_msg_config.TabIndex = 0;
            this.grpbx_ubx_msg_config.TabStop = false;
            this.grpbx_ubx_msg_config.Text = "Message Configuration";
            // 
            // lbl_ubx_rate_second
            // 
            this.lbl_ubx_rate_second.AutoSize = true;
            this.lbl_ubx_rate_second.Location = new System.Drawing.Point(102, 257);
            this.lbl_ubx_rate_second.Name = "lbl_ubx_rate_second";
            this.lbl_ubx_rate_second.Size = new System.Drawing.Size(17, 20);
            this.lbl_ubx_rate_second.TabIndex = 11;
            this.lbl_ubx_rate_second.Text = "s";
            // 
            // txtbx_ubx_rate
            // 
            this.txtbx_ubx_rate.Location = new System.Drawing.Point(56, 254);
            this.txtbx_ubx_rate.Name = "txtbx_ubx_rate";
            this.txtbx_ubx_rate.Size = new System.Drawing.Size(40, 26);
            this.txtbx_ubx_rate.TabIndex = 10;
            this.txtbx_ubx_rate.Text = "1";
            // 
            // lbl_ubx_rate
            // 
            this.lbl_ubx_rate.AutoSize = true;
            this.lbl_ubx_rate.Location = new System.Drawing.Point(6, 257);
            this.lbl_ubx_rate.Name = "lbl_ubx_rate";
            this.lbl_ubx_rate.Size = new System.Drawing.Size(44, 20);
            this.lbl_ubx_rate.TabIndex = 9;
            this.lbl_ubx_rate.Text = "Rate";
            // 
            // btn_ubx_msg_config_go
            // 
            this.btn_ubx_msg_config_go.Location = new System.Drawing.Point(359, 274);
            this.btn_ubx_msg_config_go.Name = "btn_ubx_msg_config_go";
            this.btn_ubx_msg_config_go.Size = new System.Drawing.Size(122, 43);
            this.btn_ubx_msg_config_go.TabIndex = 8;
            this.btn_ubx_msg_config_go.Text = "Go";
            this.btn_ubx_msg_config_go.UseVisualStyleBackColor = true;
            this.btn_ubx_msg_config_go.Click += new System.EventHandler(this.btn_ubx_msg_config_go_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdobtn_ubx_set_msg_config);
            this.groupBox3.Controls.Add(this.rdobtn_ubx_get_msg_config);
            this.groupBox3.Location = new System.Drawing.Point(6, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(366, 67);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // rdobtn_ubx_set_msg_config
            // 
            this.rdobtn_ubx_set_msg_config.AutoSize = true;
            this.rdobtn_ubx_set_msg_config.Location = new System.Drawing.Point(185, 27);
            this.rdobtn_ubx_set_msg_config.Name = "rdobtn_ubx_set_msg_config";
            this.rdobtn_ubx_set_msg_config.Size = new System.Drawing.Size(158, 24);
            this.rdobtn_ubx_set_msg_config.TabIndex = 1;
            this.rdobtn_ubx_set_msg_config.Text = "Set Configuration";
            this.rdobtn_ubx_set_msg_config.UseVisualStyleBackColor = true;
            // 
            // rdobtn_ubx_get_msg_config
            // 
            this.rdobtn_ubx_get_msg_config.AutoSize = true;
            this.rdobtn_ubx_get_msg_config.Checked = true;
            this.rdobtn_ubx_get_msg_config.Location = new System.Drawing.Point(19, 27);
            this.rdobtn_ubx_get_msg_config.Name = "rdobtn_ubx_get_msg_config";
            this.rdobtn_ubx_get_msg_config.Size = new System.Drawing.Size(160, 24);
            this.rdobtn_ubx_get_msg_config.TabIndex = 0;
            this.rdobtn_ubx_get_msg_config.TabStop = true;
            this.rdobtn_ubx_get_msg_config.Text = "Get Configuration";
            this.rdobtn_ubx_get_msg_config.UseVisualStyleBackColor = true;
            // 
            // grpbx_msgconfig_ID
            // 
            this.grpbx_msgconfig_ID.Controls.Add(this.rdobtn_ubx_VLW_config);
            this.grpbx_msgconfig_ID.Controls.Add(this.rdobtn_ubx_THS_config);
            this.grpbx_msgconfig_ID.Controls.Add(this.rdobtn_ubx_GNS_config);
            this.grpbx_msgconfig_ID.Controls.Add(this.rdobtn_ubx_DTM_config);
            this.grpbx_msgconfig_ID.Controls.Add(this.rdobtn_ubx_GBS_config);
            this.grpbx_msgconfig_ID.Controls.Add(this.rdobtn_ubx_ZDA_config);
            this.grpbx_msgconfig_ID.Controls.Add(this.rdobtn_ubx_GST_config);
            this.grpbx_msgconfig_ID.Controls.Add(this.rdobtn_ubx_VTG_config);
            this.grpbx_msgconfig_ID.Controls.Add(this.rdobtn_ubx_GLL_config);
            this.grpbx_msgconfig_ID.Controls.Add(this.rdobtn_ubx_GSA_config);
            this.grpbx_msgconfig_ID.Controls.Add(this.rdobtn_ubx_GSV_config);
            this.grpbx_msgconfig_ID.Controls.Add(this.rdobtn_ubx_RMC_config);
            this.grpbx_msgconfig_ID.Controls.Add(this.rdobtn_ubx_GRS_config);
            this.grpbx_msgconfig_ID.Controls.Add(this.rdobtn_ubx_GGA_config);
            this.grpbx_msgconfig_ID.Location = new System.Drawing.Point(6, 126);
            this.grpbx_msgconfig_ID.Name = "grpbx_msgconfig_ID";
            this.grpbx_msgconfig_ID.Size = new System.Drawing.Size(559, 103);
            this.grpbx_msgconfig_ID.TabIndex = 6;
            this.grpbx_msgconfig_ID.TabStop = false;
            // 
            // rdobtn_ubx_VLW_config
            // 
            this.rdobtn_ubx_VLW_config.AutoSize = true;
            this.rdobtn_ubx_VLW_config.Location = new System.Drawing.Point(472, 57);
            this.rdobtn_ubx_VLW_config.Name = "rdobtn_ubx_VLW_config";
            this.rdobtn_ubx_VLW_config.Size = new System.Drawing.Size(69, 24);
            this.rdobtn_ubx_VLW_config.TabIndex = 13;
            this.rdobtn_ubx_VLW_config.Tag = "0F";
            this.rdobtn_ubx_VLW_config.Text = "VLW";
            this.rdobtn_ubx_VLW_config.UseVisualStyleBackColor = true;
            // 
            // rdobtn_ubx_THS_config
            // 
            this.rdobtn_ubx_THS_config.AutoSize = true;
            this.rdobtn_ubx_THS_config.Location = new System.Drawing.Point(403, 57);
            this.rdobtn_ubx_THS_config.Name = "rdobtn_ubx_THS_config";
            this.rdobtn_ubx_THS_config.Size = new System.Drawing.Size(66, 24);
            this.rdobtn_ubx_THS_config.TabIndex = 12;
            this.rdobtn_ubx_THS_config.Tag = "0E";
            this.rdobtn_ubx_THS_config.Text = "THS";
            this.rdobtn_ubx_THS_config.UseVisualStyleBackColor = true;
            // 
            // rdobtn_ubx_GNS_config
            // 
            this.rdobtn_ubx_GNS_config.AutoSize = true;
            this.rdobtn_ubx_GNS_config.Location = new System.Drawing.Point(327, 57);
            this.rdobtn_ubx_GNS_config.Name = "rdobtn_ubx_GNS_config";
            this.rdobtn_ubx_GNS_config.Size = new System.Drawing.Size(69, 24);
            this.rdobtn_ubx_GNS_config.TabIndex = 11;
            this.rdobtn_ubx_GNS_config.Tag = "0D";
            this.rdobtn_ubx_GNS_config.Text = "GNS";
            this.rdobtn_ubx_GNS_config.UseVisualStyleBackColor = true;
            // 
            // rdobtn_ubx_DTM_config
            // 
            this.rdobtn_ubx_DTM_config.AutoSize = true;
            this.rdobtn_ubx_DTM_config.Location = new System.Drawing.Point(250, 57);
            this.rdobtn_ubx_DTM_config.Name = "rdobtn_ubx_DTM_config";
            this.rdobtn_ubx_DTM_config.Size = new System.Drawing.Size(68, 24);
            this.rdobtn_ubx_DTM_config.TabIndex = 10;
            this.rdobtn_ubx_DTM_config.Tag = "0A";
            this.rdobtn_ubx_DTM_config.Text = "DTM";
            this.rdobtn_ubx_DTM_config.UseVisualStyleBackColor = true;
            // 
            // rdobtn_ubx_GBS_config
            // 
            this.rdobtn_ubx_GBS_config.AutoSize = true;
            this.rdobtn_ubx_GBS_config.Location = new System.Drawing.Point(173, 57);
            this.rdobtn_ubx_GBS_config.Name = "rdobtn_ubx_GBS_config";
            this.rdobtn_ubx_GBS_config.Size = new System.Drawing.Size(69, 24);
            this.rdobtn_ubx_GBS_config.TabIndex = 9;
            this.rdobtn_ubx_GBS_config.Tag = "09";
            this.rdobtn_ubx_GBS_config.Text = "GBS";
            this.rdobtn_ubx_GBS_config.UseVisualStyleBackColor = true;
            // 
            // rdobtn_ubx_ZDA_config
            // 
            this.rdobtn_ubx_ZDA_config.AutoSize = true;
            this.rdobtn_ubx_ZDA_config.Location = new System.Drawing.Point(95, 57);
            this.rdobtn_ubx_ZDA_config.Name = "rdobtn_ubx_ZDA_config";
            this.rdobtn_ubx_ZDA_config.Size = new System.Drawing.Size(67, 24);
            this.rdobtn_ubx_ZDA_config.TabIndex = 8;
            this.rdobtn_ubx_ZDA_config.Tag = "08";
            this.rdobtn_ubx_ZDA_config.Text = "ZDA";
            this.rdobtn_ubx_ZDA_config.UseVisualStyleBackColor = true;
            // 
            // rdobtn_ubx_GST_config
            // 
            this.rdobtn_ubx_GST_config.AutoSize = true;
            this.rdobtn_ubx_GST_config.Location = new System.Drawing.Point(19, 57);
            this.rdobtn_ubx_GST_config.Name = "rdobtn_ubx_GST_config";
            this.rdobtn_ubx_GST_config.Size = new System.Drawing.Size(67, 24);
            this.rdobtn_ubx_GST_config.TabIndex = 7;
            this.rdobtn_ubx_GST_config.Tag = "07";
            this.rdobtn_ubx_GST_config.Text = "GST";
            this.rdobtn_ubx_GST_config.UseVisualStyleBackColor = true;
            // 
            // rdobtn_ubx_VTG_config
            // 
            this.rdobtn_ubx_VTG_config.AutoSize = true;
            this.rdobtn_ubx_VTG_config.Location = new System.Drawing.Point(403, 27);
            this.rdobtn_ubx_VTG_config.Name = "rdobtn_ubx_VTG_config";
            this.rdobtn_ubx_VTG_config.Size = new System.Drawing.Size(67, 24);
            this.rdobtn_ubx_VTG_config.TabIndex = 6;
            this.rdobtn_ubx_VTG_config.Tag = "05";
            this.rdobtn_ubx_VTG_config.Text = "VTG";
            this.rdobtn_ubx_VTG_config.UseVisualStyleBackColor = true;
            // 
            // rdobtn_ubx_GLL_config
            // 
            this.rdobtn_ubx_GLL_config.AutoSize = true;
            this.rdobtn_ubx_GLL_config.Location = new System.Drawing.Point(96, 27);
            this.rdobtn_ubx_GLL_config.Name = "rdobtn_ubx_GLL_config";
            this.rdobtn_ubx_GLL_config.Size = new System.Drawing.Size(65, 24);
            this.rdobtn_ubx_GLL_config.TabIndex = 5;
            this.rdobtn_ubx_GLL_config.Tag = "01";
            this.rdobtn_ubx_GLL_config.Text = "GLL";
            this.rdobtn_ubx_GLL_config.UseVisualStyleBackColor = true;
            // 
            // rdobtn_ubx_GSA_config
            // 
            this.rdobtn_ubx_GSA_config.AutoSize = true;
            this.rdobtn_ubx_GSA_config.Location = new System.Drawing.Point(173, 27);
            this.rdobtn_ubx_GSA_config.Name = "rdobtn_ubx_GSA_config";
            this.rdobtn_ubx_GSA_config.Size = new System.Drawing.Size(69, 24);
            this.rdobtn_ubx_GSA_config.TabIndex = 4;
            this.rdobtn_ubx_GSA_config.Tag = "02";
            this.rdobtn_ubx_GSA_config.Text = "GSA";
            this.rdobtn_ubx_GSA_config.UseVisualStyleBackColor = true;
            // 
            // rdobtn_ubx_GSV_config
            // 
            this.rdobtn_ubx_GSV_config.AutoSize = true;
            this.rdobtn_ubx_GSV_config.Location = new System.Drawing.Point(250, 27);
            this.rdobtn_ubx_GSV_config.Name = "rdobtn_ubx_GSV_config";
            this.rdobtn_ubx_GSV_config.Size = new System.Drawing.Size(69, 24);
            this.rdobtn_ubx_GSV_config.TabIndex = 3;
            this.rdobtn_ubx_GSV_config.Tag = "03";
            this.rdobtn_ubx_GSV_config.Text = "GSV";
            this.rdobtn_ubx_GSV_config.UseVisualStyleBackColor = true;
            // 
            // rdobtn_ubx_RMC_config
            // 
            this.rdobtn_ubx_RMC_config.AutoSize = true;
            this.rdobtn_ubx_RMC_config.Location = new System.Drawing.Point(327, 27);
            this.rdobtn_ubx_RMC_config.Name = "rdobtn_ubx_RMC_config";
            this.rdobtn_ubx_RMC_config.Size = new System.Drawing.Size(70, 24);
            this.rdobtn_ubx_RMC_config.TabIndex = 2;
            this.rdobtn_ubx_RMC_config.Tag = "04";
            this.rdobtn_ubx_RMC_config.Text = "RMC";
            this.rdobtn_ubx_RMC_config.UseVisualStyleBackColor = true;
            // 
            // rdobtn_ubx_GRS_config
            // 
            this.rdobtn_ubx_GRS_config.AutoSize = true;
            this.rdobtn_ubx_GRS_config.Location = new System.Drawing.Point(472, 27);
            this.rdobtn_ubx_GRS_config.Name = "rdobtn_ubx_GRS_config";
            this.rdobtn_ubx_GRS_config.Size = new System.Drawing.Size(70, 24);
            this.rdobtn_ubx_GRS_config.TabIndex = 1;
            this.rdobtn_ubx_GRS_config.Tag = "06";
            this.rdobtn_ubx_GRS_config.Text = "GRS";
            this.rdobtn_ubx_GRS_config.UseVisualStyleBackColor = true;
            // 
            // rdobtn_ubx_GGA_config
            // 
            this.rdobtn_ubx_GGA_config.AutoSize = true;
            this.rdobtn_ubx_GGA_config.Checked = true;
            this.rdobtn_ubx_GGA_config.Location = new System.Drawing.Point(19, 27);
            this.rdobtn_ubx_GGA_config.Name = "rdobtn_ubx_GGA_config";
            this.rdobtn_ubx_GGA_config.Size = new System.Drawing.Size(71, 24);
            this.rdobtn_ubx_GGA_config.TabIndex = 0;
            this.rdobtn_ubx_GGA_config.TabStop = true;
            this.rdobtn_ubx_GGA_config.Tag = "00";
            this.rdobtn_ubx_GGA_config.Text = "GGA";
            this.rdobtn_ubx_GGA_config.UseVisualStyleBackColor = true;
            // 
            // cmbobx_ubx_commands
            // 
            this.cmbobx_ubx_commands.FormattingEnabled = true;
            this.cmbobx_ubx_commands.Items.AddRange(new object[] {
            "Message Configuration"});
            this.cmbobx_ubx_commands.Location = new System.Drawing.Point(28, 23);
            this.cmbobx_ubx_commands.Name = "cmbobx_ubx_commands";
            this.cmbobx_ubx_commands.Size = new System.Drawing.Size(362, 28);
            this.cmbobx_ubx_commands.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1476, 687);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.Controls.Add(this.btn_close, 7, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 630);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1470, 54);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // frmTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 687);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(746, 354);
            this.Name = "frmTerminal";
            this.Text = "Comms Terminal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTerminal_FormClosing);
            this.Load += new System.EventHandler(this.frmTerminal_Load);
            this.Shown += new System.EventHandler(this.frmTerminal_Shown);
            this.gbMode.ResumeLayout(false);
            this.gbMode.PerformLayout();
            this.gbPortSettings.ResumeLayout(false);
            this.gbPortSettings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbclear.ResumeLayout(false);
            this.gbclear.PerformLayout();
            this.grbx_send_data.ResumeLayout(false);
            this.grbx_send_data.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_connection.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tab_output.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grpbx_convert_data.ResumeLayout(false);
            this.grpbx_convert_data.PerformLayout();
            this.tab_checksums.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.grpbx_nmea.ResumeLayout(false);
            this.grpbx_nmea.PerformLayout();
            this.tab_ubx.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.grpbx_ubx_msg_config.ResumeLayout(false);
            this.grpbx_ubx_msg_config.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpbx_msgconfig_ID.ResumeLayout(false);
            this.grpbx_msgconfig_ID.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.RichTextBox rchtxbx_output;
    private System.Windows.Forms.TextBox txtbx_data_to_send;
    private System.Windows.Forms.Button btn_send;
    private System.Windows.Forms.ComboBox cmbPortName;
    private System.Windows.Forms.ComboBox cmbBaudRate;
    private System.Windows.Forms.RadioButton rdobtn_hex;
    private System.Windows.Forms.RadioButton rdobtn_text;
    private System.Windows.Forms.GroupBox gbMode;
    private System.Windows.Forms.Label lblComPort;
    private System.Windows.Forms.Label lblBaudRate;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cmbParity;
    private System.Windows.Forms.Label lblDataBits;
    private System.Windows.Forms.ComboBox cmbDataBits;
    private System.Windows.Forms.Label lblStopBits;
    private System.Windows.Forms.ComboBox cmbStopBits;
    private System.Windows.Forms.Button btn_open_port;
    private System.Windows.Forms.GroupBox gbPortSettings;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox chkCD;
		private System.Windows.Forms.CheckBox chkDSR;
		private System.Windows.Forms.CheckBox chkCTS;
		private System.Windows.Forms.CheckBox chkDTR;
		private System.Windows.Forms.CheckBox chkRTS;
		private System.Windows.Forms.Button btn_clear;
		private System.Windows.Forms.CheckBox chkClearOnOpen;
		private System.Windows.Forms.CheckBox chkClearWithDTR;
		private System.Windows.Forms.Timer tmrCheckComPorts;
		private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox gbclear;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_cd;
        private System.Windows.Forms.Label lbl_dsr;
        private System.Windows.Forms.Label lbl_cts;
        private System.Windows.Forms.Label lbl_rts;
        private System.Windows.Forms.Label lbl_dtr;
        private System.Windows.Forms.GroupBox grbx_send_data;
        
        private RoundButton2 dtr_led;
        private RoundButton2 cd_led;
        private RoundButton2 dsr_led;
        private RoundButton2 cts_led;
        private RoundButton2 rts_led;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_connection;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tab_output;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox grpbx_convert_data;
        private System.Windows.Forms.Button btn_convert_data;
        private System.Windows.Forms.TextBox txtbx_convert_data;
        private System.Windows.Forms.CheckBox chkbx_ascii;
        private System.Windows.Forms.CheckBox chkbx_add_0A0D;
        private System.Windows.Forms.TabPage tab_checksums;
        private System.Windows.Forms.TabPage tab_ubx;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox rchtxtbx_checksum_output;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox grpbx_nmea;
        private System.Windows.Forms.Button btn_check_nmea_Checksum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbx_nmea_data_with_checksum;
        private System.Windows.Forms.Button btn_add_nmea_Checksum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_nmea_data_without_checksum;
        private System.Windows.Forms.Button btn_convertToDecimal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbobx_nmea_strings;
        private System.Windows.Forms.Button btn_check_ubx_Checksum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbx_ubx_data_with_checksum;
        private System.Windows.Forms.Button btn_stop_output;
        private System.Windows.Forms.ComboBox cmbobx_ubx_commands;
        private System.Windows.Forms.GroupBox grpbx_ubx_msg_config;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdobtn_ubx_set_msg_config;
        private System.Windows.Forms.RadioButton rdobtn_ubx_get_msg_config;
        private System.Windows.Forms.GroupBox grpbx_msgconfig_ID;
        private System.Windows.Forms.RadioButton rdobtn_ubx_GLL_config;
        private System.Windows.Forms.RadioButton rdobtn_ubx_GSA_config;
        private System.Windows.Forms.RadioButton rdobtn_ubx_GSV_config;
        private System.Windows.Forms.RadioButton rdobtn_ubx_RMC_config;
        private System.Windows.Forms.RadioButton rdobtn_ubx_GRS_config;
        private System.Windows.Forms.RadioButton rdobtn_ubx_GGA_config;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox rchtxbx_ubx_output;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_ubx_rate_second;
        private System.Windows.Forms.TextBox txtbx_ubx_rate;
        private System.Windows.Forms.Label lbl_ubx_rate;
        private System.Windows.Forms.Button btn_ubx_msg_config_go;
        private System.Windows.Forms.RadioButton rdobtn_ubx_VTG_config;
        private System.Windows.Forms.RadioButton rdobtn_ubx_VLW_config;
        private System.Windows.Forms.RadioButton rdobtn_ubx_THS_config;
        private System.Windows.Forms.RadioButton rdobtn_ubx_GNS_config;
        private System.Windows.Forms.RadioButton rdobtn_ubx_DTM_config;
        private System.Windows.Forms.RadioButton rdobtn_ubx_GBS_config;
        private System.Windows.Forms.RadioButton rdobtn_ubx_ZDA_config;
        private System.Windows.Forms.RadioButton rdobtn_ubx_GST_config;
    }
}

