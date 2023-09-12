using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio1.Models;

namespace MyEgitimAkademi_Portfolio1.Controllers
{
    public class ProjectController : Controller
    {
        MyPortfolioDb1Entities db = new MyPortfolioDb1Entities();
        public ActionResult Index()
        {
            var values = db.Project.ToList();
            return View(values);
        }
    }
}