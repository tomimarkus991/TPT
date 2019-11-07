using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Tomi = new Human("Tomi", "Alber", "blue", 17);
            Tomi.IntroduceYourself();

            Human Dracula = new Human("Dracula", "Vampiir", "purple");
            Dracula.IntroduceYourself();

            Human basicHuman = new Human();
            basicHuman.IntroduceYourself();

            Human Kreek = new Human("Kreek");
            Kreek.IntroduceYourself();

            Human Masin = new Human("Masin", "Suurus");
            Masin.IntroduceYourself();

            //Human Legolas = new Human("Legolas", "Välejalg", 555);
            //Legolas.IntroduceYourself();

            Console.ReadKey();
        }
        
        
    }
}
