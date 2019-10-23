using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RestoranMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\TPT\TPT\TPT2Aasta\Hajusrakendused\XML_Kodut66\Menu.xml");
            XElement contactBook = XElement.Load(sr);
            Console.WriteLine(contactBook);
            Console.ReadKey();
        }
    }
}
