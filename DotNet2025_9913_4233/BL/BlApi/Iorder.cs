using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi
{
    public interface Iorder
    {
        List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int productId, int quantity);
        void CalcTotalPriceForProduct(BO.ProductInOrder productInOrder);
        void  CalcTotalPrice(BO.Order order);
        void DoOrder(BO.Order order);
        void SearchSaleForProduct(ProductInOrder product, bool custumerFavorie);
        
    }
}
