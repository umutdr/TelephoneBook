using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelephoneBook.Services;
using TelephoneBook.UI.Extensions;
using TelephoneBook.UI.Models;

namespace TelephoneBook.UI.Areas.Admin.Controllers
{
    public class PersonnelController : Controller
    {
        private PersonnelService _personnelService;

        public PersonnelController()
        {
            _personnelService = new PersonnelService();
        }

        [HttpGet]
        public ActionResult Index()
        {
            //var personnelsViewModel = _personnelService.GetPersonnels().GetPersonnelViewModelByPersonnelModel(); // Havalı yöntem, direkt extensions metoda gönderiyorum ve return alıyorum

            var personnelsModel = _personnelService.GetPersonnels();
            var personnelsViewModel = personnelsModel.GetPersonnelViewModelsByPersonnelModels(); // personnelsModel'in içeriği doğrudan GetViewModelByModel() içerisine parametre olarak gidiyor. Clean code extension kullanımı.

            return View(model: personnelsViewModel);
        }

        [HttpGet]
        public ActionResult Create()
        {
            //var personnelViewModel = _personnelService.GetPersonnels().GetPersonnelViewModelsByPersonnelModels();

            return View();
        }

        [HttpPost]
        public ActionResult Create(PersonnelViewModel personnelViewModel)
        {
            if (!ModelState.IsValid)
                return View(personnelViewModel);

            var personnelModel = personnelViewModel.GetPersonnelModelByPersonnelViewModel();
            _personnelService.Create(personnelModel);

            return RedirectToAction("Index");
        }
    }
}