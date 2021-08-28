using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskWeb_2.Models;
using TaskWeb_2.Customers;

namespace TaskWeb_2.DAL
{
    public class ContractService : IContractService
    {
        public List<ContractModel> AllGet()
        {
            BaseSQL contr = new BaseSQL();
            return (contr.Contract.ToList());
        }

        public void Create(ContractModel item)
        {
            BaseSQL contr = new BaseSQL();
            contr.Contract.Add(item);
            contr.SaveChanges();
        }

        public int GetCost(int idcontract)
        {
            var cost = 0;
            BaseSQL contr = new BaseSQL();
            var stav = (from bet in contr.Contract where bet.Id == idcontract select bet).ToList();
            foreach (var bet in stav)
            {
              cost  = (int)(decimal)bet.Cost;
            }
            return cost;
        }

        public CustomerModel GetCustomer(int idcontract)
        {
            var customer=new CustomerModel();
            BaseSQL contr = new BaseSQL();
            var cus  = (from contrat in contr.Contract where contrat.Id == idcontract select contrat).ToList();
            foreach (var custom in cus)
            {
                customer.FirstName = custom.CustomerFname;
                customer.LastName = custom.CustomerLname;
            }
            return customer;
        }
    }
}
