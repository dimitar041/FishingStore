using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using FishingStore.Data;
using FishingStore.Data.Models;
using FishingStore.Services.Data.Interfaces;
using FishingStore.Web.ViewModels.Rod;
using FishingStore.Web.ViewModels.Reel;
using static FishingStore.Common.EntityValidationConstants;
using Rod = FishingStore.Data.Models.Rod;


namespace FishingStore.Web.Controllers
{
    public class RodController(FishingStoreContext dbContext, IRodService rodService) : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<RodIndexViewModel> rods =
                await rodService.IndexGetAllAsync();

            return View(rods);
        }

        [HttpGet]
        public async Task<IActionResult> Details(string? id)
        {
            Guid rodGuid = Guid.Empty;
            bool isGuidValid = this.IsGuidValid(id, ref rodGuid);

            if (!isGuidValid)
            {
                return this.RedirectToAction(nameof(Index));
            }

            RodDetailsViewModel? model =
                await rodService.GetRodDetailsByIdAsync(rodGuid);

            if (model == null!)
            {
                return this.RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string? id)
        {
            Guid rodGuid = Guid.Empty;
            bool isGuidValid = this.IsGuidValid(id, ref rodGuid);

            if (!isGuidValid)
            {
                return this.RedirectToAction(nameof(Index));
            }

            Rod? rod = await dbContext
                .Rods
                .FirstOrDefaultAsync(x => x.Guid == rodGuid && x.IsDeleted == false);

            if (rod == null)
            {
                return this.RedirectToAction(nameof(Index));
            }

            var model = new RodAddInputModel()
            {
                Brand = rod.Brand,
                Model = rod.Model,
                Length = rod.Length,
                Action = rod.Action,
                Description = rod.Description,
                Price = rod.Price,
                FishingType = rod.FishingType,
                ImageUrl = rod.ImageUrl
            };


            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string? id, RodAddInputModel inputModel)
        {
            if (!ModelState.IsValid)
            {
                return View(inputModel);
            }


            Rod? rod = await dbContext
                .Rods
                .FirstOrDefaultAsync(x => x.Guid.ToString() == id && x.IsDeleted == false);

            if (rod == null)
            {
                throw new ArgumentException("Invalid Id");
            }

            rod.Brand = inputModel.Brand;
            rod.Model = inputModel.Model;
            rod.Length = inputModel.Length;
            rod.Action = inputModel.Action;
            rod.Description = inputModel.Description;
            rod.Price = inputModel.Price;
            rod.FishingType = inputModel.FishingType;
            rod.ImageUrl = inputModel.ImageUrl;

            await dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Details), nameof(Rod), new RouteValueDictionary { { "id", $"{id}" } });
        }
    }
}
