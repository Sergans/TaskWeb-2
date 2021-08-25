using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using TaskWeb_2.DAL.Contracts;
using Microsoft.EntityFrameworkCore;

namespace TaskWeb_2.DAL
{
   public interface IService 
   {
        public void Create(ContractModel contract);
        //public List<ContractModel> AllGet();
        public ContractModel Info(int idcontract);
        public void UpDateContract(int idcontract);
        public void DeleteContract(int idcontract);
   }
    public class Service : IService
    {
        //public List<ContractModel> AllGet()
        //{
        //   return
        //}

        public void Create(ContractModel contract)
        {
            
        }

        public void DeleteContract(int idcontract)
        {
            throw new NotImplementedException();
        }

        public ContractModel Info(int idcontract)
        {
            throw new NotImplementedException();
        }

        public void UpDateContract(int idcontract)
        {
            throw new NotImplementedException();
        }
    }
}
