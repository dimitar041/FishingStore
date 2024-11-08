using FishingStore.Data;
using FishingStore.Data.Models;
using FishingStore.Web.ViewModels.Line;
using FishingStore.Web.ViewModels.Reel;
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

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            Guid lineGuid = Guid.Empty;
            bool isGuidValid = this.IsGuidValid(id, ref lineGuid);

            if (!isGuidValid)
            {
                return this.RedirectToAction(nameof(Index));
            }

            Line? line = await dbContext
                .Lines
                .FirstOrDefaultAsync(x => x.Guid == lineGuid);

            if (line == null)
            {
                return this.RedirectToAction(nameof(Index));
            }

            LineDetailsViewModel model = new LineDetailsViewModel()
            {
                Brand = line.Brand,
                Model = line.Model,
                MaxWeight = line.MaxWeight,
                Description = line.Description,
                FishingType = line.FishingType.ToString(),
                Guid = line.Guid.ToString(),
                ImageUrl = line.ImageUrl,
                Diameter = line.Diameter,
                Price = line.Price,
            };

            return View(model);
        }
    }
}
