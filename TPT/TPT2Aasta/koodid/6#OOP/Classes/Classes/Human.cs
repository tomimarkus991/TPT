using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    // this class is a blueprint for a datatype
    class Human
    {
        //member variable
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        // default constructor
        public Human()
        {
            Console.WriteLine("Constructor called. Object created");
        }

        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        // parameterized constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        // member method
        public void IntroduceYourself()
        {
            if (firstName != null && lastName != null && eyeColor != null && age != 0)
            {
                Console.WriteLine("Hi my name is {0} {1} my eyes are {2} and i'm {3} years old.", firstName, lastName, eyeColor, age);
                //if (age == 1)
                //{
                //    Console.WriteLine("Hi my name is {0} {1} my eyes are {2} and i'm {3} year old.", firstName, lastName, eyeColor, age);
                //}
                //else
                //{
                //    Console.WriteLine("Hi my name is {0} {1} my eyes are {2} and i'm {3} years old.", firstName, lastName, eyeColor, age);
                //}
            }
            else if (firstName != null && lastName != null && eyeColor != null)
            {
                Console.WriteLine("Hi my name is {0} {1} i'm {2} years old.", firstName, lastName, eyeColor);
            }

            else if (firstName != null && lastName != null && age != 0)
            {
                Console.WriteLine("Hi my name is {0} {1} i'm {2} years old.", firstName, lastName, age);
            }

            else if (firstName != null && lastName != null)
            {
                Console.WriteLine("Hi my name is {0} {1}.", firstName, lastName);
            }

            else if (firstName != null)
            {
                Console.WriteLine("Hi my name is {0}.", firstName);
            }
        }
    }
}
