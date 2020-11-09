using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Microsoft.Ajax.Utilities;

namespace DrugService.Models
{
    public class DrugDbInitializer : DropCreateDatabaseAlways<DrugContext> // Класс для инициализации БД
    {
        protected override void Seed(DrugContext db) // Добавления полей в БД
        {
            db.Drugs.Add(new Drug { Name = "Арбидол", Manufacturer = "Фармстандарт", Price = 209 });
            db.Drugs.Add(new Drug { Name = "Цитрамон", Manufacturer = "Авексима", Price = 57 });
            db.Drugs.Add(new Drug { Name = "Парацетомол", Manufacturer = "Дальхимфарм", Price = 64 });
            db.Drugs.Add(new Drug { Name = "Азитромицин", Manufacturer = "Верофарм", Price = 107 });
            base.Seed(db);
        }
    }
}