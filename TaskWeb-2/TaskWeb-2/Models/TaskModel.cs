using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskWeb_2.Models
{
    public class TaskModel
    {   public int Id { get; set; }
        public int IdContract { get; set; }
        public int IdEmployer { get; set; }
        public DateTime Date { get; set; }
        public int Hours { get; set; }
    }
}
