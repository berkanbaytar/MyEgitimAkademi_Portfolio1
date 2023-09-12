using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio1.Models;

namespace MyEgitimAkademi_Portfolio1.Controllers
{
    public class DefaultController : Controller
    {

        MyPortfolioDb1Entities db = new MyPortfolioDb1Entities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialQuickContact()
        { 
        return PartialView();
        }
        public PartialViewResult PartialFeature()
        {
            return PartialView();
        }
        public PartialViewResult PartialService()
        {
            var values = db.Service1.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialSkill()
        {
            var values = db.Skill.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAward()
        {
            return PartialView();
        }
        public PartialViewResult PartialTestimonial()
        {
            return PartialView();
        }
        public PartialViewResult PartialClient()
        {
            return PartialView();
        }
    }
}