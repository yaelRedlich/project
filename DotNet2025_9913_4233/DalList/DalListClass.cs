using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class DalListClass : IDal
    {
      public  Icustomer Customer  => new CustomerImplementation();

      public   Iproduct Product => new ProductImplementation();
       
      public   Isale  Sale => new SaleImplementation ();
    }
}
