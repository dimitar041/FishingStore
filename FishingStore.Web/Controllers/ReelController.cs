using FishingStore.Data;
using FishingStore.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FishingStore.Web.Controllers
{
    public class ReelController(FishingStoreContext dbContext) : BaseController
    {
        public async Task<IActionResult> Index()
        {
            var reels = await dbContext
                .Reels
                .Where(r => r.IsDeleted == false)
                .AsNoTracking()
                .Select(r => new ReelIndexViewModel()
                {
                    Description = r.Description,
                    ReelSize = r.ReelSize,
                    SpoolCapacity = r.SpoolCapacity,
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

        public async Task<IActionResult> Details()
        {
            return View();
        }
    }
}
