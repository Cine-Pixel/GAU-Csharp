using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXml {
    public static class FormUtils {
        public static IEnumerable<XElement> data;
        public static List<Product> LoadData(string url) {
            data = Client.Get(url);
            List<Product> productsDisplaySource = new List<Product>();

            foreach (XElement product in data) {
                IEnumerable<XElement> productFields = product.Descendants("field");
                List<string> values = new List<string>();
                foreach(XElement field in productFields) {
                    values.Add(field.Value);
                }
                productsDisplaySource.Add(new Product(values[0], values[1], values[2], values[3], values[4]));
            }
            return productsDisplaySource;
        }
        public static List<Product> ApplyFilter(float limit) {
            List<Product> productsDisplaySource = new List<Product>();
            XElement oldData = Client.products;
            IEnumerable<XElement> newdata = oldData.Descendants("object")
                .Where(pd => {
                     var fields = pd.Descendants("field");
                     var productCosts = fields.FirstOrDefault(fd => (string)fd.Attribute("name") == "cost");
                     return (float)productCosts < limit;
                 });

            foreach (XElement product in newdata) {
                IEnumerable<XElement> productFields = product.Descendants("field");
                List<string> values = new List<string>();
                foreach(XElement field in productFields) {
                    values.Add(field.Value);
                }
                productsDisplaySource.Add(new Product(values[0], values[1], values[2], values[3], values[4]));
            }

            return productsDisplaySource;
        }
        public static List<Product> ApplyMaxFilter() {
            List<Product> productsDisplaySource = new List<Product>();
            XElement oldData = Client.products;
            IEnumerable<XElement> newdata = oldData.Descendants("object")
                .Where(pd => {
                     var fields = pd.Descendants("field");
                     var productCosts = fields.FirstOrDefault(fd => (string)fd.Attribute("name") == "cost");
                     return (float)productCosts > 10000;
                 });

            foreach (XElement product in newdata) {
                IEnumerable<XElement> productFields = product.Descendants("field");
                List<string> values = new List<string>();
                foreach(XElement field in productFields) {
                    values.Add(field.Value);
                }
                productsDisplaySource.Add(new Product(values[0], values[1], values[2], values[3], values[4]));
            }

            return productsDisplaySource;
        }
        public static List<Product> ApplyMinFilter() {
            List<Product> productsDisplaySource = new List<Product>();
            XElement oldData = Client.products;
            IEnumerable<XElement> newdata = oldData.Descendants("object")
                .Where(pd => {
                     var fields = pd.Descendants("field");
                     var productCosts = fields.FirstOrDefault(fd => (string)fd.Attribute("name") == "cost");
                     return (float)productCosts < 10;
                 });

            foreach (XElement product in newdata) {
                IEnumerable<XElement> productFields = product.Descendants("field");
                List<string> values = new List<string>();
                foreach(XElement field in productFields) {
                    values.Add(field.Value);
                }
                productsDisplaySource.Add(new Product(values[0], values[1], values[2], values[3], values[4]));
            }

            return productsDisplaySource;
        }
    }
}
