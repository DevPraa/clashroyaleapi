using ClashRoyaleAPI;
using ClashRoyaleAPI.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace TestApi
{
    class Program
    {
        static  void Main(string[] args)
        {
            Test();
            Console.ReadKey();
        }

        static async void Test()
        {
            XDocument xdoc = new XDocument(
                new XElement("Translation",
                    new XElement("Cards",
                        new XElement("Card",
                            new XAttribute("Name","Sceletons"),
                            new XAttribute("Rare", "Common"),
                            new XAttribute("Cost", "3"),
                            new XAttribute("Type", "Troop"),
                            new XAttribute("StartLvl", "1")
                            )),
                    new XElement("Controls",
                        new XElement("Control",
                            new XAttribute("Name", "Sceletons"),
                            new XAttribute("Tag", "Common"),
                            new XAttribute("Text", "3")
                            )))
                            );

            xdoc.Save("En_en.xml");
            Console.ReadKey();
        }
    }
}
