using SchoolWebAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolWebAuth.Controllers
{
    public class CourseViewController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: CourseView
        public ActionResult Index()
        {
            return View(db.Course.ToList());
        }
    }
}