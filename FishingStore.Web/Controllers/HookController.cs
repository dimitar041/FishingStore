using FishingStore.Data;
using FishingStore.Data.Models;
using FishingStore.Web.ViewModels.Hook;
using FishingStore.Web.ViewModels.Line;
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

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            Guid hookGuid = Guid.Empty;
            bool isGuidValid = this.IsGuidValid(id, ref hookGuid);

            if (!isGuidValid)
            {
                return this.RedirectToAction(nameof(Index));
            }

            Hook? hook = await dbContext
                .Hooks
                .FirstOrDefaultAsync(x => x.Guid == hookGuid);

            if (hook == null)
            {
                return this.RedirectToAction(nameof(Index));
            }

            HookDetailsViewModel model = new HookDetailsViewModel()
            {
                Brand = hook.Brand,
                Model = hook.Model,
                MaxWeight = hook.MaxWeight,
                Description = hook.Description,
                FishingType = hook.FishingType.ToString(),
                Guid = hook.Guid.ToString(),
                ImageUrl = hook.ImageUrl,
                Size = hook.Size,
                Price = hook.Price,
            };

            return View(model);
        }
    }
}
