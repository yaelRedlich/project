using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class SaleInProduct
    {
        public int _saleId;
        public int _quantityForSale;
        public int _price;
        public bool IsSaleForAllCustomer;
        public SaleInProduct(int saleId, int quantityForSale, int price, bool isSaleForAllCustomer)
        {
            _saleId = saleId;
            _quantityForSale = quantityForSale;
            _price = price;
            IsSaleForAllCustomer = isSaleForAllCustomer;
        }

        public SaleInProduct() : this(0, 0, 0, false) { }
        public override string ToString() => Tools.ToStringProperty(this);

    }

}
