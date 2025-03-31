using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi
{
    public interface IBl
    {
        public  IProduct Product { get; }
        public  Icustomer Customer { get; }
        public  Isale Sale { get; }
        public  Iorder Order { get; }
    }
}
