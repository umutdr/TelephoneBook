using Newtonsoft.Json;
using System.Collections.Generic;
using System.Web.Mvc;
using TelephoneBook.Entities;
using TelephoneBook.Services;
using TelephoneBook.UI.Extensions;

namespace TelephoneBook.UI.Areas.Admin.Controllers
{
    public class DepartmentController : Controller
    {
        private DepartmentService departmentService;

        public DepartmentController()
        {
            departmentService = new DepartmentService();
        }

        public ActionResult Index()
        {
            List<Department> departments = departmentService.GetDepartments();

            var departmentsJSON = GeneralExtensions.SerializeJSON(departments);

            return Content(departmentsJSON, "application/json");

        }

    }
}