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

        public void Delete(int idcustomer)
        {
            BaseSQL cust = new BaseSQL();
           
            foreach (var person in cust.Customer.ToList())
            {
                if (person.Id == idcustomer)
                {
                    cust.Remove(person);
                    cust.SaveChanges();
                }
               
            }
            
        }

        public void UpData(int idcustomer,string fname,string lname)
        {
            BaseSQL cust = new BaseSQL();
            foreach (var person in cust.Customer.ToList())
            {
                if (person.Id == idcustomer)
                {
                    person.FirstName = fname;
                    person.LastName = lname;
                    cust.SaveChanges();
                }

            }
        }
    }
}
