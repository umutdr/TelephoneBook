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
    public class DepartmentRoleController : Controller
    {
        private DepartmentRoleService departmentRoleService;

        public DepartmentRoleController()
        {
            departmentRoleService = new DepartmentRoleService();
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<DepartmentRole> departmentRoles = departmentRoleService.GetDepartmentRoles();

            var departmentRolesJSON = GeneralExtensions.SerializeJSON(departmentRoles);

            return Content(departmentRolesJSON, "application/json");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(DepartmentRoleViewModel departmentRoleViewModel)
        {
            if (!ModelState.IsValid)
                return View();

            var departmentRole = departmentRoleViewModel.GetDepartmentRoleModelByDepartmentRoleViewModel();
            departmentRoleService.Create(departmentRole);

            return RedirectToAction("Index","DepartmentRole");
        }
    }
}