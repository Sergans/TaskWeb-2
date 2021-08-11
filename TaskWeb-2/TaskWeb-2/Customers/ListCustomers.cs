using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskWeb_2.Customers
{
    public class ListCustomers
    {
       public List<CustomerModel> List { get; set; }
       public ListCustomers()
       {
            List = new List<CustomerModel>();
       }
    }
}
