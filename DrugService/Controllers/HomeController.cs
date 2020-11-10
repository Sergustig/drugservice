using DrugService.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrugService.Controllers
{
    public class HomeController : Controller
    {
        DrugContext db = new DrugContext(); // взаимосвязь с БД - переменная db

        public ActionResult Index()
        {
            //IEnumerable<Drug> drugs = db.Drugs; // IEnumerable - интерфейс для получения набора лекарств
            //ViewBag.Drugs = drugs; // передача в представление
            return View(db.Drugs);
        }

        public ActionResult GetManufacturers()
        {
            string[] manufacturers = new string[] { "Биотон", "Диафарм", "ФармВилар", "Мосхимфармпрепараты" };
            return View(manufacturers);

        }

        [HttpGet]

        public ActionResult Order(int id)
        {

            ViewBag.DrugID = id;
            return View();
        }

        [HttpPost]

        public string Order(Order order)
        {

            order.DateOrder = DateTime.Now;
            db.Orders.Add(order);
            db.SaveChanges();
            return "Спасибо, " + order.DrugStore + ", за заказ!";
        }

        public string CostOfDelivery(double a, double b = 15) //расчет стоимости доставки
        {
            double s = a * b;
            return "<h2>Стоимость Вашей доставки равна " + s + " рублей"+"</h2>";
        }

        public FileResult GetFile()
        {
            string file_path = Server.MapPath("~/Files/price.xls");
            string file_type = "application/xls";
            string file_name = "price.xls";
            return File(file_path, file_type, file_name);

        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}