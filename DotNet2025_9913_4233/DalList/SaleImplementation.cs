
using DO;
using DalApi;
using System.Reflection;
using Tools;
namespace Dal;

internal class SaleImplementation : Isale
{
    public int Create(Sale item)
    {

        //  Sale s = item with { id = DataSource.Config.StaticId };
        Sale s = new Sale(DataSource.Config.StaticId, item._productId, item._quantityForSale, item._salePrice, item._isForClubMembersOnly, item._dateStartSale, item._dateEndSale);

        if (DataSource.sales.Any(sale => sale.id == s.id))
           throw new DalIdExist("⚠️ שגיאה: לא ניתן להוסיף את המבצע. מבצע עם אותם פרטים כבר קיים במערכת.\r\nאנא בדוק את הנתונים ונסה שוב או צור קשר עם התמיכה הטכנית.");
        if(!DataSource.products.Any(p => p.Id== item._productId))
            throw new DalProductIdExist("⚠️ שגיאה: לא ניתן להוסיף את המבצע. לא קיים כזה מצבע במערכת.\r\nאנא בדוק את הנתונים ונסה שוב או צור קשר עם התמיכה הטכנית.");
        DataSource.sales.Add(s);
        LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName, " המבצע התוסף בהצלחה");
        return item._productId;

    }
    public Sale? Read(int _id)
    {
        Sale s = DataSource.sales.FirstOrDefault(sale => sale.id == _id);
        if (s != null)
        {
            LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName, "קריאת המבצעים התבצע בהצלחה");
            return s;

        }
        else
            throw new DalNotFoundId(" פג תוקף המבצע" + _id);


    }
    public Sale? Read(Func<Sale, bool> filter)
    {
        LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName, "קריאת המבצעים התבצע בהצלחה");
        return DataSource.sales.FirstOrDefault(filter);


    }
    public List<Sale> ReadAll(Func<Sale, bool>? filter = null)
    {
        LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName, "קריאת המבצעים התבצע בהצלחה");
        if (filter == null)
            return DataSource.sales;
        return DataSource.sales.Where((c) => filter(c)).ToList();
    }
    public void Update(Sale item)
    {
        if (Read(item.id) != null)
        {
            int index = DataSource.sales.FindIndex(sale => sale.id == item.id);
            if (index == -1)
                throw new DalNotFoundId("customer not found");
            DataSource.sales[index] = item;
        }

        LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName, "במבצע עודכן בהצלחה");


    }
    public void Delete(int id)
    {
        if (Read(id) != null)
        {
            DataSource.sales.Remove(Read(id));
            LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName, "במבצע נמחק בהצלחה");

        }
    }
}




