using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProjeCampi.Controllers
{
    public class IstatistikController : Controller
    {
        context context = new context();
        // GET: Istatistik
        public ActionResult Index()
        {
            var kategoriNum = context.Categories.Count();
            var headingYazılımNum = context.Headings.Count(x => x.Category.CategoryID == 10);
            var writerwithA = context.Writers.Count(x => x.WriterName.Contains("a"));
            var kategoriMaxHeading = context.Headings.Max(x => x.Category.CategoryName);
            var TrueCount = context.Categories.Count(x => x.CategoryStatus == true);
            var FalseCount = context.Categories.Count(x => x.CategoryStatus == false);
            ViewBag.CategoryCount = kategoriNum;
            ViewBag.Heading = headingYazılımNum;
            ViewBag.Writer = writerwithA;
            ViewBag.HeadingMax = kategoriMaxHeading;
            ViewBag.StatusFark = (TrueCount - FalseCount);
            return View();
        }
    }
}