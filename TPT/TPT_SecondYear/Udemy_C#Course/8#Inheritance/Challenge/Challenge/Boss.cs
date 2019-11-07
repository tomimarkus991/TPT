using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    class Boss:Employee
    {
        protected string CompanyCar { get; set; }
        public Boss() { }
        public Boss(string companyCar, string name, string firstName, float salary)
        {
            this.CompanyCar = companyCar;
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }
        public void Lead()
        {
            Console.WriteLine("I'm leading this company");
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3}", this.CompanyCar, this.Name, this.FirstName, this.Salary);
        }
    }
}
