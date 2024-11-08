using FishingStore.Data;
using FishingStore.Web.ViewModels.Hook;
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
