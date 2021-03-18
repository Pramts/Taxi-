using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Pertemuan_3
{
    class Taxi
    {
        public string name { get; set; }
        public bool duty { get; set; }
        public float num { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name: {0}", name);
            Console.WriteLine("On Duty: {0}", duty);
            Console.WriteLine("Number of Passenger: {0}\n", num);
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} Sedang Menjemput Penumpang", name);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} Sedang Menjemput Penumpang", name);
        }
    }
}
