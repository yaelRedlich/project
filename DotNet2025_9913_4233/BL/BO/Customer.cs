using System;

namespace BO
{
    public class Customer
    {
        public int _idCard { get; set; }
        public string? _phone { get; set; }
        public string? _address { get; set; }
        public string _customerName { get; set; }

        public Customer()
        {
            _idCard = 0;
            _phone = "";
            _address = "";
            _customerName = "";
        }

        public Customer(int idCard, string? phone, string? address, string customerName)
        {
            _idCard = idCard;
            _phone = phone;
            _address = address;
            _customerName = customerName;
        }
    }
}