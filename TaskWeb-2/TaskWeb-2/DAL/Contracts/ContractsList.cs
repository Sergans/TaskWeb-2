using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskWeb_2.DAL.Contracts
{
    public class ContractsList
    {
        public List<ContractModel> DateBase { get; set; }
        public ContractsList()
        {
            DateBase = new List<ContractModel>();
        }
    }

}
