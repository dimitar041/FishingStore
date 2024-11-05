using FishingStore.Data;
using FishingStore.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FishingStore.Web.Controllers
{
    public class RodController(FishingStoreContext dbContext) : BaseController
    {
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

        public async Task<IActionResult> Details()
        {
            return View();
        }
    }
}
