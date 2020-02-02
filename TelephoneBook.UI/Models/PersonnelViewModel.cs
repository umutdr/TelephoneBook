using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TelephoneBook.Entities;

namespace TelephoneBook.UI.Models
{
    public class PersonnelViewModel
    {
        [Required(ErrorMessage = "[CustomMSG] Name field is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "[CustomMSG] Surname field is required.")]
        public string Surname { get; set; }

        [Display(Name = "Department")]
        [Required(ErrorMessage = "[CustomMSG] Department field is required.")]
        public Department Department { get; set; }

        [Display(Name = "Role")]
        [Required(ErrorMessage = "[CustomMSG] Role field is required.")]
        public DepartmentRole DepartmentRole { get; set; } // TODO DepartmentRole ve Department için VM de ne kullanılmalı?

        [Required(ErrorMessage = "[CustomMSG] Phone field is required.")]
        public string Phone { get; set; }
    }
}