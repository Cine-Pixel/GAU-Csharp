using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Xml.Linq;

namespace TestXML {
    class Program {
        static void Main(string[] args) {
            //string XMLEndpoint = "https://run.mocky.io/v3/d1b390ce-4b3b-42d2-8150-9ed039004f2d";
            string XMLEndpoint = "http://127.0.0.1:8000/api/cart/";
            XElement products = XElement.Load(XMLEndpoint);

            //IEnumerable<XElement> data = products.Descendants("product").Where(pd => (float)pd.Element("cost") > 300);
            IEnumerable<XElement> data = products.Descendants("object")
                .Where(pd => {
                    var fields = pd.Descendants("field");
                    var productCosts = fields.FirstOrDefault(fd => (string)fd.Attribute("name") == "cost");
                    return (float)productCosts > 300;
                });
                

            foreach (XElement product in data) {
                IEnumerable<XElement> productFields = product.Descendants("field");
                foreach(XElement field in productFields) {
                    Console.WriteLine(field.Value);
                }
            }

            XDocument xmlDocument = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("product", 
                    new XElement("name", "New Fedora"),
                    new XElement("description", "New Fedora description"),
                    new XElement("owner", "Me"),
                    new XElement("cost", "20.12"),
                    new XElement("shipping", "2.2")
                )
            );

            Client.post(XMLEndpoint, xmlDocument);

            Console.ReadLine();
        }
    }
}
