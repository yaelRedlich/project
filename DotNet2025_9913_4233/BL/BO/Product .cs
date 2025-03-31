using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public record Product(int _id, string _nameProduct, CategoryName _category, double _price, int _quantityInStock , List< SaleInProduct> saleList)

    {

        public Product() : this(0, "", new CategoryName(), 0.0, 0,new List<SaleInProduct>())
        {
        }
        public override string ToString() => Tools.ToStringProperty(this);

    }
}
