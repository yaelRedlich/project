using BlApi;
using BO;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlIimplemetation
{
    internal class OrderImplementaion : BlApi.Iorder
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        void Iorder.DoOrder(Order order) 
        {
            try
            {
                foreach (var item in order.listProduct)
                {
                    DO.Product p = _dal.Product.Read(item._productInOrderId);
                    int quantity = p.QuantityInStock;
                    DO.Product p1 = p with { QuantityInStock = quantity - item._quantity };
                    _dal.Product.Update(p1);
                }
            }
            catch (DalNotFoundId ex)
            {
                throw new BlNotFoundId("There is no such ID in the system.", ex);
              
            }
        }
        public void CalcTotalPriceForProduct(BO.ProductInOrder productInOrder)
        {
            
            int count = 0;
            if (productInOrder._saleList.ToArray().Length == 0)
            {
               
                productInOrder._finalPrice = productInOrder._basePrice * productInOrder._quantity;
                count = productInOrder._quantity;
                return;
            }
            else
            {
                List<BO.SaleInProduct> mySales = new List<BO.SaleInProduct>();
                count = productInOrder._quantity;
                productInOrder._finalPrice = 0;
                foreach (var item in productInOrder._saleList)
                {
                    if (count == 0)
                        break;
                    if (count >= item._quantityForSale)
                    {
                        int amount = count / item._quantityForSale;
                        count = count % item._quantityForSale;
                        mySales.Add(item);
                        productInOrder._finalPrice += (amount * item._quantityForSale * productInOrder._basePrice) - amount * item._price;
                    }
                }
                productInOrder._finalPrice += count * productInOrder._basePrice;
                foreach (var item in mySales)
                {
                    productInOrder._saleList.Add(item);
                }
            }
        }

        public void SearchSaleForProduct(ProductInOrder product, bool custumerFavorite)
        {
            product._saleList = _dal.Sale
                .ReadAll(s => s._productId == product._productInOrderId
                           && s._dateStartSale <= DateTime.Now
                           && s._dateEndSale >= DateTime.Now
                           && s._quantityForSale <= product._quantity
                           && (s._isForClubMembersOnly ? custumerFavorite : true))
                .OrderBy(x => x._salePrice / x._quantityForSale)
                .Select(s => new SaleInProduct(s.id, s._quantityForSale, (int)s._salePrice, s._isForClubMembersOnly))
                .ToList();
        }

        public void CalcTotalPrice(BO.Order order)
        {
            double totalPrice = 0;
            order.listProduct.ForEach((p) =>
            {
                totalPrice += p._finalPrice;
            });
            order.finalPrice = totalPrice;  
        }

        public List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int productId, int quantity)
        {
            if (quantity < 1)
            {
                throw new BlInvalidQuantityException("Invalid Quantity");
            }
            DO.Product p;
            try
            {
                p = _dal.Product.Read(productId);
            }
            catch (DalNotFoundId ex)
            {
                throw new BlNotFoundId("There is no such ID in the system.", ex);
             
            }
            ProductInOrder productInOrder = order.listProduct.FirstOrDefault(o => o._productInOrderId == productId);

            if (productInOrder != null)
            {
                if (productInOrder._quantity + quantity > p.QuantityInStock)
                {
                    throw new BlInvalidQuantityException("Invalid Quantity");
                }
                productInOrder._quantity += quantity;
            }
            else
            {
                if (quantity > p.QuantityInStock)
                    throw new BlOutOfStockException("Invalid Quantity");
                ProductInOrder productInOrder1 = new ProductInOrder(productId, p.NameProduct, p.Price, quantity, new List<SaleInProduct>());
                productInOrder = productInOrder1;
                order.listProduct.Add(productInOrder); 

            }

            SearchSaleForProduct(productInOrder, order.favoriteCustomer);
            CalcTotalPriceForProduct(productInOrder);
            CalcTotalPrice(order);

            return productInOrder._saleList;
        }

       
    }
}
