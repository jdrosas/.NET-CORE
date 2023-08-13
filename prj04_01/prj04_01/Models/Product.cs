namespace prj04_01.Models
{
    public class Product
    {
        public string? Name { get; set; }
        public decimal? Price { get; set; }

        public static Product[] GetProduct()
        {

            Product?[] productArray = {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price = 48.95M},
                new Product {Name = "Soccer ball", Price = 19.50M},
                new Product {Name = "Corner flag", Price = 34.95M}
            };

            return productArray;

            //Product kayak = new Product
            //{
            //    Name = "Kayak" + 275M.ToString(),
            //    Price = 275M
            //};

            //Product lifejacket = new Product
            //{
            //    Name = "Lifejacket",
            //    Price = 48.95M
            //};

            //return new Product[] { kayak, lifejacket, null };
  
        }
    }
}
