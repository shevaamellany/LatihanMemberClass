using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    class Program
    {
        static void Main(string[] args)
        {
            PlanetTicket ticket1 = new PlanetTicket();
            PlanetTicket ticket2 = new PlanetTicket();

            ticket1.Origin = "JOGJA";
            ticket1.Destination = "PKU";
            ticket1.Cost = 100;
            ticket1.Currency = "USD";

            ticket2.Origin = "JKT";
            ticket2.Destination = "PKU";
            ticket2.Cost = 750000;
            ticket2.Currency = "IDR";

            ticket1.PrintSummary();
            Console.WriteLine();
            ticket2.PrintSummary();

            Console.ReadKey();
              
        }
    }
}
