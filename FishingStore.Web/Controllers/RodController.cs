using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using FishingStore.Data;
using FishingStore.Data.Models;
using FishingStore.Services.Data.Interfaces;
using FishingStore.Web.ViewModels.Rod;


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

            RodEditInputModel? model = await dbContext
                .Rods
                .Where(r => r.IsDeleted == false && r.Guid == rodGuid)
                .AsNoTracking()
                .Select(r => new RodEditInputModel()
                {
                    Brand = r.Brand,
                    Model = r.Model,
                    Action = r.Action,
                    Description = r.Description,
                    FishingType = r.FishingType,
                    ImageUrl = r.ImageUrl,
                    Guid = rodGuid,
                    Length = r.Length,
                    Price = r.Price,
                })
                .FirstOrDefaultAsync();

            if (model == null)
            {
                return this.RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        [HttpPost]
#pragma warning disable MVC1004
        public async Task<IActionResult> Edit(string? id, RodEditInputModel model)
#pragma warning restore MVC1004
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var rod = await dbContext.Rods.FindAsync(id);

            if (rod == null)
            {
                throw new ArgumentException("Invalid id");
            }

            rod.Brand = model.Brand;
            rod.Model = model.Model;
            rod.Length = model.Length;
            rod.Action = model.Action;
            rod.Description = model.Description;
            rod.Price = model.Price;
            rod.FishingType = model.FishingType;
            rod.ImageUrl = model.ImageUrl;

            await dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Details), nameof(Rod), new RouteValueDictionary { { "id", $"{id}" } });
        }
    }
}
