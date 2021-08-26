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
    }
}
