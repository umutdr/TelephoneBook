using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelephoneBook.Entities;
using TelephoneBook.Services;
using TelephoneBook.UI.Extensions;
using TelephoneBook.UI.Models;

namespace TelephoneBook.UI.Areas.Admin.Controllers
{
    public class PersonnelController : Controller
    {
        private PersonnelService _personnelService;
        private DepartmentService _departmentService;
        private DepartmentRoleService _departmentRoleService;

        public PersonnelController()
        {
            _personnelService = new PersonnelService();
            _departmentService = new DepartmentService();
            _departmentRoleService = new DepartmentRoleService();
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<Personnel> personnels = _personnelService.GetPersonnels();
            var personnelsJSON = GeneralExtensions.SerializeJSON(personnels);

            return Content(personnelsJSON,"application/json");
        }

        [HttpGet]
        public ActionResult Create()
        {
            var departmentViewModel = _departmentService.GetDepartments().GetDepartmentViewModelsByDepartmentModels();
            ViewBag.DepartmentsSelectList = new SelectList(departmentViewModel, "Id", "DepartmentName");

            var departmentRoleViewModel = _departmentRoleService.GetDepartmentRoles().GetDepartmentRoleViewModelsByDepartmentRoleModels();
            ViewBag.DepartmentRolesSelectList = new SelectList(departmentRoleViewModel, "Id", "DepartmentRoleName");

            return View();
        }

        [HttpPost]
        public ActionResult Create(PersonnelViewModel personnelViewModel)
        {
            if (!ModelState.IsValid)
            {
                var departmentViewModel = _departmentService.GetDepartments().GetDepartmentViewModelsByDepartmentModels();
                ViewBag.DepartmentsSelectList = new SelectList(departmentViewModel, "Id", "DepartmentName");

                var departmentRoleViewModel = _departmentRoleService.GetDepartmentRoles().GetDepartmentRoleViewModelsByDepartmentRoleModels();
                ViewBag.DepartmentRolesSelectList = new SelectList(departmentRoleViewModel, "Id", "DepartmentRoleName");

                return View(personnelViewModel);
            }

            var personnelModel = personnelViewModel.GetPersonnelModelByPersonnelViewModel();
            _personnelService.Create(personnelModel);

            return RedirectToAction("Index");
        }
    }
}