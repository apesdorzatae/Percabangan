using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollerCoaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selamat Datang di RollerCoaster!\nSilahkan isi data dibawah sebelum naik\nMasukkan Umur Anda :");
            int umur = int.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan Tinggi Anda :");
            int tinggi = int.Parse(Console.ReadLine());
            if (umur >= 15 && tinggi >= 150)
            {
                Console.WriteLine("Umur dan tinggi anda sudah cukup untuk menaiki RollerCoaster, silahkan masuk.");
            }
            else if (umur <= 15 && tinggi >= 150)
            {
                Console.WriteLine("Anda belum cukup umur untuk menaiki RollerCoaster");
            }
            else if (umur >= 15 && tinggi <= 150)
            {
                Console.WriteLine("Anda belum cukup tinggi untuk menaiki RollerCoaster");
            }
            else { Console.WriteLine("Anda belum cukup tinggi dan umur untuk menaiki Rolleroaster"); }
        }
    }
}
