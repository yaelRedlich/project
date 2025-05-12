using System;
using System.Collections.Generic;

namespace BO
{
    public class ProductInOrder
    {
        public int _productInOrderId;
        public string _productName;
        public double _basePrice;
        public int _quantity;
        public List<SaleInProduct> _saleList;
        public double _finalPrice;

        public ProductInOrder(int productInOrderId, string productName, double basePrice, int quantity, List<SaleInProduct> saleList)
        {
            _productInOrderId = productInOrderId;
            _productName = productName;
            _basePrice = basePrice;
            _quantity = quantity;
            _saleList = saleList;
            _finalPrice = basePrice*quantity;
        }

     //   public ProductInOrder() : this(0, "", 0.0, 0, new List<SaleInProduct>(), 0.0) { }
        public override string ToString() => Tools.ToStringProperty(this);


    }
}
