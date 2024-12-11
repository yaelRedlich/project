using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DO
{
    public record Sale(int id,int _productId, int _quantityForSale, double _salePrice, bool _isForClubMembersOnly, DateTime _dateStartSale, DateTime _dateEndSale)
    {
      

        public Sale():this(0,0,0,0,false,new DateTime(), new DateTime())
        { 
        }
       

    }
}
