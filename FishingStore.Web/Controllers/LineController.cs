using FishingStore.Data;
using FishingStore.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FishingStore.Web.Controllers
{
    public class LineController(FishingStoreContext dbContext) : BaseController
    {
        public async Task<IActionResult> Index()
        {
            var lines = await dbContext
                .Lines
                .Where(l => l.IsDeleted == false)
                .AsNoTracking()
                .Select(l => new LineIndexViewModel()
                {
                    Description = l.Description,
                    Diameter = l.Diameter,
                    MaxWeight = l.MaxWeight,
                    FishingType = l.FishingType.ToString(),
                    Brand = l.Brand,
                    Model = l.Model,
                    Guid = l.Guid.ToString(),
                    ImageUrl = l.ImageUrl,
                    Price = l.Price,
                })
                .ToArrayAsync();

            return View(lines);
        }

        public async Task<IActionResult> Details()
        {
            return View();
        }
    }
}
