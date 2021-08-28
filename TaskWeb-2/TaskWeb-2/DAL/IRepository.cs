using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskWeb_2.DAL;
using Microsoft.EntityFrameworkCore;
using TaskWeb_2.Customers;
using TaskWeb_2.Employees;
using TaskWeb_2.Models;

namespace TaskWeb_2.DAL
{
   public interface IRepository<T> where T:class
   {
        public void Create(T item);
        public List<T> AllGet();
       // public int GetHours(DateTime fromTime,DateTime toTime,int idcontract);
       // public int GetCost(int idcontract);
        //public ContractModel Info(int idcontract);
        //public void UpDateContract(int idcontract);
        // public void DeleteContract(int idcontract);
    }
    public interface IContractService : IRepository<ContractModel>
    {
        public int GetCost(int idcontract);
        public CustomerModel GetCustomer(int idcontract);

    }
    public interface IEmployesService : IRepository<EmployessModel>
    {

    }
    public interface ITaskService : IRepository<TaskModel>
    {
        public int GetHours(DateTime fromTime, DateTime toTime, int idcontract);
    }
    public interface ICustomerService : IRepository<CustomerModel>
    {

    }
    



}
