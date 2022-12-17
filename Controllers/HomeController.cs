using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DynamicPage.Context;

namespace DynamicPage.Controllers
{
    public class HomeController : Controller
    {       
        private readonly ContextDynamicPage _context=new ContextDynamicPage();

        public ActionResult Index()
        {
            return View();
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

        // افزودن صفحات فعال در منو


        public ActionResult CreateMenu()
        {
            var pages = _context.Pages.Where(x => x.IsActive);


            return PartialView(pages);
        }
    }
}