using System;
using System.IO;
using System.Xml.Linq;

namespace RestoranMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            AddFood();
            Console.ReadKey();
        }
        public static void AddFood()
        {
            StreamReader sr = new StreamReader(@"C:\TPT\TPT\TPT2Aasta\Hajusrakendused\RestoranMenu\RestoranMenu\XML\Menu.xml");
            //StreamReader sr = new StreamReader(@"~\RestoranMenu\RestoranMenu\XML\Menu.xml");

            XElement menu = XElement.Load(sr);

            var items = menu.Elements("item");
            foreach (var item in items)
            {
                string name = item.Element("name").Value;
                string category = item.Element("category").Value;
                string vegan = item.Element("vegan").Value;
                string weight = item.Element("weight").Value;
                double weight2 = Convert.ToDouble(weight.Split('g')[0]);
                string price = item.Element("price").Value;
                double price2 = Convert.ToDouble(price.Split('e')[0]);

                if (vegan == "Yes" && price2 <= 6)
                {
                    Console.WriteLine("Name: {0}", name);
                    Console.WriteLine("Category: {0}", category);
                    Console.WriteLine("Vegan: {0}", vegan);
                    Console.WriteLine("Weight: {0}", weight);
                    Console.WriteLine("Price: {0}", price);
                    Console.WriteLine();
                }
            }
        }
    }
}