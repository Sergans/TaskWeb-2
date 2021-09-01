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
        BaseSQL empl = new BaseSQL();
        public List<EmployessModel> AllGet()
        {
           return(empl.Employes.ToList());
        }

        public void Create(EmployessModel item)
        {
            empl.Employes.Add(item);
            empl.SaveChanges();
        }

        public void Delete( int idemployer)
        {
            foreach (var person in empl.Employes.ToList())
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
            foreach (var person in empl.Employes.ToList())
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
