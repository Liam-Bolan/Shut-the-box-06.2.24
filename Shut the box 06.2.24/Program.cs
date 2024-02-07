using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shut_the_box_06._2._24
{
    internal class Program
    {
        static int RollDice()
        {
         
            int roll1 = 0, roll2 = 0;
            Random rng = new Random();
            Random rng2 = new Random();
            roll1 = rng.Next(1, 7);
            roll2 = rng.Next(1, 7);
            int totalroll = roll1 + roll2;
            Console.WriteLine("Press [ENTER] to roll");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"You rolled {totalroll}\n");
            return totalroll;

        }
        static void Main(string[] args)
        {
            bool won = false;
            bool[] NUM = new bool[13];
            for (int i = 0; i < 20; i++)
            {
                int v = RollDice();
                NUM[v] = true;
                DisplayBox(NUM);
                Console.WriteLine("\nPress any key to roll dice");
                Console.WriteLine($"\nYou have rolled {1+i} time(s)\n");
                                
            }

            CheckWin(NUM);
            System.Threading.Thread.Sleep(2000);

            
        }
        static void DisplayBox(bool[] NUM)
        {
         
            for(int pos = 2; pos < 13; pos++)
            {
                
                if (NUM[pos] == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(pos+" - Closed" );
                    Console.ForegroundColor= ConsoleColor.White;
                }
                if (NUM[pos] == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(pos + " - Open" );
                    Console.ForegroundColor= ConsoleColor.White;
                }
            }
           
        }
        static void CheckWin(bool[] NUM)
        {
            bool won = false;
            for(int pos = 2; pos < 13; pos++)
            {
                if (NUM[pos] == true)
                {
                    won = true;
                }
                if(NUM[pos] == false)
                {
                    won = false;         
                }
                
            }
            

            
        }
    }
}
