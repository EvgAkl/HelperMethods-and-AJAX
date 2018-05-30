using System;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HelperMethods.Models
{
    [DisplayName("новый пользователь")]
    public class User
    {
        [HiddenInput(DisplayValue = false)]
        public int UserId { get; set; }
        [DisplayName("Имя")]
        [UIHint("MultilineText")]
        public string FirstName { get; set; }
        [DisplayName("Фамилия")]
        public string LastName { get; set; }
        [DisplayName("Дата рождения")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [DisplayName("Адрес")]
        public Addres HomeAddress { get; set; }
        [DisplayName("Подтвердил регистрацию")]
        public bool IsApproved { get; set; }
        [DisplayName("Роль")]
        public Role Role { get; set; }
    }

    public class Addres
    {
        public string Line1 { get; set; }
        public string line2 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }

    public enum Role
    {
        Admin,
        User,
        Guest
    }

} // end namsespace