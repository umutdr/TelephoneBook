using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TelephoneBook.UI.Models
{
    public class DepartmentRoleViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "[CustomMSG] DepartmentRole field is required.")]
        public string DepartmentRoleName { get; set; }
    }
}