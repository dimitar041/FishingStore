using FishingStore.Data;
using FishingStore.Data.Models;
using FishingStore.Web.ViewModels;
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
                    Description = r.Description,
                    Action = r.Action,
                    FishingType = r.FishingType.ToString(),
                    Brand = r.Brand,
                    Model = r.Model,
                    Guid = r.Guid.ToString(),
                    ImageUrl = r.ImageUrl,
                    Length = r.Length,
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

            RodIndexViewModel model = new RodIndexViewModel()
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

        public async Task<IActionResult> Edit()
        {
            return View();
        }
    }
}
