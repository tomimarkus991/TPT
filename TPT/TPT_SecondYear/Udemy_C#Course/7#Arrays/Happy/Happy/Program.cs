using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Happy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Siin võib olla üks kõik kui palju asju
            ArrayList myArrayList = new ArrayList();

            // Siin peab olema kindel arv asju
            ArrayList myArrayList2 = new ArrayList(100);
            myArrayList.Add(57);
            myArrayList.Add(12.5);
            myArrayList.Add(32);
            myArrayList.Add(12.5);
            myArrayList.Add("fds");

            // Eemaldab kindla elemendi kui neid on 2 ss esimese elemendi
            myArrayList.Remove(12.5);

            // Eemaldab elemedi kindlalt kohalt (sellisel juhul esimese ehk nr. 57)
            myArrayList.RemoveAt(3);

            Console.WriteLine(myArrayList.Count);
            

            foreach (object element in myArrayList)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
    }
}
