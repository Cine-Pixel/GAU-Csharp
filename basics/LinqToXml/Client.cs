using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Xml.Linq;

namespace LinqToXml {
    public static class Client {
        static readonly HttpClient client = new HttpClient();
        public static XElement products;
        

        public static async void Post(string url, XDocument data) {

            try {
                var response = await client.PostAsync(url, new StringContent(data.ToString(), System.Text.Encoding.UTF8, "application/xml"));
                var responseBody = await response.Content.ReadAsStringAsync();
                XElement responseXml = XElement.Parse(responseBody);
            } catch {
                throw new Exception("Server error, try again later");
            }
        }

        public static IEnumerable<XElement> Get(string url) {
            products = XElement.Load(url);

            IEnumerable<XElement> data = products.Descendants("object");

            return data;
                
        }
    }
}
