

using DO;

namespace Dal;

 static internal class DataSource 
{
    static internal  List<Product> products=new List<Product>();
    static internal List<Sale> sales=new List<Sale>();
    static internal List<Customer> customers=new List<Customer>();
    static internal class Config
    {
         internal const int  _id= 0;
        static private int  _staticId= _id;
        public  static int StaticId { get { return _staticId++; } }




    
    }



}
