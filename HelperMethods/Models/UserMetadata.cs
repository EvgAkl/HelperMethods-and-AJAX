using System;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HelperMethods.Models
{
    [DisplayName("новый юзер")]
    public partial class UserMetadata
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
        [DisplayName("Подтвердил регистрацию?")]
        public bool IsApproved { get; set; }
        [DisplayName("Роль")]
        public Role Role { get; set; }
    } // end class

} // end namespace