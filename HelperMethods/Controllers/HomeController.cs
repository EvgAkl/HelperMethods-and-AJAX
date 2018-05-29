using System.Web.Mvc;

namespace HelperMethods.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Fruits = new string[] { "Яблоко", "Апельсин", "Груша" };
            ViewBag.Cities = new string[] { "Москва", "Лондон", "Париж" };

            string message = "Это HTML-элемент: <input>";

            return View((object)message);
        } // end Index()

        public ActionResult ExternalHelper()
        {
            ViewBag.Fruits = new string[] { "Мандарин", "Киви", "Банан" };
            ViewBag.Cities = new string[] { "Минск", "Варшава", "Ванкувер" };

            string message = "Это HTML-элемент: <input>";

            return View((object)message);
        } // end ExternalHelper()








    } // end class
} // end namespace