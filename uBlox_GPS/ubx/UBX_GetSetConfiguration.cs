#region Namespace Inclusions
using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using CenteredMessagebox;
using uBlox_GPS.utils;

#endregion

namespace uBlox_GPS
{
    public partial class frmTerminal
    {

        private void btn_ubx_msg_config_go_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdobtn_ubx_set_msg_config.Checked)
                {
                    SetMsgConfig();
                }
                else if (rdobtn_ubx_get_msg_config.Checked)
                {
                    GetMsgConfig();
                }
                else
                {
                    MsgBox.Show("Make sure you have clicked either set or get configuration", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MsgBox.Show(exception.ToString(), "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void SetMsgConfig()
        {
            //  B562 0601 08 00F000000000000001 0024


        }

        /// <summary>
        /// We get the present Message configuration
        /// </summary>
        private void GetMsgConfig()
        {
            /*
                Data = B56206010200F0xxyyyy

                Where:
                B562 = sync chars
                0601 = CFG-MSG
                0200 = number of bytes in payload = 02 as little endian
                F0 = msgID = Poll a message configuration
                xx = msgID - Which one?
                yyyy = Checksum

                Which one found in the tag of the radiobutton:
                00 = GGA
                01 = GLL
                02 = GSA
                03 = GSV
                04 = RMC
                05 = VTG
                06 = 
                07 =
            */

            
           string QueryData = "B56206010200F0" + radiobuttonUtils.GetCheckedRadioButtonTag(grpbx_msgconfig_ID); //minus checksum
           QueryData += CheckSums.Create_Fletcher_checksum(QueryData); //add checksum

           SendData(QueryData, rchtxbx_ubx_output);

          // Log(LogMsgType.Outgoing, QueryData, rchtxbx_ubx_output);
        }

        
        
    }
}
