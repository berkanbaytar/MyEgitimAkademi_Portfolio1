using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio1.Models;

namespace MyEgitimAkademi_Portfolio1.Controllers
{
    public class ContactController : Controller
    {
        MyPortfolioDb1Entities db = new MyPortfolioDb1Entities();

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.description = db.Address.Select(x => x.Description).FirstOrDefault();
            ViewBag.phone=db.Address.Select(x => x.Phone).FirstOrDefault();
            ViewBag.addressDetail = db.Address.Select(x => x.AddressDetail).FirstOrDefault();
            ViewBag.mail = db.Address.Select(x => x.Mail).FirstOrDefault();
            return View();
        }
        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            db.Contact.Add(contact);
            db.SaveChanges();
            return RedirectToAction("Index", "Default");
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}