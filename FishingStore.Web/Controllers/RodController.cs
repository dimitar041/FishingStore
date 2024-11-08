using FishingStore.Data;
using FishingStore.Data.Models;
using FishingStore.Web.ViewModels.Rod;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FishingStore.Web.Controllers
{
    public class RodController(FishingStoreContext dbContext) : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var rods = await dbContext
                .Rods
                .Where(r => r.IsDeleted == false)
                .AsNoTracking()
                .Select(r => new RodIndexViewModel()
                {
                    FishingType = r.FishingType.ToString(),
                    Brand = r.Brand,
                    Model = r.Model,
                    Guid = r.Guid.ToString(),
                    ImageUrl = r.ImageUrl,
                    Price = r.Price,
                })
                .ToArrayAsync();

            return View(rods);
        }

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            Guid rodGuid = Guid.Empty;
            bool isGuidValid = this.IsGuidValid(id, ref rodGuid);

            if (!isGuidValid)
            {
                return this.RedirectToAction(nameof(Index));
            }
                
            Rod? rod = await dbContext
                .Rods
                .FirstOrDefaultAsync(x => x.Guid == rodGuid);

            if (rod == null)
            {
                return this.RedirectToAction(nameof(Index));
            }

            RodDetailsViewModel model = new RodDetailsViewModel()
            {
                Brand = rod.Brand,
                Model = rod.Model,
                Action = rod.Action,
                Description = rod.Description,
                FishingType = rod.FishingType.ToString(),
                Guid = rod.Guid.ToString(),
                ImageUrl = rod.ImageUrl,
                Length = rod.Length,
                Price = rod.Price,
            };

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            Guid rodGuid = Guid.Empty;
            bool isGuidValid = this.IsGuidValid(id, ref rodGuid);

            if (!isGuidValid)
            {
                return this.RedirectToAction(nameof(Index));
            }

            RodEditViewModel? model = await dbContext
                .Rods
                .Where(r => r.IsDeleted == false && r.Guid == rodGuid)
                .AsNoTracking()
                .Select(r => new RodEditViewModel()
                {
                    Brand = r.Brand,
                    Model = r.Model,
                    Action = r.Action,
                    Description = r.Description,
                    FishingType = r.FishingType,
                    ImageUrl = r.ImageUrl,
                    Guid = r.Guid,
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
        public async Task<IActionResult> Edit(RodEditViewModel model, string id)
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
