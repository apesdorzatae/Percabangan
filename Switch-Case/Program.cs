using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
//SWITCH CASE EXERCISE
namespace Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //SOAL 1 : MEMILIH KARAKTER PEMAIN
            Console.WriteLine("Choose Your Character!\t[Warrior]\t/\t[Mage]\t\t/\t[Thief]");
            string character = Console.ReadLine().ToLower();
                switch (character)
                {
                    case "warrior":
                        Console.WriteLine("You have choosen the Warrior. Ready for battle!\n");
                        break;
                    case "mage":
                        Console.WriteLine("You have choosen the Mage. Prepare your spells!\n");
                        break;
                    case "thief":
                        Console.WriteLine("You have choosen the Thief. Sneak and steal!\n");
                        break;
                    default:
                        Console.WriteLine("Invalid character choice.\n");
                        break;
                }


            //SOAL 2 : MEMILIH JENIS PERTARUNGAN DALAM GAME
            Console.WriteLine("Choose a combat type!\t[Melee]\t\t/\t[Ranged]\t\t/\t[Magic]");
            string combat = Console.ReadLine().ToLower();
            switch (combat)
            {
                case "melee":
                    Console.WriteLine("You engage in melee combat. Use your strength!\n");
                    break;
                case "ranged":
                    Console.WriteLine("You attack from a distance. Use your precision!\n");
                    break;
                case "magic":
                    Console.WriteLine("You cast a powerful spell. Use your wisdom!\n");
                    break;
                default:
                    Console.WriteLine("Invalid combat choice.\n");
                    break;
            }

            //SOAL 3 : MEMILIH AKSI DALAM GAME
            Console.WriteLine("Choose an action!!\t[Attack]\t\t/\t[Defend]\t\t/\t[Run]");
            string action = Console.ReadLine().ToLower();
            switch (character)
            {
                case "attack":
                    Console.WriteLine("You attack your enemy with all your might!\n");
                    break;
                case "defend":
                    Console.WriteLine("You brace yourself and defend againts the attack!\n");
                    break;
                case "run":
                    Console.WriteLine("You choose to run away and live to fight another day!\n");
                    break;
                default:
                    Console.WriteLine("Invalid action choice\n");
                    break;
            }


            //PERCOBAAN CONTOH 2
            Console.WriteLine("Enter a number between 1 and 7 to select a day of the week:");
            int dayNumber = int.Parse(Console.ReadLine());
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid number! Please enter a number between 1 an break");
                    break;  
            }

            //CHALLENGE MR VANDI
            /* 3 role: warrior, mage, thief
             * 3 level: expert, medium, beginner
             * kalu kamu beginner, pukulan pedangmu hanya 10%
             * kalau medium  pukulan 50%
             * kalau expert 80%
             * setiap mage dan thief juga memiliki  increase yang sama
             * oke oke
             */ 
            Console.WriteLine("Pick Your Character Role! [Warrior/Mage/Thief]");
            string a = Console.ReadLine().ToLower();
            switch (a) 
            {
                case "warrior":
                    Console.WriteLine("You Choosed Warrior!");
                    Console.WriteLine("Now Choose Your Level! [Beginner/Medium/Expert]");
                    string q = Console.ReadLine().ToLower();
                    if ( q == "beginner")
                    {
                        Console.WriteLine("[Beginner Level] You got 10% damage using melee weapon");
                    }
                    else if (q == "medium")
                    {
                        Console.WriteLine("[Medium Level] You got 50% damage using melee weapon");
                    }
                    else if (q == "expert")
                    {
                        Console.WriteLine("[Expert Level] You got 80% damage using melee weapon");
                    }
                    else
                    {
                        Console.WriteLine("*wrong input or spelling*\n[Program Finished..]");
                    }
                    break;

                case "mage":
                    Console.WriteLine("You Choosed Mage!");
                    Console.WriteLine("Now Choose Your Level! [Beginner/Medium/Expert]");
                    string w = Console.ReadLine().ToLower();
                    if (w == "beginner")
                    {
                        Console.WriteLine("[Beginner Level] You got 10% damage using magic");
                    }
                    else if (w == "medium")
                    {
                        Console.WriteLine("[Medium Level] You got 50% damage using magic");
                    }
                    else if (w == "expert")
                    {
                        Console.WriteLine("[Expert Level] You got 80% damage using magic");
                    }
                    else
                    {
                        Console.WriteLine("*wrong input or spelling*\n[Program Finished..]");
                    }
                    break;

                case "thief":
                    Console.WriteLine("You Choosed Thief!");
                    Console.WriteLine("Now Choose Your Level! [Beginner/Medium/Expert]");
                    string e = Console.ReadLine().ToLower();
                    if (e == "beginner")
                    {
                        Console.WriteLine("[Beginner Level] You got 10% damage using ranged attacks");
                    }
                    else if (e == "medium")
                    {
                        Console.WriteLine("[Medium Level] You got 50% damage using ranged attacks");
                    }
                    else if (e == "expert")
                    {
                        Console.WriteLine("[Expert Level] You got 80% damage using ranged attacks");
                    }
                    else
                    {
                        Console.WriteLine("*wrong input or spelling*\n[Program Finished..]");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Character Role\n[Program Finished..]");
                    break;
            }

        }
    }
}
