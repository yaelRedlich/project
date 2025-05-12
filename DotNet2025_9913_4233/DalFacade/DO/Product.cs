
using System.Xml.Serialization;


namespace DO
{
    [XmlRoot("Product")]

    public record Product
    {
        public int Id { get; set; }
        public string NameProduct { get; set; }
        [XmlElement("CategoryName")]
        public CategoryName Category { get; set; }
        public double Price { get; set; }
        public int QuantityInStock { get; set; }

        public Product() { }

        public Product(int id, string nameProduct, CategoryName category, double price, int quantityInStock)
        {
            Id = id;
            NameProduct = nameProduct;
            Category = category;
            Price = price;
            QuantityInStock = quantityInStock;
        }

        public Product(int id) : this(id, "", new CategoryName(), 0.0, 0) { }
    }
}
