using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskWeb_2.Customers;

namespace TaskWeb_2.Models
{
    public class InvoiceModel
    {
        public DateTime DateCreate { get; set; }
        public DateTime DateClose { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Sum { get; set; }
        
    }
}
