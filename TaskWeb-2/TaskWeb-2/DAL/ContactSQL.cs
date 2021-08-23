using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace TaskWeb_2.DAL
{
    public class ContactSQL : DbContext
    {
        public DbSet<ContractModel> Contract { get; set; }
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
