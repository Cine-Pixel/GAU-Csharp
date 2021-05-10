using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Xml.Linq;

namespace TestXML {
    public static class Client {
       static readonly HttpClient client = new HttpClient();

        public static async void post(string url, XDocument data) {

            try {
                var response = await client.PostAsync(url, new StringContent(data.ToString(), System.Text.Encoding.UTF8, "application/xml"));
                var responseBody = await response.Content.ReadAsStringAsync();
                XElement responseXml = XElement.Parse(responseBody);
                Console.WriteLine(responseXml);
            } catch {
                Console.WriteLine("Server error, try again later");
            }
        }
    }
}
