using System;
using System.IO;

namespace DeliveryCompany
{
    internal class BdConnect
    {
        //private static string bdCon = "Data Source=DESKTOP-9HDCF87;Initial Catalog=DeliveryDatabase;Integrated Security=True";
        private static string bdCon = Properties.Settings.Default.connectBD;
        public static string connect
        {
            get { return bdCon; }
            set { bdCon = value; }
        }
        public static void LogThis(string logMessage)
        {
            using (StreamWriter fstream = new StreamWriter("log.txt", true))
            {
                fstream.WriteLineAsync(FileDate() + " | " + logMessage);
                //закрыть для сохранения данных
                fstream.Close();
            }
        }

        static string FileDate()
        {
            return DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

    }
}
