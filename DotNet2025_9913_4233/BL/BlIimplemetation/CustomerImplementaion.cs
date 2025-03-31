using BlApi;
using BO;
using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            catch (DO.DalIdExist ex)
            {
                throw new BlIdExist("id doesnt exist" , ex);
                throw new DalIdExist("id doesnt exist");
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
            return new BO.Customer(c._idCard, c._phone, c._address, c._customerName);
            }
            catch (DO.DalIdExist ex)
            {
                throw new BlIdExist("id doesnt exist", ex);
                throw new DalIdExist("id doesnt exist");
            }
        }

        public  List<BO.Customer?>  ReadAll(Func<BO.Customer, bool>? filter=null)
        {
            
                List<DO.Customer?> c = _dal.Customer.ReadAll(); 
                List<BO.Customer> ListCustomers =c.Select(c => new BO.Customer(c._idCard, c._phone, c._address, c._customerName))
                .ToList();
                if(filter != null)  
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
                _dal.Customer.Create(new DO.Customer(item._idCard, item._phone, item._address, item._customerName));

            }
            catch(DalIdExist ex)
            {
                throw new BlIdExist("id doesnt exist", ex);
                throw new DalIdExist("id doesnt exist");
            }
            catch (DalNotFoundId ex)
            {
                throw new BlNotFoundId("not found id", ex);
                throw new DalNotFoundId("not found id");

            }
        }

        public void Delete(int id)
        {
            try
            {
                _dal.Customer.Delete(id);
            }
            catch (DO.DalIdExist ex)
            {
                throw new BlIdExist("id doesnt exist", ex);
                throw new DalIdExist("id doesnt exist");
            }
        }
    }
}
