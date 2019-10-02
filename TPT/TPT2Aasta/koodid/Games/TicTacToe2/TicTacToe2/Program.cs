using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe2
{
    class Program
    {
        static char[,] Field = 
        {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }
        };        
        static int turns = 0;        
        static void Main(string[] args)
        {           
            PlayerAndTurns();
        }
        public static void FieldGeneration()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("     {0} | {1} | {2}  ", Field[0, 0], Field[0, 1], Field[0, 2]);
            Console.WriteLine("    ---|---|---");
            Console.WriteLine("     {0} | {1} | {2}  ", Field[1, 0], Field[1, 1], Field[1, 2]);
            Console.WriteLine("    ---|---|---");
            Console.WriteLine("     {0} | {1} | {2}  ", Field[2, 0], Field[2, 1], Field[2, 2]);
            turns++;
        }
        public static void ResetField()
        {
            char[,] fieldInitial = 
            {

                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }
            };            
            Field = fieldInitial;
            FieldGeneration();
            turns = 0;
        }
        public static void PlayerAndTurns()
        {
            int input = 0;
            int player = 2;
            bool inputCorrect = true;
            #region
            // Test if field is already taken
            do
                {
                
                if (player == 2)
                    {
                        player = 1;
                        XorO('X', input);
                    }
                    else if (player == 1)
                    {
                        player = 2;
                        XorO('O', input);
                    }
                    FieldGeneration();
                
                    #region
                Win();
                    #endregion
                    do
                    {
                    
                    Console.WriteLine("\nPlayer {0}: Vali väli!", player);
                        try
                        {
                            input = Convert.ToInt32(Console.ReadLine());                        
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Sisesta number!");
                        }

                        if ((input == 1) && (Field[0, 0] == '1'))
                            inputCorrect = true;
                        else if ((input == 2) && (Field[0, 1] == '2'))
                            inputCorrect = true;
                        else if ((input == 3) && (Field[0, 2] == '3'))
                            inputCorrect = true;
                        else if ((input == 4) && (Field[1, 0] == '4'))
                            inputCorrect = true;
                        else if ((input == 5) && (Field[1, 1] == '5'))
                            inputCorrect = true;
                        else if ((input == 6) && (Field[1, 2] == '6'))
                            inputCorrect = true;
                        else if ((input == 7) && (Field[2, 0] == '7'))
                            inputCorrect = true;
                        else if ((input == 8) && (Field[2, 1] == '8'))
                            inputCorrect = true;
                        else if ((input == 9) && (Field[2, 2] == '9'))
                            inputCorrect = true;
                        else
                        {
                            inputCorrect = false;
                        }
                    } while (!inputCorrect);
                    #endregion
                } while (true);
        }
        public static void XorO(char playerSign, int input)
        {
            switch (input)
            {
                case 1: Field[0, 0] = playerSign; break;
                case 2: Field[0, 1] = playerSign; break;
                case 3: Field[0, 2] = playerSign; break;
                case 4: Field[1, 0] = playerSign; break;
                case 5: Field[1, 1] = playerSign; break;
                case 6: Field[1, 2] = playerSign; break;
                case 7: Field[2, 0] = playerSign; break;
                case 8: Field[2, 1] = playerSign; break;
                case 9: Field[2, 2] = playerSign; break;
            }
        }
        public static void Win()
        {
            //Console.ForegroundColor = ConsoleColor.Green;
            char[] playerChars = { 'X', 'O' };
            foreach (char playerChar in playerChars)
            {
                if (((Field[0, 0] == playerChar) && (Field[0, 1] == playerChar) && (Field[0, 2] == playerChar))
                    || ((Field[1, 0] == playerChar) && (Field[1, 1] == playerChar) && (Field[1, 2] == playerChar))
                    || ((Field[2, 0] == playerChar) && (Field[2, 1] == playerChar) && (Field[2, 2] == playerChar))
                    || ((Field[0, 0] == playerChar) && (Field[1, 0] == playerChar) && (Field[2, 0] == playerChar))
                    || ((Field[0, 1] == playerChar) && (Field[1, 1] == playerChar) && (Field[2, 1] == playerChar))
                    || ((Field[0, 2] == playerChar) && (Field[1, 2] == playerChar) && (Field[2, 2] == playerChar))
                    || ((Field[2, 0] == playerChar) && (Field[1, 1] == playerChar) && (Field[0, 2] == playerChar))
                    || ((Field[2, 2] == playerChar) && (Field[1, 1] == playerChar) && (Field[0, 0] == playerChar)))
                {
                    if (playerChar == 'X')
                    {
                        Console.WriteLine("\nVõitja on Player 2");
                    }
                    else if (playerChar == 'O')
                    {
                        Console.WriteLine("\nVõitja on Player 1");
                    }
                    Console.WriteLine("Press any key to reset the game!");
                    Console.ReadKey(); // ilma selleta resetib automaatselt
                    ResetField();
                    break;
                }
                else if (turns == 10)
                {
                    Console.WriteLine("Viik");
                    Console.WriteLine("Press any key to reset the game!");
                    Console.ReadKey();
                    ResetField();
                    break;
                }
            }
        }
    }
}
