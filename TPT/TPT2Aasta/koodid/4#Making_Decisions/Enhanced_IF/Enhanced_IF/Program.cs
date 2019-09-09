using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enhanced_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            //[condition] ? [first expression] : [second expression]
            //condition has to be either true or false

            //The conditional Operator is right-associative
            //That means, that a ? b : c ? d : e
            // is evaluated as a ? b : (c ? d : e)

            //The conditional Operator cannot be overloaded.

            //in celcius
            //Play around with that Value
            int temperature = -5;

            string stateOfMatter;

            if (temperature < 0)
            {
                stateOfMatter = "solid";
            }
            if(temperature > 100)
            {
                stateOfMatter = "gas";
            }
            else
            {
                stateOfMatter = "liquid";
            }
            Console.WriteLine("State of Matter is {0}", stateOfMatter);

            temperature += 30;

            //in short
            stateOfMatter = temperature < 0 ? "solid" : temperature > 100 ? "gas" : "liquid";

            // add gas state
            temperature += 100;
            stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";

            Console.WriteLine("State of Matter is {0}", stateOfMatter);
            Console.ReadKey();
        }
    }
}
