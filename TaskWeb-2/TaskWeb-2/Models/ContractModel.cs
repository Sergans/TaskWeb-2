using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskWeb_2.Customers;
using TaskWeb_2.Employees;
using TaskWeb_2.Models;


namespace TaskWeb_2.DAL
{
    public class ContractModel
    {
        public int Id{get;set;}
        public DateTime DateCreate { get; set; }
        public DateTime DateClose { get; set; }
        public CustomerModel Customer { get; set; }
        //public List<EmployessModel> Employess { get; set; }
        //public List<TaskModel> Order { get; set; }
        public bool Status { get; set; }
        
    }
}
