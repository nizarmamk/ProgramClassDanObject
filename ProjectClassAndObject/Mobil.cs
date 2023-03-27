using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassAndObject
{
    public class Mobil
    {
        // properties
        public string nama { get; set; } = "...";
        public string warna { get; set; } = "...";
        public int jmlpintu { get; set; }
        public string merek { get; set; } = "...";
        public string model { get; set; } = "...";
        public int tahun { get; set; }

        // method
        public void Gas(int kecepatan)
        {
            Console.Write("Mobil {0} {1} berjalan dengan kecepatan {2} km/jam ", merek, model, kecepatan);
        }
        
        public void Klakson(string suara)
        {
            Console.Write("dan memiliki suara klakson {0}.", suara);
        }

        public void TampilkanInfo()
        {
            Console.WriteLine("\nMobil {0} berwarna {1}, merek {2} model {3} keluaran tahun {4} dengan jumlah pintu sebanyak {5}.\n", nama, warna, merek, model, tahun, jmlpintu);
        }

    }
}
