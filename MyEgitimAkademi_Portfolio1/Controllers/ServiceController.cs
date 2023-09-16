using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio1.Models;

namespace MyEgitimAkademi_Portfolio1.Controllers
{
    public class ServiceController : Controller
    {

        MyPortfolioDb1Entities db = new MyPortfolioDb1Entities();
        [Authorize]
        public ActionResult Index()
        {
            var values = db.Service1.ToList();
            return View(values);
        }
        public ActionResult AddService()
        {
            return View();
        }
        [HttpPost]

        public ActionResult AddService(Service1 service)
        {
            db.Service1.Add(service);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteService(int id)
        {
            var value = db.Service1.Find(id);
            db.Service1.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult UpdateService(int id)
        {
            var value = db.Service1.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateService(Service1 service)
        {
            var value = db.Service1.Find(service.ServiceID);
            value.ServiceName = service.ServiceName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}