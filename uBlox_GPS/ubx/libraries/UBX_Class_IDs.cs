using System.Windows.Forms;

namespace uBlox_GPS.ubx
{
    partial class deCipher_ubx
    {

        private static string GetUBXClassID(string myData)
        {
            string myAnswer = "Class ID = ";

            switch (myData)
            {
                case "01":
                    // NAV = Navigation Results: Position, Speed, Time, Acc, Heading, DOP, SVs used
                    myAnswer += "NAV = Navigation Results: Position, Speed, Time, Acc, Heading, DOP, SVs used";
                    break;
                case "02":
                    // RXM = Receiver Manager Messages: Satellite Status, RTC Status
                    myAnswer += "RXM = Receiver Manager Messages: Satellite Status, RTC Status";
                    break;
                case "04":
                    // INF = Information Messages: Printf-Style Messages, with IDs such as Error, Warning, Notice
                    myAnswer += "INF = Information Messages: Printf-Style Messages, with IDs such as Error, Warning, Notice";
                    break;
                case "05":
                    // ACK = ACK/NAK Messages: as replies to CFG Input Messages
                    myAnswer += "ACK = ACK/NAK Messages: as replies to CFG Input Messages";
                    break;
                case "06":
                    // CFG = Configuration Input Messages: Set Dynamic Model, Set DOP Mask, Set Baud Rate, etc.
                    myAnswer += "CFG = Configuration Input Messages: Set Dynamic Model, Set DOP Mask, Set Baud Rate, etc.";
                    break;
                case "0A":
                    // MON = Monitoring Messages: Communication Status, CPU Load, Stack Usage, Task Status
                    myAnswer += "MON = Monitoring Messages: Communication Status, CPU Load, Stack Usage, Task Status";
                    break;
                case "0B":
                    // AID = AssistNow Aiding Messages: Ephemeris, Almanac, other A-GPS data input
                    myAnswer += "AID = AssistNow Aiding Messages: Ephemeris, Almanac, other A-GPS data input";
                    break;
                case "0D":
                    // TIM = Timing Messages: Timepulse Output, Timemark Results
                    myAnswer += "TIM = Timing Messages: Timepulse Output, Timemark Results";
                    break;
                case "10":
                    // ESF = External Sensor Fusion Messages: External sensor measurements and status information
                    myAnswer += "ESF = External Sensor Fusion Messages: External sensor measurements and status information";
                    break;
                default:
                    // All remaining class IDs are reserved.
                    myAnswer += "Not used as these class IDs are reserved";
                    break;

            }


            return myAnswer;
        }







    }

}