using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Order
    {
        public bool favoriteCustomer { get; set; }
        public List<ProductInOrder> listProduct { get; set; }
        public double finalPrice { get; set; }
        public Order()
        {
            this.favoriteCustomer = false;
            this.listProduct = new List <ProductInOrder>();
            this.finalPrice = 0.0;
        }
        public Order (bool favoriteCustomer, List < ProductInOrder > listProduct, double finalPrice)
        {
            this.favoriteCustomer = favoriteCustomer;
            this.listProduct = listProduct;
            this.finalPrice = finalPrice;
        }
        public override string ToString() => Tools.ToStringProperty(this);


    }
}
