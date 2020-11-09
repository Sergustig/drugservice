using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DrugService.Models
{
    public class Drug // Класс Лекарства
    {
        public int Id { get; set; } // идентификатор
        public string Name { get; set; } // наименование лекарств
        public string Manufacturer { get; set; } // производитель лекарств
        public int Price { get; set; } // цена 

    }
}