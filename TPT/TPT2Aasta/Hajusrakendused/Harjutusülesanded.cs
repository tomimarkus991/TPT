using System;
using System.Collections.Generic;

namespace Harjutusülesanded
{
    class Program
    {
        static void Main(string[] args)
        {
            Dartboard();
            NotesRotate();
            ActorsCount();
        }

        /// <summary>
        /// For every number on a dartboard (1 to 20), work out the possible single, double and treble scores.
        /// For example, the number 20 has the possible score 20, 40 and 60.
        /// Print result to console.
        /// </summary>
        static void Dartboard()
        {
            for (int i = 1; i <= 20; i++)
            {
                int a = i * 1;
                int b = i * 2;
                int c = i * 3;
            }
            Console.WriteLine(a, b, c);
            Console.WriteLine(String.Format("The number {0} has the possible score {0}, {1} and {2}", 20, 40, 60));
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
        static void ActorsCount()
        {
            List<string> actors = new List<string> {
                "Beyonce (f)",
                "David Bowie (m)",
                "Elvis Costello (m)",
                "Madonna (f)",
                "Elton John (m)",
                "Charles Aznavour (m)"
            };

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
