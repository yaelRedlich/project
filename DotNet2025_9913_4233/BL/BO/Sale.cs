using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Sale
    {
        public int id { get; set; }
        public int _productId { get; set; }
        public int _quantityForSale { get; set; }
        public double _salePrice { get; set; }
        public bool _isForClubMembersOnly { get; set; }
        public DateTime _dateStartSale { get; set; }
        public DateTime _dateEndSale { get; set; }

        public Sale()
        {
            id = 0;
            _productId = 0;
            _quantityForSale = 0;
            _salePrice = 0;
            _isForClubMembersOnly = false;
            _dateStartSale = new DateTime();
            _dateEndSale = new DateTime();
        }
        public Sale(int id, int productId, int quantityForSale, double salePrice, bool isForClubMembersOnly, DateTime dateStartSale, DateTime dateEndSale)
        {
            this.id = id;
            this._productId = productId;
            this._quantityForSale = quantityForSale;
            this._salePrice = salePrice;
            this._isForClubMembersOnly = isForClubMembersOnly;
            this._dateStartSale = dateStartSale;
            this._dateEndSale = dateEndSale;
        }
        public Sale( int productId, int quantityForSale, double salePrice, bool isForClubMembersOnly, DateTime dateStartSale, DateTime dateEndSale)
        {
            this._productId = productId;
            this._quantityForSale = quantityForSale;
            this._salePrice = salePrice;
            this._isForClubMembersOnly = isForClubMembersOnly;
            this._dateStartSale = dateStartSale;
            this._dateEndSale = dateEndSale;
        }
        public override string ToString() => Tools.ToStringProperty(this);
    }
}
