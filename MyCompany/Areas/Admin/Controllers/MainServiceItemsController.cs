using Microsoft.AspNetCore.Hosting;
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
        private readonly IWebHostEnvironment hostingEnvironment;
        public MainServiceItemsController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
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

        /*
        [HttpPost]
        public IActionResult Edit(MainServiceItem mainServiceItem)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(mainServiceItem);
        }*/

        [HttpPost]
        public IActionResult Edit(MainServiceItem model, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    model.TitleImagePath = titleImageFile.FileName;
                    using (var stream = new FileStream(Path.Combine(hostingEnvironment.WebRootPath, "images/", titleImageFile.FileName), FileMode.Create))
                    {
                        titleImageFile.CopyTo(stream);
                    }
                }
                dataManager.MainServiceItems.SaveServiceItem(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.MainServiceItems.DeleteServiceItem(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}