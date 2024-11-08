using FishingStore.Data;
using FishingStore.Data.Models;
using FishingStore.Web.ViewModels.Reel;
using FishingStore.Web.ViewModels.Rod;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FishingStore.Web.Controllers
{
    public class ReelController(FishingStoreContext dbContext) : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var reels = await dbContext
                .Reels
                .Where(r => r.IsDeleted == false)
                .AsNoTracking()
                .Select(r => new ReelIndexViewModel()
                {
                    FishingType = r.FishingType.ToString(),
                    Brand = r.Brand,
                    Model = r.Model,
                    Guid = r.Guid.ToString(),
                    ImageUrl = r.ImageUrl,
                    Price = r.Price,
                })
                .ToArrayAsync();

            return View(reels);
        }

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            Guid reelGuid = Guid.Empty;
            bool isGuidValid = this.IsGuidValid(id, ref reelGuid);

            if (!isGuidValid)
            {
                return this.RedirectToAction(nameof(Index));
            }

            Reel? reel = await dbContext
                .Reels
                .FirstOrDefaultAsync(x => x.Guid == reelGuid);

            if (reel == null)
            {
                return this.RedirectToAction(nameof(Index));
            }

            ReelDetailsViewModel model = new ReelDetailsViewModel()
            {
                Brand = reel.Brand,
                Model = reel.Model,
                SpoolCapacity = reel.SpoolCapacity,
                Description = reel.Description,
                FishingType = reel.FishingType.ToString(),
                Guid = reel.Guid.ToString(),
                ImageUrl = reel.ImageUrl,
                ReelSize = reel.ReelSize,
                Price = reel.Price,
            };

            return View(model);
        }
    }
}
