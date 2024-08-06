using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuaraHewan
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("============================================================\nmeong = kucing\nguk = anjing\nmbek = kambing\n============================================================\n\ntulis suara hewan di bawah sesuai daftar diatas");
             string suara = Console.ReadLine();
             if (suara == "meong")
             {
                 Console.WriteLine("ini adalah kucing"); 
             } 
            else if (suara == "guk")
            {
                Console.WriteLine("ini adalah anjing");
            }
            else if (suara == "mbek")
            {
                Console.WriteLine("ini adalah kambing");
            }
            else 
            {
                Console.WriteLine("makhluk apaan ini");
            }


          /*  string suara = "meong";
            if (suara == "meong")
            {
                Console.WriteLine("ini adalah kucing"); 
            } */
        }
    }
}
