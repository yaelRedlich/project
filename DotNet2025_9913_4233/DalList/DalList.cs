using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
      internal sealed class  DalList : IDal
    {

      public  Icustomer Customer  => new CustomerImplementation();

      public   Iproduct Product => new ProductImplementation();
       
      public   Isale  Sale => new SaleImplementation ();

      private static readonly DalList instance = new DalList();

        public static IDal Instance { get; } = new DalList();

      private DalList()
        {

        }

    }
}
