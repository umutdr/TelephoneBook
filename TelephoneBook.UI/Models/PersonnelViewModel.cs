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

        [Required(ErrorMessage = "[CustomMSG] This field is required.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "[CustomMSG] This field is required.")]
        public DepartmentRole DepartmentRole { get; set; }

        [Required(ErrorMessage = "[CustomMSG] This field is required.")]
        public Department Department { get; set; }

        [Required(ErrorMessage = "[CustomMSG] This field is required.")]
        public string Phone { get; set; }
    }
}