using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Nested
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SOAL 1 : KONDISI KESEHATAN PEMAIN
            do {
                string a = Console.ReadLine();
                if (a == "f") { break; }
               
                else { 
                
                int playerHealth = int.Parse(a);
                
                    if (playerHealth > 70)
                {
                    Console.WriteLine("You are in great shape!");
                }
                
                    else
                {
                    if (playerHealth > 30)
                    {
                        Console.WriteLine("Your health is moderate, be careful!");
                    }
                    else
                    {
                        Console.WriteLine("You are in critical condition");
                    }
                }
            }
            } while (true); 

            // SOAL 2 : KEPUTUSAN PEMAIN
            int PlayerStrenght = 0;
            int PlayerStealth = 0;

            Console.WriteLine("Pick a choice! [Fight/Sneak]");
            do {
                string PlayerChoice = Console.ReadLine();
                if (PlayerChoice == "Fight" || PlayerChoice == "fight")
            {
                if (PlayerStrenght > 60)
                {
                    Console.WriteLine("You fight bravely and defeat your enemies.");
                }
                else
                {
                    Console.WriteLine("You fight hard but are overpowered.");
                } break;
            }
            else if (PlayerChoice == "Sneak" || PlayerChoice == "sneak")
            {
                if (PlayerStealth > 50)
                {
                    Console.WriteLine("You sneak past the guards unnoticed.");
                }
                else
                {
                    Console.WriteLine("You are spotted and the alarm is raised!");
                } break;
            }
            else
            {
                Console.WriteLine("Pick between Fight or Sneak!");
            }
        } while (true); 

            //SOAL 3 : MELAWAN BOSS TERAKHIR
            int PlayerStrenght = 0;
            int PlayerDefense = 0;

            Console.WriteLine("Pick a choice! [Fight/Defend]");
            do {
                string PlayerChoice = Console.ReadLine();
                if (PlayerChoice == "Fight" || PlayerChoice == "fight")
            {
                if (PlayerStrenght > 80)
                {
                    Console.WriteLine("You defeated the boss with your powerful attacks!");
                }
                else
                {
                    Console.WriteLine("The boss was too strong for you!");
                } break;
            }
            else if (PlayerChoice == "Defend" || PlayerChoice == "defend")
            {
                if (PlayerDefense > 70)
                {
                    Console.WriteLine("You successfully defended againts the boss's attacks!");
                }
                else
                {
                    Console.WriteLine("The boss broke through your defense!");
                } break;
            }
            else
            {
                Console.WriteLine("Pick between Fight or Dedend!");
            }
        } while (true); 


            // CHALLENGE MR UYUN
            int hp = 100;
             Console.WriteLine("There is an enemy with 100 health, try decrease the monster health with inserting a damage with 0 to 100 range\nType \"f\" to exit the game");
             do
             {
                 string input = Console.ReadLine();
                 if (input == "f")
                 {
                     Console.WriteLine("[Game Over]");
                     break;
                 }
                 else
                 {
                     if (hp > 0)
                     {
                         int damage = int.Parse(input);

                         if (damage > 0 && damage <= hp)
                     { 
                         int b = hp - damage;

                             if (b > 0)
                             {
                                 Console.WriteLine("You insert {0} damage, the enemy's health is now {1}", damage, b);
                                 hp = b;
                             }
                             else
                             {
                                 Console.WriteLine("[Game Over]");
                                 break;
                             }
                     }
                         else
                         {
                             Console.WriteLine($"You can only put a damage below current enemy's health: {hp}");
                         }
                     }
                     else
                     {
                         Console.WriteLine("[Game Over]");
                         break;
                     }
                 }
             } while (hp > 0); 
        }
    }
}
