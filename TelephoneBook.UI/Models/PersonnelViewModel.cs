using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelephoneBook.Entities;
using TelephoneBook.Services;
using TelephoneBook.UI.Extensions;

namespace TelephoneBook.UI.Models
{
    public class PersonnelViewModel
    {
        private DepartmentService _departmentService;
        private DepartmentRoleService _departmentRoleService;

        public PersonnelViewModel()
        {
            _departmentService = new DepartmentService();
            _departmentRoleService = new DepartmentRoleService();
        }

        [Display(Name = "Personnel Name")]
        [RegularExpression(@"[a-zA-Z]+", ErrorMessage = "Personnel Name can contain only letters.")]
        [DataType(DataType.Text)]
        [StringLength(maximumLength: 35, MinimumLength = 3, ErrorMessage = "Personnel Name" + " length must be minimum 3 characters and maximum 35 characters.")]
        [Required(ErrorMessage = "[CustomMSG] " + "Personnel Name" + " field is required.")]
        public string Name { get; set; }

        [Display(Name = "Personnel Surname")]
        [RegularExpression(@"[a-zA-Z]+", ErrorMessage = "Personnel Surname" + " can contain only letters.")]
        [DataType(DataType.Text)]
        [StringLength(maximumLength: 35, MinimumLength = 3, ErrorMessage = "Personnel Surname" + " length must be minimum 3 characters and maximum 35 characters.")]
        [Required(ErrorMessage = "[CustomMSG] " + "Personnel Surname" + " field is required.")]
        public string Surname { get; set; }

        [Display(Name = "Department")]
        [Required(ErrorMessage = "[CustomMSG] " + "Department" + " field is required.")]
        public int DepartmentId { get; set; }
        public string DepartmentName { get { return _departmentService.GetDepartmentById(DepartmentId).DepartmentName; } }

        [Display(Name = "Role")]
        [Required(ErrorMessage = "[CustomMSG] " + "Role" + " field is required.")]
        public int DepartmentRoleId { get; set; }
        public string DepartmentRoleName { get { return _departmentRoleService.GetDepartmentRoleById(DepartmentRoleId).DepartmentRoleName; } }
        
        [Display(Name = "Phone Number")]
        [RegularExpression(@"^([0-9]+)$", ErrorMessage = "Personnel Phone" + " can contain only numbers.")]
        [Required(ErrorMessage = "[CustomMSG] " + "Phone" + " field is required.")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
    }
}