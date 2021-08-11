using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskWeb_2.Employees
{
    public class ListEmployees
    {
       public List<EmployeesModel> List{ get; set; }
       public ListEmployees()
       {
            List = new List<EmployeesModel>();
       }
    }
}
