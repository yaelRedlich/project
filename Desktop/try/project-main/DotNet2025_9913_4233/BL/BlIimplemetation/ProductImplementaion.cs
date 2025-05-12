using BlApi;
using BO;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BlIimplemetation
{
    public class ProductImplementaion : BlApi.IProduct
    {
    
        private DalApi.IDal _dal = DalApi.Factory.Get;

        public int Create(BO.Product item)
        {
            try
            {
                return _dal.Product.Create(new DO.Product(item.Id, item.NameProduct, (DO.CategoryName)(object)item.Category, item.Price, item.QuantityInStock));

            }
            catch (DO.DalProductIdExist ex)
            {
                throw new BlProductIdExist("The product is out of stock.", ex);
            }
           
            catch (DO.DalIdExist ex)
            {
                throw new BlIdExist("The ID already exists in the system.", ex);
            }
        }
        public bool isExist(int id)
        {
            throw new NotImplementedException();
        }

        public BO.Product? Read(int id)
        {
            try
            {
                DO.Product p = _dal.Product.Read(id);
                if (p == null)
                    return null;
                return new BO.Product(p.Id, p.NameProduct, (CategoryName)(int)p.Category, p.Price, p.QuantityInStock);

            }
            catch (DO.DalNotFoundId ex)
            {
                throw new BlNotFoundId("There is no such ID in the system.", ex);
            }
        }

        public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
        {
            List<DO.Product?> p = _dal.Product.ReadAll();
            List<BO.Product> ListProducts =p.Where(c => c != null).Select(c => new BO.Product(c.Id, c.NameProduct, (CategoryName)(int)c.Category, c.Price, c.QuantityInStock)).ToList();
            if (filter == null)
                return ListProducts;
            Console.WriteLine(ListProducts);
            return ListProducts.Where(filter).ToList();

        }


        public BO.Product? Read(Func<BO.Product, bool> predicate)
        {

            List<BO.Product> ProductsBo = ReadAll();
            return ProductsBo.FirstOrDefault(c => predicate(c));
        }


        public void Update(BO.Product item)
        {
            try
            {
                _dal.Product.Update(new DO.Product(item.Id, item.NameProduct, (DO.CategoryName)(int)item.Category, item.Price, item.QuantityInStock));

            }
            catch (DO.DalProductIdExist ex)
            {
                throw new BlProductIdExist("The product is out of stock.", ex);
            }
            catch (DalIdExist ex)
            {
                throw new BlIdExist("The ID already exists in the system.", ex);
            }
            catch (DalNotFoundId ex)
            {
                throw new BlNotFoundId("There is no such ID in the system.", ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                _dal.Product.Delete(id);
            }
            catch (DO.DalNotFoundId ex)
            {
                throw new BlNotFoundId("There is no such ID in the system.", ex);
             
            }
        }
        public void activeSales(ProductInOrder product, bool favorite)
        {
            product._saleList = _dal.Sale.ReadAll(s => s._productId == product._productInOrderId && s._dateStartSale <= DateTime.Now && s._dateEndSale >= DateTime.Now && s._quantityForSale <= product._quantity && (favorite || (s._isForClubMembersOnly == true)))
                    .Select(s => new SaleInProduct(s.id, s._quantityForSale, (int)s._salePrice, s._isForClubMembersOnly)).OrderBy(x => x._price / x._quantityForSale).ToList();
        }

    }
}



