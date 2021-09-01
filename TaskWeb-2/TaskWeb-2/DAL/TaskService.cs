using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskWeb_2.Models;

namespace TaskWeb_2.DAL
{
    public class TaskService : ITaskService
    {
        BaseSQL task = new BaseSQL();
        public List<TaskModel> AllGet()
        {
            return (task.Order.ToList());
        }

        public void Create(TaskModel item)
        {
            task.Order.Add(item);
            task.SaveChanges();
        }

        public void Delete(int idtask)
        {
            foreach (var person in task.Order.ToList())
            {
                if (person.Id == idtask)
                {
                    task.Remove(person);
                    task.SaveChanges();
                }

            }
        }

        public int GetHours(DateTime fromTime, DateTime toTime, int idcontract)
        {
            int hours = 0;
            var taskperiod = (from period in task.Order where (fromTime<=period.Date&&toTime>=period.Date) && period.IdContract == idcontract select period).ToList();
            foreach (var sum in taskperiod)
            {
                hours = hours + sum.Hours;
            }
            return hours;
        }

        public void UpData(int idtask, string fname, string lname)
        {
            

        }
    }
}
