using System;

namespace BilgeAdam
{
    class Program
    {
        public static readonly Data.Interface.IBilgeAdam channel = Helper.WcfHelper.Wcf<Data.Interface.IBilgeAdam>
       .Channel("http://10.11.202.61:145/Service1");

        static void Main(string[] args)
        {
            Helper.WcfHelper.Run<Service.BilgeAdam, Data.Interface.IBilgeAdam>("10.11.202.66", 145, "Service1");

            Service.BilgeAdam.SentDate = DateTime.UtcNow;
            channel.MyName("erçin", Service.BilgeAdam.SentDate);
            //channel.Test1();
            Console.WriteLine("fired");

            Console.ReadLine();
        }
    }
}