
using System.ComponentModel.DataAnnotations;

namespace DO
{
    [Serializable]

    public record Customer
    {
        [Key]
        public int IdCard { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string CustomerName { get; set; }

        public Customer() { }

        public Customer(int _idCard, string _phone, string _address, string _customerName)
        {
            IdCard = _idCard;
            Phone = _phone;
            Address = _address;
            CustomerName = _customerName;
        }
    }
}
