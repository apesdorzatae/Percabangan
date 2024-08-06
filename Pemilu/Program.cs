using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pemilu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================================================================\nPENDAFTARAN PEMILU 2024\n===================================================================\n\n[Verifikasi]\nmasukkan umur anda terlebih dahulu");
            int umur = int.Parse(Console.ReadLine());
            if (umur < 17)
            {
                Console.WriteLine("\nMaaf, anda belum cukup umur untuk mengikuti pemilu ini");
            }
            else if (umur >= 17 && umur < 100)
            {
                Console.WriteLine("Anda boleh mengikuti pemilu ini");
            }
            else if (umur > 100) {
                Console.WriteLine("Anda boleh mengikuti pemilu ini dan selamat, anda telah menjangkau umur panjang");
            }
            else if (umur < 1) { Console.WriteLine("Umur anda tidak masuk akal"); }
            //PILIH PAK PRABOWO GAS
            }
    }
}
