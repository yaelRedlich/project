using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;
using DalApi;

namespace BlIimplemetation
{
    internal class Bl : BlApi.IBl
    {
        public BlApi.Icustomer Customer => new CustomerImplementaion();
        public BlApi.Iorder Order => new OrderImplementaion();   
        public BlApi.IProduct Product => new ProductImplementaion(); 
        public BlApi.Isale Sale =>  new SaleImplementation();
         
    }
}
