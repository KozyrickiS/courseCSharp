using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XmlDoc
{
    class Program
    {
        static void Main(string[] args)
        {
            /*XmlDocument xDoc = new XmlDocument();
            xDoc.Load("users.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            XmlElement userElem = xDoc.CreateElement("user");
            XmlAttribute nameAttr = xDoc.CreateAttribute("name");
            XmlElement compElem = xDoc.CreateElement("company");
            XmlElement ageElem = xDoc.CreateElement("age");
            XmlText nameText = xDoc.CreateTextNode("Uno Doe");
            XmlText compText = xDoc.CreateTextNode("Facebook");
            XmlText ageText = xDoc.CreateTextNode("29");
            nameAttr.AppendChild(nameText);
            compElem.AppendChild(compText);
            ageElem.AppendChild(ageText);
            userElem.Attributes.Append(nameAttr);
            userElem.AppendChild(compElem);
            userElem.AppendChild(ageElem);
            xRoot.AppendChild(userElem);
            xDoc.Save("users.xml");

            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null)
                        Console.WriteLine(attr.Value);
                }
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "company")
                    {
                        Console.WriteLine("Company: {0}", childnode.InnerText);
                    }
                    if (childnode.Name == "age")
                    {
                        Console.WriteLine("Age: {0}", childnode.InnerText);
                    }
                }
                Console.WriteLine();
            }
            XmlNodeList childnodes = xRoot.SelectNodes("user");
            foreach (XmlNode n in childnodes)
            {
                Console.WriteLine(n.SelectSingleNode("@name").Value);
            }
            XmlNodeList childnodes1 = xRoot.SelectNodes("//user/company");
            foreach (XmlNode n in childnodes1)
            {
                Console.WriteLine(n.InnerText);
            }
            Console.ReadLine();*/

            XDocument document = new XDocument();
            XElement xiaomi = new XElement("Phone");
            XAttribute xiaomiNameAttr = new XAttribute("name", "Mi 8");
            XElement xiaomiCompEl = new XElement("company", "Xiaomi");
            XElement xiaomiPriceEl = new XElement("price", "200");
            xiaomi.Add(xiaomiNameAttr);
            xiaomi.Add(xiaomiCompEl);
            xiaomi.Add(xiaomiPriceEl);

            XElement samsung = new XElement("Phone");
            XAttribute samsNameAttr = new XAttribute("name", "s10");
            XElement samsCompEl = new XElement("company", "samsung");
            XElement samsPriceEl = new XElement("price", "400");
            samsung.Add(samsNameAttr);
            samsung.Add(samsCompEl);
            samsung.Add(samsPriceEl);

            XElement phones = new XElement("Phones");
            phones.Add(xiaomi);
            phones.Add(samsung);
            document.Add(phones);
            document.Save("phones.xml");

        }
    }
}
