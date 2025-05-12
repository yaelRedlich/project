using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi
{
    public interface IProduct
    {
        int Create(BO.Product item);
        BO.Product? Read(int id);
        List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null);
        BO.Product? Read(Func<BO.Product, bool> filter);

        void Update(BO.Product item);
        void Delete(int id);
       void activeSales (ProductInOrder productId ,bool favorite);

    }
}
