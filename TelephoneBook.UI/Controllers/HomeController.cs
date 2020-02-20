using System.Collections.Generic;
using System.Web.Mvc;
using TelephoneBook.Entities;
using TelephoneBook.Services;
using TelephoneBook.UI.Extensions;
using Newtonsoft.Json;

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
            //var personnels = _personnelService.GetPersonnels().GetViewModelByModel(); // Havalı yöntem, direkt extensions metoda gönderiyorum ve return alıyorum

            var personnelsModel = _personnelService.GetPersonnels();
            var personnelsViewModel = personnelsModel.GetPersonnelViewModelsByPersonnelModels(); // personnelsModel'in içeriği doğrudan GetViewModelByModel() içerisine parametre olarak gidiyor. Clean code extension kullanımı.

            return View(model: personnelsViewModel);
        }

        [HttpGet]
        public ActionResult GetPersonnelsBySearchValue(string searchValue)
        {
            List<Personnel> personnels = _personnelService.GetPersonnelsBySearchValue(searchValue);
            //return new JsonResult { Data = personnels, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

            var list = JsonConvert.SerializeObject(personnels,
            Formatting.None,
            new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });

            return Content(list, "application/json");
        }

        [HttpGet]
        public ActionResult GetPersonnelById(int personnelId)
        {
            Personnel personnel = _personnelService.GetPersonnelById(personnelId);
            //return new JsonResult { Data = personnel, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

            var list = JsonConvert.SerializeObject(personnel,
            Formatting.None,
            new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });

            return Content(list, "application/json");
        }

    }
}