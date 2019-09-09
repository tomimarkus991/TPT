using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtOfText = 0;
            string wholeText = string.Empty;
            do
            {
                Console.WriteLine("Please enter the name of your friend");
                string nameOfAFriend = Console.ReadLine();
                int currentLenght = nameOfAFriend.Length;
                lenghtOfText += currentLenght;
                wholeText += nameOfAFriend;
                
            } while (lenghtOfText < 20);
            Console.WriteLine("Thanks, that was enough!" + wholeText);
            Console.ReadKey();
        }
    }
}
