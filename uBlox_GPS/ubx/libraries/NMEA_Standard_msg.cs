namespace uBlox_GPS.ubx
{
    partial class deCipher_ubx
    {
        // When configuring NMEA messages using the UBX protocol message CFG-MSG, the Class/Ids shown below
        // are used.
        private static string GetNMEAStandardMsgType(string myMsg)
        {
            // These are all 70xx where xx is shown below. Note some have two meanings depending on payload.

            string myAnswer = "NMEA standard message of type ";

            switch (myMsg)
            {
                case "00":
                    myAnswer += "GGA = Global positioning system fix data\r";
                    break;
                case "01":
                    myAnswer += "GLL = Latitude and longitude, with time of position fix and status";
                    break;
                case "02":
                    myAnswer += "GSA = GNSS DOP and Active Satellites\r";
                    break;
                case "03":
                    myAnswer += "GSV = GNSS Satellites in View\r";
                    break;
                case "04":
                    myAnswer += "RMC = Recommended Minimum data\r";
                    break;
                case "05":
                    myAnswer += "VTG = Course over ground and Ground speed\r";
                    break;
                case "06":
                    myAnswer += "GRS = GNSS Range Residuals\r";
                    break;
                case "07":
                    myAnswer += "GST = GNSS Pseudo Range Error Statistics\r";
                    break;
                case "08":
                    myAnswer += "ZDA = Time and Date\r";
                    break;
                case "09":
                    myAnswer += "GBS = GNSS Satellite Fault Detection\r";
                    break;
                case "0A":
                    myAnswer += "DTM = Datum Reference\r";
                    break;
                case "0B":
                    myAnswer += "GNS = Undefined NMEA message\r";
                    break;
                case "0C":
                    myAnswer += "THS = True Heading and Status\r";
                    break;
                case "0D":
                    myAnswer += "VLW = Undefined NMEA message\r";
                    break;
                case "0E":
                    myAnswer += "THS = True Heading and Status\r";
                    break;
                case "40":
                    myAnswer += "GPQ = Poll message\r";
                    break;
                case "41":
                    myAnswer += "TXT = Text Transmission\r";
                    break;
                default:
                    myAnswer += "?? = Undefined NMEA message\r";
                    break;
            }

            return myAnswer;
        }
    }
}