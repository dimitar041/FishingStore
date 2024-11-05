using FishingStore.Data;
using FishingStore.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FishingStore.Web.Controllers
{
    public class HookController(FishingStoreContext dbContext) : BaseController
    {
        public async Task<IActionResult> Index()
        {
            var hooks = await dbContext
                .Hooks
                .Where(h => h.IsDeleted == false)
                .AsNoTracking()
                .Select(h => new HookIndexViewModel()
                {
                    Description = h.Description,
                    Size = h.Size,
                    MaxWeight = h.MaxWeight,
                    FishingType = h.FishingType.ToString(),
                    Brand = h.Brand,
                    Model = h.Model,
                    Guid = h.Guid.ToString(),
                    ImageUrl = h.ImageUrl,
                    Price = h.Price,
                })
                .ToArrayAsync();

            return View(hooks);
        }

        public async Task<IActionResult> Details()
        {
            return View();
        }
    }
}
