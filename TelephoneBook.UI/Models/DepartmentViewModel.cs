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
        public int Id { get; set; }

        [Required(ErrorMessage = "[CustomMSG] DepartmentName field is required.")]
        public string DepartmentName { get; set; }

    }
}