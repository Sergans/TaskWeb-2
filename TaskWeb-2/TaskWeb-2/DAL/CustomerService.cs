using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskWeb_2.Customers;

namespace TaskWeb_2.DAL
{
    public class CustomerService : ICustomerService
    {
        public List<CustomerModel> AllGet()
        {
            BaseSQL cust = new BaseSQL();
            return (cust.Customer.ToList());
        }

        public void Create(CustomerModel item)
        {
            BaseSQL cust = new BaseSQL();
            cust.Customer.Add(item);
            cust.SaveChanges();
        }

        public int GetCost(int idcontract)
        {
            throw new NotImplementedException();
        }

        public int GetHours(DateTime fromTime, DateTime toTime, int idcontract)
        {
            throw new NotImplementedException();
        }
    }
}
