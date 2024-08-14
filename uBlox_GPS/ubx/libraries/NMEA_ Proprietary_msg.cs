namespace uBlox_GPS.ubx
{
    partial class deCipher_ubx
    {
        // When configuring NMEA messages using the UBX protocol message CFG-MSG, the Class/Ids shown below
        // are used.
        private static string GetNMEAProprietaryMsgType(string myMsg)
        {
            // These are all 71xx where xx is shown below. Note some have two meanings depending on payload.

            string myAnswer = "NMEA Proprietary message of type ";

            switch (myMsg)
            {
                case "00":
                    myAnswer += "UBX,00 = Poll a PUBX,00 message or Lat/Long Position Data\r";
                    break;
                case "03":
                    myAnswer += "UBX,03 = Poll a PUBX,03 message or Satellite Status\r";
                    break;
                case "04":
                    myAnswer += "UBX,04 = Poll a PUBX,04 message or Time of Day and Clock Information\r";
                    break;
                case "05":
                    myAnswer += "UBX,05 = Poll a PUBX,05 message or Lat/Long Position Data\r";
                    break;
                case "06":
                    myAnswer += "UBX,06 = Poll a PUBX,06 message or Lat/Long Position Data\r";
                    break;
                case "40":
                    myAnswer += "UBX,40 = Set NMEA message output rate\r";
                    break;
                case "41":
                    myAnswer += "UBX,41 = Set Protocols and Baudrate\r";
                    break;
                default:
                    myAnswer += "?? = Undefined NMEA message\r";
                    break;
            }

            return myAnswer;
        }



    }
}