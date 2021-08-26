using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
