using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DrugService.Models
{
    public class Order // Класс Заказ
    {
        public int OrderId { get; set; } // идентификатор заказа
        public string DrugStore { get; set; } // наименование аптеки
        public string Address { get; set; } // адрес аптеки
        public DateTime DateOrder { get; set; } // дата заказа
        public int DrugId { get; set; } // идентификатор лекарства
    }
}