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
    internal class ProductImplementaion : BlApi.IProduct
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;

        public int Create(BO.Product item)
        {
            try
            {
                return _dal.Product.Create(new DO.Product(item._id, item._nameProduct, (DO.CategoryName)(object)item._category, item._price, item._quantityInStock));

            }
            catch (DO.DalIdExist ex)
            {
                throw new BlIdExist("id doesnt exist", ex);
                throw new DalIdExist("id doesnt exist");
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
                return new BO.Product(p._id, p._nameProduct, (CategoryName)(int)p._category, p._price, p._quantityInStock,new List<SaleInProduct> ());

            }
            catch (DO.DalIdExist ex)
            {
                throw new BlIdExist("id doesnt exist", ex);
                throw new DalIdExist("id doesnt exist");
            }
        }

        public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
        {

            List<DO.Product?> p = _dal.Product.ReadAll();
            List<BO.Product> ListProducts = p.Select(c => new BO.Product(c._id, c._nameProduct, (CategoryName)(int)c._category, c._price, c._quantityInStock, new List<SaleInProduct>())).ToList();
            if (filter != null)
                return ListProducts;
            else
                return ListProducts.Where(filter).ToList();

        }
        public BO.Product? Read(Func<BO.Product, bool> filter)
        {
            List<BO.Product> ProductsBo = ReadAll();
            return ProductsBo.FirstOrDefault(c => filter(c));
        }

        public void Update(BO.Product item)
        {
            try
            {
                _dal.Product.Create(new DO.Product(item._id, item._nameProduct, (DO.CategoryName)(int)item._category, item._price, item._quantityInStock));

            }
            catch (DalIdExist ex)
            {
                throw new BlIdExist("id doesnt exist", ex);
                throw new DalIdExist("id doesnt exist");
            }
            catch (DalNotFoundId ex)
            {
                throw new BlNotFoundId("not found id", ex);
                throw new DalNotFoundId("not found id");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _dal.Product.Delete(id);
            }
            catch (DO.DalIdExist ex)
            {
                throw new BlIdExist("id doesnt exist", ex);
                throw new DalIdExist("id doesnt exist");
            }
        }
        public void activeSales(ProductInOrder product, bool favorite)
        {
            product._saleList = _dal.Sale.ReadAll(s => s._productId == product._productInOrderId && s._dateStartSale <= DateTime.Now && s._dateEndSale >= DateTime.Now && s._quantityForSale <= product._quantity && (favorite || (s._isForClubMembersOnly == true)))
                    .Select(s => new SaleInProduct(s.id, s._quantityForSale, (int)s._salePrice, s._isForClubMembersOnly)).OrderBy(x => x._price / x._quantityForSale).ToList();
        }

    }
}



