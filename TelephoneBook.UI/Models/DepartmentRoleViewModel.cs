using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TelephoneBook.UI.Models
{
    public class DepartmentRoleViewModel
    {
        [Required(ErrorMessage = "[CustomMSG] DepartmentRoleId field is required.")]
        public int Id { get; set; }

        [Display(Name = "Role Name")]
        [RegularExpression(@"[a-zA-Z]+", ErrorMessage = "Role Name can contain only letters.")]
        [DataType(DataType.Text)]
        [StringLength(maximumLength: 35, MinimumLength = 3, ErrorMessage = "Role Name" + " length must be minimum 3 characters and maximum 35 characters.")]
        [Required(ErrorMessage = "[CustomMSG] " + "Role Name" + " field is required.")]
        public string DepartmentRoleName { get; set; }
    }
}