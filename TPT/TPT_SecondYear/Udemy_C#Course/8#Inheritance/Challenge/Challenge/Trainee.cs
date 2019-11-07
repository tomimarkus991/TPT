using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    class Trainee:Employee
    {
        protected double WorkingHours { get; set; }
        protected double SchoolHours { get; set; }
        public Trainee() { }
        public Trainee(double workingHours, double schoolHours, string name, string firstName, float salary)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        public void Learn()
        {
            Console.WriteLine("I'm learning");
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} - {4}", this.WorkingHours, this.SchoolHours, this.Name, this.FirstName, this.Salary);
        }
    }
}
