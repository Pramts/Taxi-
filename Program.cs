using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Pertemuan_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.name = "Jono";
            taxi.duty = true;
            taxi.num = 10;

            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
