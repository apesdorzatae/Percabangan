using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamaLengkap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan Nama");
            if (Console.ReadLine() == "Faikhaa" || Console.ReadLine() == "faikhaa" || Console.ReadLine() == "faikha" || Console.ReadLine() == "Faikha")
            {
                Console.WriteLine("[BERHASIL]\nNama Lengkap : Faikhaa 'Adzroo Kaamila Qurrota'aina\nUmur : 16 Tahun\n Asal : Yogyakarta");
            }
            else if (Console.ReadLine() == "Abdillah" || Console.ReadLine() == "abdillah" || Console.ReadLine() == "Abdilah" || Console.ReadLine() == "abdilah" || Console.ReadLine() == "Abdi" || Console.ReadLine() == "abdi" || Console.ReadLine() == "Abdil" || Console.ReadLine() == "abdil" || Console.ReadLine() == "Hakim" || Console.ReadLine() == "hakim")
            {
                Console.WriteLine("Nama Lengkap : Abdillah Hakim\nUmur : 15 Tahun\n Asal : Cilacap");
            }
            else if (Console.ReadLine() == "Fahrezy" || Console.ReadLine() == "fahrezy" || Console.ReadLine() == "Rezy" || Console.ReadLine() == "rezy" || Console.ReadLine() == "Rezzy" || Console.ReadLine() == "rezzy" || Console.ReadLine() == "Rezzzy" || Console.ReadLine() == "rezzzy" || Console.ReadLine() == "Rezzzzy" || Console.ReadLine() == "rezzzzy")
            {
                Console.WriteLine("Nama Lengkap : Fahrezy Shiham Muttaki\nUmur : 16 Tahun\n Asal : Berau");
            }
            /*else if (Console.ReadLine() == "Fahrezy" || Console.ReadLine() == "fahrezy" || Console.ReadLine() == "Rezy" || Console.ReadLine() == "rezy" || Console.ReadLine() == "Rezzy" || Console.ReadLine() == "rezzy" || Console.ReadLine() == "Rezzzy" || Console.ReadLine() == "rezzzy" || Console.ReadLine() == "Rezzzzy" || Console.ReadLine() == "rezzzzy")
            {

            }*/
                    else
            {
                Console.WriteLine("[GAGAL] Ini bukan Nama saya");
            }
        //selesai
        }
    }
}
