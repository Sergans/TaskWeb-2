using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskWeb_2.DAL;
using TaskWeb_2.Employees;

namespace TaskWeb_2.DAL
{
    public class EmployesService : IEmployesService
    {
        public List<EmployessModel> AllGet()
        {
           BaseSQL empl = new BaseSQL();
           return(empl.Employes.ToList());
        }

        public void Create(EmployessModel item)
        {
            BaseSQL empl = new BaseSQL();
            empl.Employes.Add(item);
            empl.SaveChanges();
        }
    }
}
