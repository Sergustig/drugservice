using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DrugService.Models 
{
    public class DrugContext : DbContext // Связка набора лекарств и набора заказов для БД через Entity
    {
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}