using DO;
using DalApi;
using System.Reflection;
using Tools;

namespace Dal;

internal class CustomerImplementation:Icustomer
{
    public int Create(Customer item)
    {
     if( DataSource.customers.Any(customer =>  customer._idCard == item._idCard))
                throw new DalIdExist("⚠️ שגיאה: לא ניתן להוסיף את המשתמש. משתמש עם אותם פרטים כבר קיים במערכת.\r\nאנא בדוק את הנתונים ונסה שוב או צור קשר עם התמיכה הטכנית.");

        DataSource.customers.Add(item);
        LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName, "הלקוח נוצר בהצלחה");

        return item._idCard;
    }
    public Customer? Read(int id)
    {
        Customer c=DataSource.customers.FirstOrDefault(item => item._idCard == id);
        if (c != null)
        {
            return c;
            LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName, "הלקוח נקרא בהצלחה");

        }
        else
            throw new DalNotFoundId("לקוח זה לא קיים במערכת");
    }
   public Customer? Read(Func<Customer, bool> filter)
    {
        LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName, "המוצר נקרא בהצלחה");
        return DataSource.customers.FirstOrDefault(filter);

    }
    public List<Customer> ReadAll(Func<Customer, bool>?filter=null)
    {
        LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName, "המוצר נקרא בהצלחה");
        if (filter==null)
            return DataSource.customers;
        return DataSource.customers.Where((c)=>filter(c)).ToList();
    }
    public void Update(Customer item)
    {
        if (Read(item._idCard) != null)
        {
            Delete(item._idCard);
            Create(item);
            LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName, "הלקוח עודכן בהצלחה");

        }
    }
    public void Delete(int id)
    {
        if (Read(id) != null)
        {
            DataSource.customers.Remove(Read(id));
            LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName, "הלקוח נמחק בהצלחה");

        }
    }
   
}
