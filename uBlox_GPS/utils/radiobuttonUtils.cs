using System.Linq;
using System.Windows.Forms;

namespace uBlox_GPS.utils
{
    class radiobuttonUtils
    {
        /// <summary>
        /// Which radio button in a group box has been checked
        /// </summary>
        /// <param name="myGroupBox"></param>
        /// <returns>string in the radio buttons tag</returns>

        public static string GetCheckedRadioButtonTag(GroupBox myGroupBox)
        {
            var a = from RadioButton r in myGroupBox.Controls
                where r.Checked == true
                select r.Tag;

            return a.First().ToString();
        }


    }
}
