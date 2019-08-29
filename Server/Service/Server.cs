using System;
using System.Threading;

namespace Server.Service
{
    public class Server : BilgeAdam.Data.Interface.IBilgeAdam
    {
        public static DateTime SentDate = new DateTime();
        public void MyName(string name, DateTime myDate)
        {
            var diff = (myDate - SentDate).TotalMilliseconds;
            Console.WriteLine(diff + "" + myDate + " - " + name);

            
        }

        public DateTime ServerDate()
        {
            return DateTime.Now;
        }

        
    }
}