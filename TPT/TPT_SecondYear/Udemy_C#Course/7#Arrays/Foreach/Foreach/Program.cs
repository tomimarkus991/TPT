using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] nums = new int[10];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
                nums[i] += 10;                
            }

            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Element: {0} = {1}", j, nums[j]);
            }
            int counter = 0;
            foreach (int k in nums)
            {
                Console.WriteLine("Element: {0} = {1}", counter, k);
                counter++;
            }
            */

            string[] friends = new string[5];
            friends[0] = "Oskar";
            friends[1] = "Sten";
            friends[2] = "Albert";
            friends[3] = "Kaur";
            friends[4] = "Ekke";

            // või
            //string[] friends2 = { "Oskar", "Sten", "Albert", "Kaur", "Ekke" };

            int counter = 0;
            foreach (string s in friends)
            {
                Console.WriteLine("Element: {0} = Tere {1}", counter, s);
                counter++;
            }
             
            Console.ReadKey();
        }
    }
}
