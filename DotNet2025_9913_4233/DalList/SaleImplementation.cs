
using DO;
using DalApi;
namespace Dal;

using System.Reflection;
using Tools;

internal class SaleImplementation: Isale
{
  public  int Create(Sale item)
    {
        Sale s = item with { id = DataSource.Config.StaticId };
        if (DataSource.sales.Any(sale => sale.id == s.id))
            throw new DalIdExist("⚠️ שגיאה: לא ניתן להוסיף את המבצע. מבצע עם אותם פרטים כבר קיים במערכת.\r\nאנא בדוק את הנתונים ונסה שוב או צור קשר עם התמיכה הטכנית.");
        DataSource.sales.Add(s);
        LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName," המבצע התוסף בהצלחה");
        return item._productId;

    }
  public  Sale? Read(int id)
    {
        Sale s = DataSource.sales.FirstOrDefault(sale => sale._productId == id);
        if (s != null)
        {
            return s;
            LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName, "קריאת המבצעים התבצע בהצלחה");

        }
        else
            throw new DalNotFoundId("פג תוקף המבצע");


    }
  public  Sale? Read(Func<Sale, bool> filter)
    {
        LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName, "קריאת המבצעים התבצע בהצלחה");
        return DataSource.sales.FirstOrDefault(filter);


    }
  public   List<Sale> ReadAll(Func<Sale, bool>? filter = null)
    {
        LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName, "קריאת המבצעים התבצע בהצלחה");
        if (filter == null)
            return DataSource.sales;
        return DataSource.sales.Where((c) => filter(c)).ToList();
    }
    public  void Update(Sale item)
    {
        if (Read(item._productId) != null)
        {
            Delete(item._productId);
            Create(item);
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

    
}

