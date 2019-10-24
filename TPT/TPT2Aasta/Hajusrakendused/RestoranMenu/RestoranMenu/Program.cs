using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace RestoranMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamReader sr = new StreamReader(@"C:\TPT\TPT\TPT2Aasta\Hajusrakendused\XML_Kodut66\Menu.xml");
            StreamReader sr = new StreamReader(@"D:\TPT\TPT\TPT2Aasta\Hajusrakendused\RestoranMenu\RestoranMenu\XML\Menu.xml");
            XElement menu = XElement.Load(sr);

            XmlTextReader reader = new XmlTextReader("Menu.xml");



            var items = menu.Elements("item");
            foreach (var item in items)
            {
                string name = item.Element("name").Value;
                string category = item.Element("category").Value;
                string vegan = item.Element("vegan").Value;
                double weight = XmlConvert.ToDouble(reader.ReadInnerXml());
                double price = XmlConvert.ToDouble(reader.ReadInnerXml());


                if (vegan == "Yes" & price < 5)
                {
                    Console.WriteLine("Name: {0}", name);
                    Console.WriteLine("Category: {0}", category);
                    Console.WriteLine("Vegan: {0}", vegan);
                    Console.WriteLine("Weight: {0}", weight.ToString());
                    Console.WriteLine("Price: {0}", price.ToString());
                }
                //else
                //{
                //    Console.WriteLine("Didn't find any food");
                //}

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}