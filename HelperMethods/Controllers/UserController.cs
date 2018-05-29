using System.Web.Mvc;
using HelperMethods.Models;

namespace HelperMethods.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            return View();
        } // end Index()

        public ActionResult CreateUser()
        {
            return View(new User());
        } // end CreateUser() #1

        [HttpPost]
        public ActionResult CreateUser(User user)
        {
            return View(user);
        } // end CreateUser() #2 

        public ActionResult CreateUserHelper()
        {
            return View(new User());
        } // end CreateUserHelper() #1

        [HttpPost]
        public ActionResult CreateUserHelper(User user)
        {
            return View(user);
        } // end CreateUserHelper() #2

        public ActionResult CreateUserGenericHelper()
        {
            return View(new User());
        } // end CreateUserGenericHelper() #1

        [HttpPost]
        public ActionResult CreateUserGenericHelper(User user)
        {
            return View(user);
        } // end CreateUserGenericHelper() #2






    } // end controller
} // end namespace