using System;
using System.ComponentModel.DataAnnotations;

namespace HelperMethods.Models
{
    [MetadataType(typeof(UserMetadata))]
    public partial class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public Addres HomeAddress { get; set; }
        public bool IsApproved { get; set; }
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