using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskWeb_2.Customers
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }//Имя клиента
        public int Order { get; set; }//Заказ
    }
}
