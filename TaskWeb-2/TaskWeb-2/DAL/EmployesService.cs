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

        public void Delete( int idemployer)
        {
            BaseSQL empl = new BaseSQL();
            foreach (var person in empl.Customer.ToList())
            {
                if (person.Id == idemployer)
                {
                    empl.Remove(person);
                    empl.SaveChanges();
                }

            }
        }

        public void UpData(int idemployer, string fname, string lname)
        {
            BaseSQL empl = new BaseSQL();
            foreach (var person in empl.Customer.ToList())
            {
                if (person.Id == idemployer)
                {
                    person.FirstName = fname;
                    person.LastName = lname;
                    empl.SaveChanges();
                }

            }
        }
    }
}
