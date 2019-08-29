using System;
using System.Threading;

namespace BilgeAdam.Service
{
    public class BilgeAdam : Data.Interface.IBilgeAdam
    {
        public static DateTime SentDate = new DateTime();
        public void MyName(string name, DateTime myDate)
        {
            var diff = (myDate - SentDate).TotalMilliseconds;
            Console.WriteLine(diff + "" + myDate + " - " + name);

            new Thread(new ThreadStart(SendMessage)).Start();
        }

        public void SendMessage()
        {
            SentDate = DateTime.UtcNow;
            Program.channel.MyName("erçin", SentDate);
        }
    }
}