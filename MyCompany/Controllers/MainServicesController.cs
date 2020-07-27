using System;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain;

namespace MyCompany.Controllers
{
    public class MainServicesController : Controller
    {
        private readonly DataManager dataManager;

        public MainServicesController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.MainServiceItems.GetServiceItemById(id));
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageNews"); // або MainPAge замість PageServices
            return View(dataManager.MainServiceItems.GetServiceItems());
        }
    }
}