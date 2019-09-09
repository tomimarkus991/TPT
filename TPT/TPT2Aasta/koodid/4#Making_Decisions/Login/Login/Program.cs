using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Program
    {
        static string username;
        static string password;
        static void Main(string[] args)
        {
            Register();
            Login();
            Console.ReadKey();
        }

        public static void Register()
        {
            Console.WriteLine("Loo username ja password");
            Console.WriteLine("Username:");
            username = Console.ReadLine();
            Console.WriteLine("Password");
            password = Console.ReadLine();
            Console.WriteLine("Registration complete");
            Console.WriteLine("------------------------------------------------");
        }

        public static void Login()
        {
            Console.WriteLine("Sisesta username");
            string usernameK = Console.ReadLine();
            if (usernameK.Equals(username))
            {
                Console.WriteLine("Sisesta password");
                string passwordK = Console.ReadLine();
                if (passwordK.Equals(password))
                {
                    Console.WriteLine("Oled sisselogitud");
                }
                else
                {
                    Console.WriteLine("Username või password on vale");
                }
            }
            else
            {
                Console.WriteLine("Username või password on vale");
            }
        }
    }
}
