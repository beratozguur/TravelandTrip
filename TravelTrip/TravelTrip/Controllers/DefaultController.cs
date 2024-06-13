using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Sınıflar;

namespace TravelTrip.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Blogs.Take(10).ToList();
            return View(degerler);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial4()
        {
            var deger = c.Blogs.Take(3).ToList();

            return PartialView(deger);
        }
        public ActionResult Partial5()
        {
            var deger = c.Blogs.Take(3).OrderByDescending(x => x.ID).ToList();
            return PartialView(deger);
        }
        public ActionResult Iletisim()
        {
            var ilet = c.iletisims.ToList();
            return View(ilet);
        }
        public ActionResult Fotograflar()
        {
            var foto = c.Blogs.ToList();
            return View(foto);
        }
    }
}