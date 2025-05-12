using DalApi;
using DO;
using System.Xml.Serialization;

namespace Dal
{
    internal class ProductImplementation : Iproduct
    {
        private static string filePath = @"..\xml\products.xml";

        private List<Product> LoadProducts()

        {

            if (!File.Exists(filePath))
            {
                return new List<Product>();
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                return (List<Product>)serializer.Deserialize(fs);
            }
        }



    private void SaveProducts(List<Product> products)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                
                serializer.Serialize(fs, products);
            }
        }

        public int Create(Product item)
        {
            item = item with { Id = Config.NextProductId };
            List<Product> products = LoadProducts();
            products.Add(item);
            SaveProducts(products);
            return item.Id;
        }

        public void Delete(int id)
        {
            List<Product> products = LoadProducts();
            Product? product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                throw new DalNotFoundId("Product not found");

            products.Remove(product);
            SaveProducts(products);
        }

        public Product? Read(int id)
        {
            List<Product> products = LoadProducts();
            Product? product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                throw new DalNotFoundId("Product not found");
            return product;
        }

        public List<Product?> ReadAll(Func<Product, bool>? filter = null)
        {
            var products = LoadProducts();
            return filter == null ? products.Cast<Product?>().ToList() : products.Where(filter).Cast<Product?>().ToList();
        }

        public void Update(Product item)
        {
            List<Product> products = LoadProducts();
            int index = products.FindIndex(p => p.Id == item.Id);
            if (index == -1)
                throw new DalNotFoundId("Product not found");

            products[index] = item;
            SaveProducts(products);
        }

        public Product? Read(Func<Product, bool>? filter)
        {
            List<Product> products = LoadProducts();
            if (filter == null)
                return products.FirstOrDefault();
            return products.FirstOrDefault(filter);
        }
    }
}
