using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelephoneBook.Entities;
using TelephoneBook.Services;

namespace TelephoneBook.UI.Controllers
{
    public class HomeController : Controller
    {
        private PersonnelService _personnelService;

        public HomeController()
        {
            _personnelService = new PersonnelService();
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<Personnel> personnels = _personnelService.GetPersonnels();
            return View(model: personnels);
        }

        [HttpGet]
        public JsonResult GetSearchValue(string searchValue)
        {
            List<Personnel> personnels = _personnelService.GetSearchValue(searchValue);
            return new JsonResult { Data = personnels, JsonRequestBehavior = JsonRequestBehavior.AllowGet }; 
        }

        [HttpGet]
        public JsonResult GetPersonnelById(int personnelId)
        {
            Personnel personnel = _personnelService.GetPersonnelById(personnelId);
            return new JsonResult { Data = personnel, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

    }
}