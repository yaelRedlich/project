using DO;
using DalApi;
using System.Reflection;
using Tools;
using Dal;

internal class ProductImplementation : Iproduct
{

    public int Create(Product item)
    {
        Product p = item with { Id = DataSource.Config.StaticId };
        if (DataSource.products.Any(product => product.Id == p.Id))
        {
            throw new DalIdExist("⚠️ שגיאה: לא ניתן להוסיף את המוצר. מוצר עם אותם פרטים כבר קיים במערכת.\r\nאנא בדוק את הנתונים ונסה שוב או צור קשר עם התמיכה הטכנית.");
        }
         DataSource.products.Add(p);
        LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName, "המוצר נוצר בהצלחה");

        return p.Id;

    }
    public Product? Read(int id)
    {
        Product p = DataSource.products.FirstOrDefault(product => product.Id == id);
        if (p != null)
        {
            LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName, "המוצר נקרא בהצלחה");

            return p;

        }
        else
            throw new DalNotFoundId("מוצר זה לא קיים");
    }
    public Product? Read(Func<Product, bool> filter)
    {
        LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName, "המוצר נקרא בהצלחה");
        return DataSource.products.FirstOrDefault(filter);
    }
    public List<Product> ReadAll(Func<Product, bool>? filter = null)
    {
        LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName, "המוצר נקרא בהצלחה");

        if (filter == null)
            return DataSource.products;
        return DataSource.products.Where((c) => filter(c)).ToList();
    }
    public void Update(Product item)
    {
        int index = DataSource.products.FindIndex(product => product.Id == item.Id);

        if (index == -1)
            throw new DalNotFoundId($"Product with Id {item.Id} not found");

        DataSource.products[index] = item;
        LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName, "המוצר עודכן בהצלחה");
    }

    public void Delete(int id)
    {
        if (Read(id) != null)
        {
            
            DataSource.products.Remove(Read(id));
             LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName, "המוצר נמחק בהצלחה");

        }
    }
}
