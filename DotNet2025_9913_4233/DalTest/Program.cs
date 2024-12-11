using Dal;
using DalApi;
using DalTest;
using DO;
using System.Numerics;
using System.Runtime.InteropServices;
using Tools;

public class Program
{
    private static IDal s_dal = new DalListClass();

    public static void showMenu()
    {
        int entity=0;
        Console.WriteLine("for customer press 1");
        Console.WriteLine("for product press 2");
        Console.WriteLine("for Sale press 3");
        Console.WriteLine("for clear log folder prees 4");

        try
        {
            entity = int.Parse(Console.ReadLine());
        }
        catch (Exception e){
            return;
        }


        switch (entity)
        {
            case 1:
                ICrud<Customer> c = s_dal.Customer;
                showSubMenu(c, entity);
                break;
            case 2:
                ICrud<Product> p = s_dal.Product;
                showSubMenu(p, entity);
                break;
            case 3:
                ICrud<Sale> s = s_dal.Sale;
                showSubMenu(s, entity);
                break;
            case 4:
                LogManager.cleanLog();
                break;
            default:   Console.WriteLine("your press is not valid");break;

        }
    }

    private static void createCustomer()
    {

        s_dal.Customer.Create(createEntityCustomer());
    }
    private static Customer createEntityCustomer()
    {
        Console.WriteLine("insert id");
        int _idCard = int.Parse(Console.ReadLine());
        Console.WriteLine("insert phone");
        string _phone = Console.ReadLine();
        Console.WriteLine("insert address");
        string _address = Console.ReadLine();
        Console.WriteLine("insert customerName");
        string _customerName = Console.ReadLine();
        return new Customer(_idCard, _phone, _address, _customerName);
    }
    private static void createProduct()
    {
        s_dal.Product.Create(createEntityProduct());
    }
    private static Product createEntityProduct()
    {
        Console.WriteLine("insert id");
        int _id = int.Parse(Console.ReadLine());
        Console.WriteLine("insert name of product");
        string _nameProduct = Console.ReadLine();
        Console.WriteLine("insert price");
        double _price = double.Parse(Console.ReadLine());
        Console.WriteLine("insert quantity in stock");
        int _quantityInStock = int.Parse(Console.ReadLine());
        return new Product(_id, _nameProduct, CategoryName.PREMIUM_SERIES, _price, _quantityInStock);
    }
    private static void createSale()
    {

        s_dal.Sale.Create(CreateEntitySale());
    }
    private static Sale CreateEntitySale()
    {
        Console.WriteLine("insert productId");
        int _productId = int.Parse(Console.ReadLine());
        Console.WriteLine("insert qoantity for sale");
        int _quantityForSale = int.Parse(Console.ReadLine());
        Console.WriteLine("insert salePrice");
        double _salePrice = double.Parse(Console.ReadLine());
        Console.WriteLine("you are club member?");
        string flag = Console.ReadLine();
        bool _isForClubMembersOnly;
        if (flag == "yes")
            _isForClubMembersOnly = true;
        else
            _isForClubMembersOnly = false;
        return new Sale(0,_productId, _quantityForSale, _salePrice, _isForClubMembersOnly, new DateTime(), new DateTime());
    }
    private static void updateCustomer()
    {


        s_dal.Customer.Update(createEntityCustomer());

    }
    private static void updateProduct()
    {
        s_dal.Product.Update(createEntityProduct());
    }
    private static void updateSale()
    {
        s_dal.Sale.Update(CreateEntitySale());
    }
    private static void showSubMenu<T>(ICrud<T> entity, int entityId)
    {
        int func=0;
        Console.WriteLine("for create press 1");
        Console.WriteLine("for read press 2");
        Console.WriteLine("for read all press 3");
        Console.WriteLine("for update press 4");
        Console.WriteLine("for delete press 5");
        Console.WriteLine("for exit press 0");

        try
        {

            func = int.Parse(Console.ReadLine());
        }
        catch(InvalidCastException ex) 
        {

            Console.WriteLine("your press is not valid");
            showSubMenu(entity, entityId);
        }
        switch (func)
        {
            case 1:
                switch (entityId)
                {
                    case 1:
                        createCustomer();
                        showSubMenu(entity,entityId);
                        break;
                    case 2:
                        createProduct();
                        showSubMenu(entity, entityId);
                        break;
                    case 3:
                        createSale();
                        showSubMenu(entity, entityId);
                        break;
                }
                break;
            case 2:
                Console.WriteLine("insert id");
                int id = int.Parse(Console.ReadLine());
              Console.WriteLine(entity.Read(id));
                showSubMenu(entity, entityId);
                break;
            case 3:
              
                foreach (var item in entity.ReadAll())
                {
                    Console.WriteLine(item);
                }
                showSubMenu(entity, entityId);
                break;
            case 4:
                switch (entityId)
                {
                    case 1:
                        updateCustomer();
                        showSubMenu(entity, entityId);
                        break;
                    case 2:
                        updateProduct();
                        showSubMenu(entity, entityId);
                        break;
                    case 3:
                        updateSale();
                        showSubMenu(entity, entityId);
                        break;
                }
                break;
            case 5:
                Console.WriteLine("insert id foe delete");
                int idForDelete = int.Parse(Console.ReadLine());
                entity.Delete(idForDelete);
                showSubMenu(entity, entityId);
                break;
            case 0:
                showMenu();break;
        }

    }

    public static void Main(string[] args)
    {
        Initialization.initialize(s_dal);
        try
        {
            showMenu();
        }
        catch (DalNotFoundId e)
        {
           LogManager.writeToLog("DalTest","read",e.Message);    
        }
        catch (DalIdExist e)
        {
            LogManager.writeToLog("DalTest", "create", e.Message); 
          
        }
    }

    }


