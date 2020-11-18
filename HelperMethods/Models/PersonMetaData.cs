using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelperMethods.Models
{
    //buddy class wil keep metadata for model claass when generated automatically
    [DisplayName("New Person")]
    public partial class PersonMetaData
    {
        [HiddenInput(DisplayValue = false)]
        public int PersonId { get; set; }
        [UIHint("MultilineText")]
        [Display(Name = "Name")]
        public string FirstName { get; set; }

        [Display(Name = "Surname")]
        public string LastName { get; set; }

        [Display(Name = "Birthday Date")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Display(Name = "Approved")]
        public bool isApproved { get; set; }
    }
}