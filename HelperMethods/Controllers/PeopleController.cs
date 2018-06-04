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

        public ActionResult GetPeople(string selectedRole = "All")
        {
            return View((Object)selectedRole);
        }

        public PartialViewResult GetPeopleData(string selectedRole = "All")
        {
            IEnumerable<User> users = UserData;
            if (selectedRole != "All")
            {
                Role selected = (Role)Enum.Parse(typeof(Role), selectedRole);
                users = UserData.Where(p => p.Role == selected);
            }
            return PartialView(users);
        }

    } // end controller
} // end namespace