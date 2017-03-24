using System.Web.Mvc;

namespace ReactDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index() => View();

        public ActionResult IndexJSXWithBabel() => View();

        public ActionResult IndexEs5AndEs6() => View();

        public ActionResult SyntaxJSX() => View();
    }
}