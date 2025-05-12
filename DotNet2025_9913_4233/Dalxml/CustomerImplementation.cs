using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dal
{
    internal class CustomerImplementation : Icustomer
    {
        private static string filePath = @"..\xml\customers.xml";
        private List<Customer> LoadCustomer()
        {
            if (!File.Exists(filePath))
                return new List<Customer>();

            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {

                return (List<Customer>)serializer.Deserialize(fs);
            }


        }

        private void SaveCustomer(List<Customer> customers)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(fs, customers);
            }
        }
        public int Create(Customer item)
        {
            List<Customer> customers = LoadCustomer();
            customers.Add(item);
            SaveCustomer(customers);
            return item.IdCard;

        }

        public void Delete(int id)
        {
            List<Customer> customers = LoadCustomer();
            Customer customer = customers.FirstOrDefault(s => s.IdCard == id);
            if (customer == null)
                throw new DalNotFoundId("customer not found");

            customers.Remove(customer);
            SaveCustomer(customers);
        }

        public Customer? Read(int id)
        {
            List<Customer> customers = LoadCustomer();
            Customer customer = customers.FirstOrDefault(s => s.IdCard == id);
            if (customer == null)
                throw new DalNotFoundId("Customer not found");
            return customer;
        }

        public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
        {
            List<Customer> customers = LoadCustomer();

            if (filter == null)
                return customers.Cast<Customer?>().ToList();
            else
                return customers.Where(filter).Cast<Customer?>().ToList();
        }


        public void Update(Customer item)
        {
            List<Customer> customers = LoadCustomer();
            int index = customers.FindIndex(s => s.IdCard == item.IdCard);
            if (index == -1)
                throw new DalNotFoundId("customer not found");
            customers[index] = item;
            SaveCustomer(customers);
        }

        public Customer? Read(Func<Customer, bool>? filter)
        {
            List<Customer> customers = LoadCustomer();
            if (filter == null)
                return customers.FirstOrDefault();
            return customers.FirstOrDefault(filter);
        }

    }
}
