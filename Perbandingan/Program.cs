using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perbandingan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan angka pertama :");
            int angka1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan angka kedua :");
            int angka2 = int.Parse(Console.ReadLine());
            if (angka1 == angka2) { Console.WriteLine("Nilai kedua angka sama"); }
            else if (angka1 > angka2)
            {
                Console.WriteLine("Nilai angka pertama lebih besar dibandingkan angka kedua");
            }
            else if (angka1 < angka2)
            {
                Console.WriteLine("Nilai angka kedua lebih besar dibandingkan angka pertama");
            }
            else;

            }
    }
}
