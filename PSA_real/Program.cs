using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSA_real
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create IBM stock and attach investors
            IBM ibm = new IBM("IBM", 120.00);
            ibm.Attach(new Investor(ibm, "Sorros"));
            ibm.Attach(new Investor(ibm, "Berkshire"));

            // Fluctuating prices will notify investors
            ibm.Price = 120.10;
            ibm.Price = 121.90;
            ibm.Price = 120.50;
            ibm.Price = 120.75;

            Console.ReadKey();
        }
    }
}
