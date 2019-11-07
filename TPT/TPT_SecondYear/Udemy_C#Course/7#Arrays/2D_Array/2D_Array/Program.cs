using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare 2D Array
            string[,] matrix;

            // declare 3D Array
            int[,,] threeD;

            // two dimensional Array

            int[,] array2D = new int[,]
            {
                {1,2,3 }, // row 0
                {4,5,6 }, // row 1
                {7,8,9 }  // row 2
            };
            Console.WriteLine("Value is {0}", array2D[2,0]); // row essa ja ss ülalt alla
            

                                        // 3 rows and 2 in each row
            string[,] array2DString = new string[3, 2] { { "one", "two" }, { "three", "four" }, { "five", "six" } };            
            array2DString[1, 1] = "chicken";            
            Console.WriteLine(array2DString[1, 1]);

            int dimensions = array2DString.Rank;
            Console.WriteLine(dimensions);

            Console.ReadKey();
        }                                  
        
    }
}
