using Newtonsoft.Json;
using System.Collections.Generic;
using System.Web.Mvc;
using TelephoneBook.Entities;
using TelephoneBook.Services;
using TelephoneBook.UI.Extensions;
using TelephoneBook.UI.Models;

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

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(DepartmentViewModel departmentViewModel)
        {
            if (!ModelState.IsValid)
                return View(departmentViewModel);

            var departmentModel = departmentViewModel.GetDepartmentModelByDepartmentViewModel();
            departmentService.Create(departmentModel);

            return RedirectToAction("Index", "Department");
        }

    }
}