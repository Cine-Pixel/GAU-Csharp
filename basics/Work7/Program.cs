using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work7 {
    class Program {
        static void Main(string[] args) {
            double affordablePrice = 1500;
            List<Product> products = new List<Product>() { 
                new Product{ Name = "Fedora", Category = "Collector's item", Owner="Abraham Lincoln", Price=1256.23 },
                new Product{ Name = "Old Glasses", Category = "Collector's item", Owner="Andrew Jackson", Price=1540.66 },
                new Product{ Name = "Toupee", Category = "Useless", Owner="Donald Trump", Price=0.15 },
                new Product{ Name = "Old Flag", Category = "Decoratory", Owner="George Washington", Price=540.34 },
                new Product{ Name = "Declaration of Independence", Category = "Museum item", Owner="Thomas Jefferson", Price=5540.66 },
                new Product{ Name = "Newer glasses", Category = "Accessories", Owner="Theodore Roosevelt", Price=140.66 }
            };

            IEnumerable<Product> collectorsItems = from product in products
                                  where product.Category.Equals("Collector's item")
                                  select product;
            Console.WriteLine("Collector's items");
            foreach(Product item in collectorsItems) {
                Console.WriteLine($"Product: {item.Name}; Category: {item.Category}; Owner: {item.Owner}; Price: {item.Price}");
            }
            Console.WriteLine();


            IEnumerable<Product> affordableProducts = products.Where(pd => pd.Price <= affordablePrice);
            Console.WriteLine("Affordable items");
            foreach(Product item in affordableProducts) {
                Console.WriteLine($"Product: {item.Name}; Category: {item.Category}; Owner: {item.Owner}; Price: {item.Price}");
            }
            Console.WriteLine();


            IEnumerable<Product> orderedProducts = products
                .OrderBy(pd => pd.Name)
                .ThenBy(pd => pd.Price);
            Console.WriteLine("Ordered items");
            foreach(Product item in orderedProducts) {
                Console.WriteLine($"Product: {item.Name}; Category: {item.Category}; Owner: {item.Owner}; Price: {item.Price}");
            }
            Console.WriteLine();


            IEnumerable<Product> selected = products
                .Select(pd => new Product { Name = pd.Name, Owner = pd.Owner });
            Console.WriteLine("Custom selected items");
            foreach(Product item in selected) {
                Console.WriteLine($"Product: {item.Name}; Owner: {item.Owner};");
            }
            Console.WriteLine();


            bool areAllProductsUseless = products.All(pd => pd.Category.Equals("useless"));
            if (areAllProductsUseless) Console.WriteLine("All items are useles");
            else Console.WriteLine("Not all items are useless");
            Console.WriteLine();


            bool areAnyMuseumItems = products.Any(pd => pd.Category.Equals("Museum item"));
            if (areAnyMuseumItems) Console.WriteLine("There are museum items as well");
            else Console.WriteLine("There are't any museum items");
            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
