using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    class Employee
    {
        protected string Name { get; set; }
        protected string FirstName { get; set; }
        protected float Salary { get; set; }
        public Employee()
        {           
            Name = "Tomi Markus Alber";
            FirstName = "Tomi";
            Salary = 50000;
        }
        public Employee(string name, string firstName, float salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }      
        public void Work()
        {
            Console.WriteLine("I'm working");
        }
        public void Pause()
        {
            Console.WriteLine("I have a pause");
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}", Name, FirstName, Salary);
        }
    }
}
