using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskWeb_2.Employees;


namespace TaskWeb_2.DAL
{
    public class ContactSQL : DbContext
    {
        public DbSet<ContractModel> Contract { get; set; }
        //public DbSet<EmployessModel> Employess { get; set; }
        public ContactSQL()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=taskweb4db;Trusted_Connection=True;");
        }
    }
}
