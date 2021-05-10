using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Xml.Linq;

namespace TestXML {
    class Program {
        static void Main(string[] args) {
            string XMLEndpoint = "https://run.mocky.io/v3/0cbafa56-dd3a-41aa-9a59-4d746ab0817e";
            XElement products = XElement.Load(XMLEndpoint);

            //IEnumerable<XElement> data = products.Descendants("product")
            //    .Where(pd => (float)pd.Element("cost") > 300);

            IEnumerable<XElement> data = from pd in products.Descendants("product")
                                         where (float)pd.Element("cost") > 300
                                         orderby (string)pd.Element("name")
                                         select pd;

            foreach(XElement product in data) {
                Console.WriteLine(product.Element("name")); 
                Console.WriteLine(product.Element("description").Value); 
                Console.WriteLine(product.Element("owner").Value); 
                Console.WriteLine(product.Element("cost").Value); 
                Console.WriteLine((string)product.Element("shipping"));
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
