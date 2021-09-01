using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskWeb_2.Customers;

namespace TaskWeb_2.DAL
{
    public class CustomerService : ICustomerService
    {
        BaseSQL cust = new BaseSQL();
        public List<CustomerModel> AllGet()
        {
            return (cust.Customer.ToList());
        }

        public void Create(CustomerModel item)
        {
            cust.Customer.Add(item);
            cust.SaveChanges();
        }

        public void Delete(int idcustomer)
        {
            foreach (var person in cust.Customer.ToList())
            {
                if (person.Id == idcustomer)
                {
                    cust.Remove(person);
                    cust.SaveChanges();
                }
               
            }
            
        }

        public int GetIdContract(string fname, string lname)
        {
            throw new NotImplementedException();
        }

        public void UpData(int idcustomer,string fname,string lname)
        {
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
