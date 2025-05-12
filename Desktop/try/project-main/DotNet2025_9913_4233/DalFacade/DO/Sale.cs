
using System.ComponentModel.DataAnnotations;

namespace DO
{
    public record class Sale
    {
        [Key]
        public int id { get; set; }
        public int _productId { get; set; }
        public int _quantityForSale { get; set; }
        public double _salePrice { get; set; }
        public bool _isForClubMembersOnly { get; set; }
        public DateTime _dateStartSale { get; set; }
        public DateTime _dateEndSale { get; set; }

        public Sale() { }

        public Sale(int _id, int productId, int quantityForSale, double salePrice, bool isForClubMembersOnly, DateTime dateStartSale, DateTime dateEndSale)
        {
            id = _id;
            _productId = productId;
            _quantityForSale = quantityForSale;
            _salePrice = salePrice;
            _isForClubMembersOnly = isForClubMembersOnly;
            _dateStartSale = dateStartSale;
            _dateEndSale = dateEndSale;
        }
    }
}

