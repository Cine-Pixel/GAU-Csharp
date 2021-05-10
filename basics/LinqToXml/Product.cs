using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXml {
    public class Product {
        public string Name { get; set;}
        public string Description{ get; set; }
        public string Owner{ get; set; }
        public string Cost{ get; set; }
        public string Shipping{ get; set; }

        public Product(string name, string desc, string owner, string cost, string ship) {
            Name = name;
            Description= desc;
            Owner = owner;
            Cost = cost;
            Shipping = ship;
        }

        public XDocument GetXml() {
            XDocument xmlDocument = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("product", 
                    new XElement("name", Name),
                    new XElement("description", Description),
                    new XElement("owner", Owner),
                    new XElement("cost", Cost),
                    new XElement("shipping", Shipping)
                )
            );
            return xmlDocument;
        }
    }
}
