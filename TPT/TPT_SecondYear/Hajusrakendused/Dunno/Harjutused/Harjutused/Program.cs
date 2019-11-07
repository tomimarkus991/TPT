using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjutused
{
    class Program
    {
        public static void Main(string[] args)
        {
            Dartboard();
            Diagonally();
            NotesRotate();
            ActorsCount();
            Console.ReadKey();
        }

        /// <summary>
        /// For every number on a dartboard (1 to 20), work out the possible single, double and treble scores.
        /// For example, the number 20 has the possible score 20, 40 and 60.
        /// Print result to console.
        /// </summary>
        public static void Dartboard()
        {
            int[] arvud = new int[21];            
            int counter = 1;
            int number = 1;
            foreach (int arv in arvud)
            {
                if (counter < 21)
                {
                    int a = number * 1;
                    int b = number * 2;
                    int c = number * 3;
                    number++;
                    counter++;
                    Console.WriteLine("The number {0} has the possible score {0}, {1} and {2}", a, b, c);
                }
            }
        }

        /// <summary>
        /// Print the word diagonally, diagonally from left to right, top to bottom. When you display your answer it should look something like this:
        /// D
        ///  I
        ///   A
        ///    G
        ///     O
        ///      N
        ///       A
        ///        L
        /// </summary>
        static void Diagonally()
        {
            string word = "DIAGONAL";
            string spaces = "";

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(spaces + word[i]);
                spaces += " ";
            }
        }

        /// <summary>
        /// Võtab sisendiks ühe tähe A-st kuni G-ni ja siis liigutab tähti nii,
        /// et sisestatud täht on esimene ja edasi läheb tähestiku järjekorras.
        /// Pärast G tähte algab uuesti A-st.
        /// 
        /// Näiteks C puhul on väljund CDEFGAB
        /// </summary>
        static void NotesRotate()
        {
            string notes = "ABCDEFG";
        }

        /// <summary>
        /// Kuvada konsooli mitu mees- ja mitu naisnäitlejat nimekirjas on.
        /// </summary>
        public static void ActorsCount()
        {
            List<string> actors = new List<string> {
                "Beyonce (f)",
                "David Bowie (m)",
                "Elvis Costello (m)",
                "Madonna (f)",
                "Elton John (m)",
                "Charles Aznavour (m)"
            };
            int Mcounter = 0;
            int Ncounter = 0;
            foreach (string inimest in actors)
            {
                if (inimest.Contains("(f)"))
                {
                    Ncounter++;
                    
                }

                if (inimest.Contains("(m)"))
                {
                    Mcounter++;
                }
            }
            Console.WriteLine("Naisi on {0}", Ncounter);
            Console.WriteLine("Mehi on {0}", Mcounter);
        }

        /// <summary>
        /// Following on from the exercise above, work out if a series of 5 integers contain the same number.
        /// So the sequence "10-9-8-7-7" would yield the answer "Pair of numbers found".
        /// Input is string separated with hypens.
        /// </summary>
        static void NumberPairs()
        {

        }

        /// <summary>
        /// Tõlkida tekst morse koodi.
        /// Tähestik .- on a -... on b jne
        /// .- -... -.-. -.. . ..-. --. .... .. .--- -.- .-.. -- -. --- .--. --.- .-. ... - ..- ...- .-- -..- -.-- --..
        /// 
        /// smorse("sos") => "...---..."
        /// smorse("daily") => "-...-...-..-.--"
        /// smorse("programmer") => ".--..-.-----..-..-----..-."
        /// smorse("bits") => "-.....-..."
        /// smorse("three") => "-.....-..."
        /// 
        /// https://www.reddit.com/r/dailyprogrammer/comments/cmd1hb/20190805_challenge_380_easy_smooshed_morse_code_1/
        /// </summary>
        static void Morse()
        {

        }
    }
}
