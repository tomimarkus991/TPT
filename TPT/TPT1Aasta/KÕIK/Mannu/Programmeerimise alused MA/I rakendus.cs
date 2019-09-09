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
            Console.WriteLine("Tere! Arvutan arve.");
            decimal firstNumber;
            decimal secondNumber;
            // int firstNumber;
            // int secondNumber;

            // Int32.Parse + int kasutatakse täisarvude puhul ning decimal.Parse + decimal kasutatakse komadega arvude puhul.
            // Int32.Parse aitab välja arvutada nii, et kannad ise arvud hiljem sisse mustal screenil.
            // I arvu küsimuse tekst.
            Console.WriteLine("Sisestage esimene arv:");
            firstNumber = decimal.Parse(Console.ReadLine());
           // firstNumber = Int32.Parse(Console.ReadLine());

            // II arvu küsimuse tekst.
            Console.WriteLine("Sisestage teine arv:");
            secondNumber = decimal.Parse(Console.ReadLine());
            // secondNumber = Int32.Parse(Console.ReadLine());

            decimal thirdNumber = firstNumber * secondNumber;
            Console.WriteLine(thirdNumber + " on vastus.");
            // Avaneb must screen. Saab ka ctrl + F5 kasutada.
            Console.ReadLine();
        }
    }
}

//Järgmine tund C# if statements youtube BRACKEY