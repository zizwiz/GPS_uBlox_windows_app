using System;

namespace uBlox_GPS.utils
{
    class CheckSums
    {
        /// <summary>
        /// Use this to check if the checksum on the string is correct
        /// </summary>
        /// <param name="myData"></param>
        /// <returns>Hex string of the checksum</returns>
        public static string Check_nmea0183_checksum(string myData)
        {
            int crc = 0;
            string ans;
            string myData_crc = myData.Substring(myData.Length - 2, 2);


            // the first $ sign and the last two bytes of original CRC + the * sign
            for (int i = 1; i < myData.Length - 3; i++)
            {
                crc ^= myData[i]; //This will be in decimal
            }

            string CRC = crc.ToString("X");

            if (CRC.Length == 1) CRC = "0" + CRC;

            if (CRC == myData_crc)
            {
                ans = "Checksum = " + myData_crc + " is correct";
            }
            else
            {
                ans = "Checksum = " + myData_crc + " is not correct it should be = " + CRC;
            }

            return ans;
        }

        /// <summary>
        /// Send in the data including the prefix $ and this will return the complete string including the checksum
        /// </summary>
        /// <param name="myData"></param>
        /// <returns>Complete string including the checksum</returns>
        public static string Add_nmea0183_checksum(string myData)
        {
            int crc = 0;

            // the first $ sign and the last two bytes of original CRC + the * sign
            for (int i = 1; i < myData.Length; i++)
            {
                crc ^= myData[i]; //This will be in decimal
            }

            string CRC = crc.ToString("X");

            if (CRC.Length == 1) CRC = "0" + CRC;

            return myData + "*" + CRC; // this will add checksum in hexadecimal
        }



        /// <summary>
        /// Use this to check if the checksum on the string is correct
        /// </summary>
        /// <param name="myData"></param>
        /// <returns>Hex string of the checksum</returns>
        public static string Check_Fletcher_checksum(string myData)
        {
            ushort sum1 = 0;
            ushort sum2 = 0;

            string existing_checksum = myData.Substring(myData.Length - 4, 4);

            myData = myData.Substring(4, myData.Length - 8); //take off existing checksum and sync chars

            int NumberChars = myData.Length;
            byte[] data = new byte[NumberChars/2]; //create array of bytes

            for (int i = 0; i < NumberChars; i += 2) //put string in byte array
            {
                data[i/2] = Convert.ToByte(myData.Substring(i, 2), 16);
            }

            foreach (byte b in data) //calculate Fletchers checksum
            {
                sum1 = (ushort)((sum1 + b) % 256); 
                sum2 = (ushort)((sum2 + sum1) % 256);
            }

           string checksum = sum1.ToString("X2") + sum2.ToString("X2"); //add leading zero if req

            //Check the checksum and tell user if correct or not.
            if (existing_checksum == checksum)
            {
                return "Checksum = " + existing_checksum + " is correct";
            }

            return "Checksum = " + existing_checksum + " is incorrect should be = " + checksum;
        }

        public static UInt16 FletcherChecksum(byte[] bytes)
        {

            // Initialize One’s Complement Fletcher Checksum

            UInt16 checkSum = 0;



            // Loop through all data bytes, each stored at oneByte

            foreach (byte oneByte in bytes)

            {

                // Update lower checksum byte

                int tempL = checkSum & 0xff;

                tempL += oneByte;

                if ((tempL & 0x100) != 0)

                    tempL++;



                // Update higher checksum byte

                int tempH = checkSum >> 8;

                tempH += tempL & 0xff;

                if ((tempH & 0x100) != 0)

                    tempH++;



                checkSum = (UInt16)((tempL & 0xff) | (tempH & 0xff) << 8);

            }



            return checkSum;

        }
        /// <summary>
        /// Use this to check if the checksum on the string is correct
        /// </summary>
        /// <param name="myData"></param>
        /// <returns>Hex string of the checksum</returns>
        public static string Create_Fletcher_checksum(string myData)
        {
            ushort sum1 = 0;
            ushort sum2 = 0;

           myData = myData.Substring(4, myData.Length-4); //take off sync chars

            int NumberChars = myData.Length;
            byte[] data = new byte[NumberChars / 2]; //create array of bytes

            for (int i = 0; i < NumberChars; i += 2) //put string in byte array
            {
                data[i / 2] = Convert.ToByte(myData.Substring(i, 2), 16);
            }

            foreach (byte b in data) //calculate Fletchers checksum
            {
                sum1 = (ushort)((sum1 + b) % 256);
                sum2 = (ushort)((sum2 + sum1) % 256);
            }

           return sum1.ToString("X2") + sum2.ToString("X2");
        }



    }
}
