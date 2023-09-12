using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio1.Models;

namespace MyEgitimAkademi_Portfolio1.Controllers
{
    public class RegisterController : Controller
    {

        MyPortfolioDb1Entities db = new MyPortfolioDb1Entities();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            db.Admin.Add(admin);
            db.SaveChanges();
            return RedirectToAction("Index","Login");
        }
    }
}