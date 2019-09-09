using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_IF_Statements
{
    class Program
    {      
        static int highscore = 350;
        static string highscorePlayer = "Oliver";
        static void Main(string[] args)
        {
            
            CheckHighScore(250, "Martin");
            CheckHighScore(450, "Kati");
            CheckHighScore(550, "Tomi");
            Console.Read();
        }
        public static void CheckHighScore(int score, string playerName)
        {            
            if (score > highscore)
            {
                highscore = score;                
                highscorePlayer = playerName;
                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("New highscore holder is " + playerName);              
            }
            else if (score == highscore)
            {
                Console.WriteLine("Your score " + score + " matches the highscore " + highscore);
            }
            else
            {
                Console.WriteLine("The old highscore of " + highscore + 
                " could not be broken and is still held by " + highscorePlayer);
            }
        }
    }
}
