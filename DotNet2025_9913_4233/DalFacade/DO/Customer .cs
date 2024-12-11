using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record  Customer(int _idCard, string _phone, string _address, string _customerName)
    {


       


        //ctor func
        public Customer():this(0,"","","")
        {

        }
        


    }
}
