using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC
{
    class Car
    {
        protected int HP { get; set; }
        protected string Color { get; set; }
        protected CarIDinfo carIDinfo = new CarIDinfo();
        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDinfo.IDNum = idNum;
            carIDinfo.Owner = owner;
        }
        public void GetCarIDInfo()
        {
            Console.WriteLine("Car ID: {0} and is owned by {1}", carIDinfo.IDNum, carIDinfo.Owner);
        }
        public Car(int hp, string color)// Constructor
        {
            this.HP = hp;
            this.Color = color;
        }        
        public virtual void Repair()
        {
            Console.WriteLine("Your car was repaired");
        }
        public virtual void ShowDetails()
        {
            Console.WriteLine("HP: {0} Color: {1}", HP, Color);            
        }
    }
}
