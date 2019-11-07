using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripsTrapsTrull
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cells = new string[9]
                { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            int activePlayer = 1;
            while (true)
            {
                DrawBoard(cells);
                Console.WriteLine("Player " + activePlayer + " move");
                int cellIndex = ReadNumber("Enter cell number");
                cellIndex = cellIndex - 1;
                if (CanMakeMove(cells, cellIndex))
                {
                    if (activePlayer == 1)
                    {
                        cells[cellIndex] = "X";
                        activePlayer = 2;
                    }
                    else
                    {
                        cells[cellIndex] = "O";
                        activePlayer = 1;
                    }
                    if (hasEmptyCell)
                    {
                        Console.WriteLine("Draw");
                        break;
                    }
                }
            }
        }
        public static bool HasWinner(string[] cells)
        {
            // TODO
        }

        public static bool Horisontal(string[] cells, int index, string figure)

        public static bool IsDraw(string[] cells)
        {
            bool hasEmptyCell = true;
            for (int i = 0; i< cells.Length ; i++)
            {
                if(cells[i] != "X" && cells[i] != "O")
                {
                    hasEmptyCell = true;
                }
            }
            return !hasEmptyCell;
        }
        public static bool CanMakeMove(string[] cells, int cellIndex)
        {
            string cell = cells[cellIndex];
            if (cell == "X" || cell == "O")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static void DrawBoard(string[] cells)
        {
            Console.Clear();
            for (int i = 0; i < 9; i = i + 3)
            {
                string row = "|";
                for (int j = i; j < i + 3; j = j + 1)
                {
                    row = row + cells[j] + "|";
                }
                Console.WriteLine(row);
            }
        }
        public static int ReadNumber(string input)
        {
            Console.WriteLine(input);
            string str = Console.ReadLine();
            int num = int.Parse(str);
            return num;
        }
    }
}
