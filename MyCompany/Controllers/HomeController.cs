using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain;
using MyCompany.Domain.Entities;
using System;
using MyCompany.Service;

namespace MyCompany.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        /*public IActionResult Index()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageIndex"));
        }*/

        public IActionResult Contacts()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageContacts"));
        }

        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.ServiceItems.GetServiceItemById(id));
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageIndex");
            return View(dataManager.ServiceItems.GetServiceItems());
        }
        
        [HttpPost]
        public IActionResult SendForm(DataContact model)
        {
            if (ModelState.IsValid)
            {
                dataManager.DataContacts.SaveDataContacts(model);
                return View(model);
            }
            
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
     


    }
}
