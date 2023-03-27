using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobil mobil1 = new ProjectClassAndObject.Mobil
            {
                nama = "saya",
                warna = "Hitam",
                merek = "Porsche",
                model = "911 GT3",
                tahun = 2022,
                jmlpintu = 2
            };

            Mobil mobil2 = new ProjectClassAndObject.Mobil
            {
                nama = "teman saya",
                warna = "Kuning",
                merek = "Chevrolet",
                model = "Camaro",
                tahun = 2023,
                jmlpintu = 2
            };

            mobil1.Gas(90);
            mobil1.Klakson("tin tin");
            mobil1.TampilkanInfo();

            mobil2.Gas(80);
            mobil2.Klakson("tet tet");
            mobil2.TampilkanInfo();

            Console.WriteLine("Tekan enter untuk keluar . . .");
            Console.ReadKey();
        }
    }
}
