using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static char[,] Generate = new char[3, 3]
        {
            { '1', '2', '3' }, // 0
            { '4', '5', '6' }, // 1
            { '7', '8', '9' }  // 2
        };
        
        static void Main(string[] args)
        {
            Console.ReadKey();
            do
            {
                //Random rnd = new Random();
                //int player = rnd.Next(1, 3);
                int player = 2;
                int input = 0;
                bool inputCorrect = true;

                if (player == 2)
                {
                    player = 1;
                    EnterXorO(player, input);
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO(player, input);
                }
                FieldGeneration();
                do
                {
                    Console.Write("\nPlayer {0}: Choose your field! ", player);
                    input = Convert.ToInt32(Console.ReadLine());
                    //input = int.Parse(Console.ReadLine());
                } while (!inputCorrect);
            } while (true);            
        }

        public static void FieldGeneration()
        {
            Console.Clear();
            Console.WriteLine("      {0} | {1} | {2} ", Generate[0, 0], Generate[0, 1], Generate[0, 2]);
            Console.WriteLine("     ---|---|---");
            Console.WriteLine("      {0} | {1} | {2} ", Generate[1, 0], Generate[1, 1], Generate[1, 2]);
            Console.WriteLine("     ---|---|---");
            Console.WriteLine("      {0} | {1} | {2} ", Generate[2, 0], Generate[2, 1], Generate[2, 2]);
        }
        /*
        public static void Turns()
        {
            do
            {
                
                //Random rnd = new Random();
                //int player = rnd.Next(1, 3);
                int player = 2;
                int input = 0;
                bool inputCorrect = true;

                if (player == 2)
                {
                    player = 1;
                    EnterXorO(player, input);
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO(player, input);
                }
                FieldGeneration();
                do
                {
                    Console.Write("\nPlayer {0}: Choose your field! ", player);
                    input = Convert.ToInt32(Console.ReadLine());
                    //input = int.Parse(Console.ReadLine());
                } while (!inputCorrect);
            } while (true);           
        }
        */
        public static void EnterXorO(int player, int input)
        {
            char playerSign = ' ';
            if (player == 1)
            {
                playerSign = 'X';
            }
            else if (player == 2)
            {
                playerSign = 'O';
            }
            switch (input)
            {
                case 1: Generate[0, 0] = playerSign; break;
                case 2: Generate[0, 1] = playerSign; break;
                case 3: Generate[0, 2] = playerSign; break;
                case 4: Generate[1, 0] = playerSign; break;
                case 5: Generate[1, 1] = playerSign; break;
                case 6: Generate[1, 2] = playerSign; break;
                case 7: Generate[2, 0] = playerSign; break;
                case 8: Generate[2, 1] = playerSign; break;
                case 9: Generate[2, 2] = playerSign; break;
            }
        }
    }
}