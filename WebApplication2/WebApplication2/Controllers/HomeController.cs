using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        UrunVt urunVt = new UrunVt();

        public HomeController()
        {
           
        }
        public ActionResult Index()
        {
            //var model = _context.Tableİsmi.ToList();        tablo ismi gelecek  //
            return View(); // Model ismi gelecek //
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
    }
}