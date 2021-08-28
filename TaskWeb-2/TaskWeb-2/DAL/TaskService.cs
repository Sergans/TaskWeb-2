using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskWeb_2.Models;

namespace TaskWeb_2.DAL
{
    public class TaskService : ITaskService
    {
        public List<TaskModel> AllGet()
        {
            BaseSQL task = new BaseSQL();
            return (task.Order.ToList());
        }

        public void Create(TaskModel item)
        {
            BaseSQL task = new BaseSQL();
            task.Order.Add(item);
            task.SaveChanges();
        }

        public void Delete(int item)
        {
            throw new NotImplementedException();
        }

        public int GetHours(DateTime fromTime, DateTime toTime, int idcontract)
        {
            int hours = 0;
            BaseSQL task = new BaseSQL();
            var taskperiod = (from period in task.Order where period.IdContract == idcontract select period).ToList();
            foreach (var sum in taskperiod)
            {
                hours = hours + sum.Hours;
            }
            return hours;
        }

        public void UpData(int idcustomer, string fname, string lname)
        {
            throw new NotImplementedException();
        }
    }
}
