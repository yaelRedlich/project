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
        Console.WriteLine("b createCustomer");
        try
        {
            s_dal.Customer.Create(new Customer(123, "0534161926", "chazon david 21", "tami"));
            Console.WriteLine("a createCustomer");

        }
        catch (Exception ex) {
            Console.WriteLine("not createCustomer");

        }

    }
    private static void createSale()
    {
        try
        {
            s_dal.Sale.Create(new Sale(0, 123, 5, 56.9, true, new DateTime(), new DateTime()));

        }
        catch (Exception ex) {
            Console.WriteLine("catch");
        }
    }

    private static void createProduct()
    {
        s_dal.Product.Create(new Product(456,
    "בושם",
     CategoryName.CLASSIC_FRAGRANCES,
    300,
     9));
    }
    public static  void initialize()
    {
        Console.WriteLine("rthg");
        s_dal = DalApi.Factory.Get;
        createCustomer();
        Console.WriteLine("createCustomer s");
        createProduct();
        createSale ();
    }



}
