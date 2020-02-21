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

        [Required(ErrorMessage = "[CustomMSG] Name field is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "[CustomMSG] Surname field is required.")]
        public string Surname { get; set; }

        [Display(Name = "Department")]
        [Required(ErrorMessage = "[CustomMSG] Department field is required.")]
        public int DepartmentId { get; set; }
        /*Best practice, is that you??*/
        public string DepartmentName { get { return _departmentService.GetDepartmentById(DepartmentId).DepartmentName; } }

        [Display(Name = "Role")]
        [Required(ErrorMessage = "[CustomMSG] Role field is required.")]
        public int DepartmentRoleId { get; set; }
        public string DepartmentRoleName { get { return _departmentRoleService.GetDepartmentRoleById(DepartmentRoleId).DepartmentRoleName; } }

        [Required(ErrorMessage = "[CustomMSG] Phone field is required.")]
        public string Phone { get; set; }
    }
}