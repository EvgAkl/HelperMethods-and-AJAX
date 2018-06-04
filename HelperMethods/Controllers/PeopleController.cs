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
            new User {FirstName = "Пётр", LastName = "Петрович", Role = Role.User },
            new User {FirstName = "Сергей", LastName = "Сергеевич", Role = Role.Admin },
            new User {FirstName = "Вася", LastName = "Васильев", Role = Role.Guest }
        };

        public ActionResult Index()
        {
            return View();
        }

        public IEnumerable<User> GetData(string selectedRole)
        {
            IEnumerable<User> users = UserData;
            if (selectedRole != "All")
            {
                Role selected = (Role)Enum.Parse(typeof(Role), selectedRole);
                users = UserData.Where(p => p.Role == selected);
            }
            return users;
        }

        public JsonResult GetPeopleDataJson(string selectedRole = "All")
        {
            var users = GetData(selectedRole).Select(p => new
            {
                FirstName = p.FirstName,
                LastName = p.LastName,
                Role = Enum.GetName(typeof(Role), p.Role)
            });
            return Json(users, JsonRequestBehavior.AllowGet);
        }

        public PartialViewResult GetPeopleData(string selectedRole = "All")
        {
            return PartialView(GetData(selectedRole));
        }

        public ActionResult GetPeople(string selectedRole = "All")
        {
            return View((Object)selectedRole);
        }

        

    } // end controller
} // end namespace