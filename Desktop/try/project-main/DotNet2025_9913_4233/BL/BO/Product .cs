using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Product
    {
        public int Id { get; set; }
        public string NameProduct { get; set; }
        public CategoryName Category { get; set; }
        public double Price { get; set; }
        public int QuantityInStock { get; set; }
        public Product()
        {
            Id = 0;
            NameProduct = "";
            Category = new CategoryName();
            Price = 0.0;
            QuantityInStock = 0;
        }

        public Product( string nameProduct, CategoryName category, double price, int quantityInStock)
        {
            NameProduct = nameProduct;
            Category = category;
            Price = price;
            QuantityInStock = quantityInStock;
        }
        public Product(int id ,string nameProduct, CategoryName category, double price, int quantityInStock)
        {
            Id = id;
            NameProduct = nameProduct;
            Category = category;
            Price = price;
            QuantityInStock = quantityInStock;
        }
        public override string ToString() => Tools.ToStringProperty(this);
    }
}
