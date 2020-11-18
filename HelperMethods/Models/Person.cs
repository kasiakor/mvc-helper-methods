using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace HelperMethods.Models
{
    [MetadataType(typeof(PersonMetaData))]
    public partial class Person
    {
        //[DisplayName("New Person")]
        //[HiddenInput]
        //[HiddenInput(DisplayValue = false
        //[Display(Name = "Nickname")]
        //[DataType(DataType.Date)]
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public DateTime Birthday { get; set; }
        public Address HomeAddress { get; set; }
        public bool isApproved { get; set; }
        public Role Role { get; set; }

    }

    public class Address
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
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
}