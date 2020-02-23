using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TelephoneBook.UI.Models
{
    public class DepartmentViewModel
    {
        [Required(ErrorMessage = "[CustomMSG] DepartmentId field is required.")]
        public int Id { get; set; }

        [Display(Name = "Department Name")]
        [RegularExpression(@"[a-zA-Z]+", ErrorMessage = "Department Name can contain only letters.")]
        [DataType(DataType.Text)]
        [StringLength(maximumLength: 35, MinimumLength = 3, ErrorMessage = "Department Name" + " length must be minimum 3 characters and maximum 35 characters.")]
        [Required(ErrorMessage = "[CustomMSG] " + "Department Name" + " field is required.")]
        public string DepartmentName { get; set; }
    }
}