namespace uBlox_GPS.ubx
{
    partial class deCipher_ubx
    {
        private static string AckNakID(string myData, int myPayloadLength)
        {
            string myAnswer = "";

            if (myData.Substring(6, 2) == "01")
            {
                myAnswer += "MsgID = ACK = Msg Succeeded\r";
            }
            else if (myData.Substring(6, 2) == "00")
            {
                myAnswer += "MsgID = NAK = Msg Failed\r";
            }

            string payload = myData.Substring(12, myPayloadLength);





            return myAnswer;
        }



        //payload
    }
}