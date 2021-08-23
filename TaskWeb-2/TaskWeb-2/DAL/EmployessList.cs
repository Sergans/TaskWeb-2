using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskWeb_2.Employees;

namespace TaskWeb_2.DAL
{
    public class EmployessList
    {
        public List<EmployessModel> DataBaseEmployess { get; set; }
        public EmployessList()
        {
            DataBaseEmployess = new List<EmployessModel>();
        }
    }
}
