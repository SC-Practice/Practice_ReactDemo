using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReactDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IndexJSXWithBabel() 
        {
            return View();
        }

        public ActionResult IndexEs5AndEs6()
        {
            return View();
        }

        public ActionResult SyntaxJSX()
        {
            return View();
        }
    }
}