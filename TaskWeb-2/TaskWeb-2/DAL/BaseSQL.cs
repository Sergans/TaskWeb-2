using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskWeb_2.Employees;
using TaskWeb_2.Models;
using TaskWeb_2.Customers;



namespace TaskWeb_2.DAL
{
    public class BaseSQL : DbContext
    {
        public DbSet<EmployessModel> Employes { get; set; }
        public DbSet<TaskModel> Order { get; set; }
        public DbSet<CustomerModel> Customer { get; set; }
        public DbSet<ContractModel> Contract { get; set; }
        public DbSet<UserModel> User { get; set; }

        public BaseSQL()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=taskweb4db;Trusted_Connection=True;");
        }
    }
}
