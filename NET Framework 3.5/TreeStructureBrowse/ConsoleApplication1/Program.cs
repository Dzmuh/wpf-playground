using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement xml = XElement.Load(@"..\..\XMLFile1.xml");
            Console.WriteLine(xml);
            Console.Read();
        }
    }
}
