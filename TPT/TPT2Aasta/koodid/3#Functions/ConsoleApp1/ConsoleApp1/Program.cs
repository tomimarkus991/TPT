using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta palun number");
            //string userInput = Console.ReadLine();

            string arv1 = Console.ReadLine();
            string arv2 = Console.ReadLine();

            int uus1 = int.Parse(arv1);
            int uus2 = int.Parse(arv2);            

            try
            {
                

                int result = uus1 / uus2;
                
            }
            catch (DivideByZeroException)
            {                
                Console.WriteLine("ei saa nulliga jagada");
            }


            //try
            //{
            //    int userInputAsInt = int.Parse(userInput);
            //}
            //catch (FormatException)
            //{                
            //    Console.WriteLine("FORMAT EXCEPTION, enter only numbers");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("General EXCEPTION, number was too big or too short");
            //}
            //catch (ArgumentNullException)
            //{
            //    Console.WriteLine("null oli");
            //}

            finally
            {
                Console.WriteLine("This is called anyawys");

            }


            Console.ReadKey();

        }     
    }
}
