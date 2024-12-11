using DO;
using DalApi;
using System.Net;
using System.Security.Cryptography;


namespace DalTest;

public static  class Initialization
{
private static IDal s_dal ;

    private static void createCustomer()
    {
        s_dal.Customer.Create(new Customer(123, "0534161926","chazon david 21", "tami"));
    }
    private static void createSale()
    {
        s_dal.Sale.Create(new Sale(0,456, 5, 56.9, true, new DateTime(), new DateTime()));
    }

    private static void createProduct()
    {
        s_dal.Product.Create(new Product(456,
    "בושם",
     CategoryName.CLASSIC_FRAGRANCES,
    300,
     9));
    }
    public static  void initialize(IDal dal)
    {
      s_dal = dal;  
        createCustomer();
        createProduct();
        createSale ();
    }



}
