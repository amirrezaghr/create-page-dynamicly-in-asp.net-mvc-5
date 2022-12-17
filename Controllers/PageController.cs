using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DynamicPage.Context;
using DynamicPage.Models;

namespace DynamicPage.Controllers
{
    public class PageController : Controller
    {
        private readonly ContextDynamicPage _context = new ContextDynamicPage();

        // لیست صفحات

        [Route("pages", Name = "GetPages")]
        public ActionResult Index()
        {
            return View(_context.Pages);
        }

        // افزودن صفحه جدید

        [Route("new-page", Name = "GetCreatePage")]
        public ActionResult Create()
        {
            return View();
        }

        // افزودن صفحه جدید

        [HttpPost]
        public ActionResult Create(Page page)
        {
            if (!ModelState.IsValid) return View(page);

            if (IsExistUrl(page.Url)) // آدرس هر صفحه باید یونیک باشد
            {
                ModelState.AddModelError("Url", "این آدرس صفحه وجود دارد لطفا آدرس دیگری انتخاب کنید");

                return View(page);
            }

            page.CreateDate = DateTime.Now;

            page.Url = page.Url.Trim();

            _context.Pages.Add(page);

            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        // نمایش صفحاتی که ساخته ایم

        [Route("{url}", Name = "GetPage")]
        public ActionResult DisplayPage(string url)
        {
            var page = _context.Pages.SingleOrDefault(x => x.Url == url.Trim());

            if (page == null)
            {
                return HttpNotFound();
            }           

            return View(page);
        }

        // بررسی اینکه لینک صفحه ای که ساخته ایم تکراری نباشد

        public bool IsExistUrl(string url)
        {
            if (_context.Pages.Any(x => x.Url == url.Trim()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}