using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = BilgeAdam.Helper.WcfHelper
                .Wcf<BilgeAdam.Data.Interface.IBilgeAdam>.Channel("http://127.0.0.1:145/ServiceTest");

            while (true)
            {
                channel.MyName("İSTEMCİ", DateTime.UtcNow);
                DateTime serverDate = channel.ServerDate();
                Console.WriteLine("ben istemciyim sunucuya isimimi gönderdim" + serverDate);

                Thread.Sleep(1000);
                
            }
        }
    }
}
