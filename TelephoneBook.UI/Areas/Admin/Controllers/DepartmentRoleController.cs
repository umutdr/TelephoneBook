using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelephoneBook.Entities;
using TelephoneBook.Services;
using TelephoneBook.UI.Extensions;

namespace TelephoneBook.UI.Areas.Admin.Controllers
{
    public class DepartmentRoleController : Controller
    {
        private DepartmentRoleService departmentRoleService;

        public DepartmentRoleController()
        {
            departmentRoleService = new DepartmentRoleService();
        }

        public ActionResult Index()
        {
            List<DepartmentRole> departmentRoles = departmentRoleService.GetDepartmentRoles();

            var departmentRolesJSON = GeneralExtensions.SerializeJSON(departmentRoles);

            return Content(departmentRolesJSON, "application/json");
        }

    }
}