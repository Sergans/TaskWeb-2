using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskWeb_2.DAL
{
   public interface IService 
   {
        public void Create();
        public List<ContractModel> AllGet();
        public ContractModel Info(int idcontract);
        public void UpDateContract(int idcontract);
        public void DeleteContract(int idcontract);
   }
    public class Servise : IService
    {
        public List<ContractModel> AllGet()
        {
            throw new NotImplementedException();
        }

        public void Create()
        {
            throw new NotImplementedException();
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
