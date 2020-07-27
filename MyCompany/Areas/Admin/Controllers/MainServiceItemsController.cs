using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain;
using MyCompany.Domain.Entities;
using MyCompany.Service;
using System;
using System.IO;

namespace MyCompany.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MainServiceItemsController : Controller
    {
        private readonly DataManager dataManager;
        public MainServiceItemsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        
        public IActionResult Redirect()
        {
            return View("MainPagePostsView", dataManager.MainServiceItems.GetServiceItems());
        }

        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new MainServiceItem() : dataManager.MainServiceItems.GetServiceItemById(id);
            return View(entity);
        }


        [HttpPost]
        public IActionResult Edit(MainServiceItem mainServiceItem)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(mainServiceItem);
        }
        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.MainServiceItems.DeleteServiceItem(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}