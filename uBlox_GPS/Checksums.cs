#region Namespace Inclusions
using System;
using System.Windows.Forms;
using uBlox_GPS.utils;

#endregion

namespace uBlox_GPS
{
    public partial class frmTerminal : Form
    {

       private void btn_check_nmea_Checksum_Click(object sender, EventArgs e)
        {
            rchtxtbx_checksum_output.AppendText(CheckSums.Check_nmea0183_checksum(txtbx_nmea_data_with_checksum.Text) + "\r");
        }

        private void btn_add_nmea_Checksum_Click(object sender, EventArgs e)
        {
            rchtxtbx_checksum_output.AppendText(CheckSums.Add_nmea0183_checksum(txtbx_nmea_data_without_checksum.Text) + "\r");
        }

        private void btn_check_ubx_Checksum_Click(object sender, EventArgs e)
        {
            rchtxtbx_checksum_output.AppendText(CheckSums.Check_Fletcher_checksum(txtbx_ubx_data_with_checksum.Text) + "\r");
        }
    }




}