using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelperMethods.Models;

namespace HelperMethods.Controllers
{
    public class PeopleController : Controller
    {
        private List<User> UserData = new List<User>
        {
            new User {FirstName = "Иван", LastName = "Иванов", Role = Role.Admin },
            new User {FirstName = "Пётр", LastName = "Петрович", Role = Role.Admin },
            new User {FirstName = "Сергей", LastName = "Сергеевич", Role = Role.Admin },
            new User {FirstName = "Вася", LastName = "Васильев", Role = Role.Admin }
        };

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetPeaople()
        {
            return View(UserData);
        }

        [HttpPost]
        public ActionResult GetPeaple(string selectedRole)
        {
            if (selectedRole == "All" || selectedRole == null)
                return View(UserData);
            else
            {
                Role roleSelected = (Role)Enum.Parse(typeof(Role), selectedRole);
                return View(UserData.Where(u => u.Role == roleSelected));
            }
        }



    } // end controller
} // end namespace