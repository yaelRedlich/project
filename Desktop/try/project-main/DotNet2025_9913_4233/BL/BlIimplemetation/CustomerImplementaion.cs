using BlApi;
using BO;
using DalApi;
using DO;


namespace BlIimplemetation
{
    internal class CustomerImplementaion : BlApi.Icustomer
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
         
       public int Create(BO.Customer item)
        {
            try
            {
                return _dal.Customer.Create(new DO.Customer(item._idCard, item._phone, item._address, item._customerName));

            }
            catch (DO.DalProductIdExist ex)
            {
                throw new BlProductIdExist("The product is out of stock.", ex);
            }
            catch (DO.DalIdExist ex)
            {
                throw new BlIdExist("The ID already exists in the system.", ex);
            }
        }
        public  bool isExist(int id)
        {
           BO.Customer  c = Read(id);
            if (c==null)
                return false;
            return true;
        }

       public BO.Customer? Read(int id)
        {
            try
            {
            DO.Customer c = _dal.Customer.Read(id);
            if (c == null)
                return null;
            return new BO.Customer(c.IdCard, c.Phone, c.Address, c.CustomerName);
            }
            catch (DO.DalNotFoundId ex)
            {
                throw new BlNotFoundId("The product is out of stock.", ex);
            }
        }

        public List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter=null)
        {
            
                List<DO.Customer?> c = _dal.Customer.ReadAll(); 
                List<BO.Customer> ListCustomers = c.Select(c => new BO.Customer(c.IdCard, c.Phone, c.Address, c.CustomerName))
                .ToList();
            foreach (var item in ListCustomers)
            {
                Console.WriteLine(item);
            }
                if (filter == null)  
                    return ListCustomers; 
                else
                    return ListCustomers.Where(filter).ToList();   
            
        }
        public BO.Customer? Read(Func<BO.Customer, bool> filter)
        {
            List<BO.Customer> customersBo = ReadAll();
            return customersBo.FirstOrDefault(c => filter(c));
        }

        public void Update(BO.Customer item)
        {
            try
            {
                _dal.Customer.Update(new DO.Customer(item._idCard, item._phone, item._address, item._customerName));

            }
            catch(DalIdExist ex)
            {
                throw new BlIdExist("The product is out of stock.", ex);
            }
          
        }

        public void Delete(int id)
        {
            try
            {
                _dal.Customer.Delete(id);
            }
            catch (DO.DalNotFoundId ex)
            {
                throw new BlNotFoundId("The product is out of stock.", ex);
            }
        }
    }
}
