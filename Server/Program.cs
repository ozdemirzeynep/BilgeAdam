using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            BilgeAdam.Helper.WcfHelper
                .Run<Service.Server, BilgeAdam.Data.Interface.IBilgeAdam>("127.0.0.1",145,"ServiceTest");

            Console.ReadLine();
        }
    }
}
