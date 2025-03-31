using BlApi;
using BO;
using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BlIimplemetation
{

    internal class SaleImplementation : BlApi.Isale
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public int Create(BO.Sale s)
    {
        DO.Sale SaleDo = new DO.Sale(s.id, s._productId, s._quantityForSale, s._salePrice, s._isForClubMembersOnly, s._dateStartSale, s._dateEndSale);
        try
        {
            return _dal.Sale.Create(SaleDo);
        }
        catch (DalIdExist ex)
        {
            throw new BlIdExist("id doesnt exist", ex);
            throw new DalIdExist("id doesnt exist");
        }
    }

    public void Delete(int id)
    {
        try
        {
            _dal.Sale.Delete(id);
        }
        catch (DalNotFoundId ex)
        {
            throw new BlNotFoundId("not found id", ex);
            throw new DalNotFoundId("not found id");
        }

    }


    public BO.Sale? Read(int id)
    {
        try
        {
            DO.Sale doSale = _dal.Sale.Read(id);
            if (doSale == null)
                return null;
            return new BO.Sale(doSale.id, doSale._productId, doSale._quantityForSale, doSale._salePrice, doSale._isForClubMembersOnly, doSale._dateStartSale, doSale._dateEndSale
    );
        }
        catch (DalNotFoundId ex) {
            throw new BlNotFoundId("not found id", ex);
            throw new DalNotFoundId("not found id");
        }

    }

    public List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null)
    {
        List<DO.Sale> SalesDO = _dal.Sale.ReadAll();
        List<BO.Sale> SalesBO = SalesDO.Select(s => new BO.Sale(s.id, s._productId, s._quantityForSale, s._salePrice, s._isForClubMembersOnly, s._dateStartSale, s._dateEndSale)).ToList();

        if (filter == null)
            return SalesBO;
        return SalesBO.Where(filter).ToList();
    }
    public void Update(BO.Sale s)
    {
        try
        {
            _dal.Sale.Update(new DO.Sale(s.id, s._productId, s._quantityForSale, s._salePrice, s._isForClubMembersOnly, s._dateStartSale, s._dateEndSale));

        }
        catch (DalIdExist ex)
        {
            throw new BlIdExist("id doesnt exist", ex);
            throw new DalIdExist("id doesnt exist");
        }
        catch (DalNotFoundId ex) {
            throw new BlNotFoundId("not found id", ex);
            throw new DalNotFoundId("not found id");
        }
    }

   public BO.Sale? Read(Func<BO.Sale, bool> filter)
    {
        List<BO.Sale> SalesBo = ReadAll();
        return SalesBo.FirstOrDefault(c => filter(c));
    }

}
}