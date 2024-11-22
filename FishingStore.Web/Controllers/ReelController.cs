using FishingStore.Data;
using FishingStore.Data.Models;
using FishingStore.Web.ViewModels.Reel;
using FishingStore.Web.ViewModels.Rod;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RouteValueDictionary = Microsoft.AspNetCore.Routing.RouteValueDictionary;

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
        public IActionResult Add()
        {
            var model = new ReelAddInputModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(ReelAddInputModel inputModel)
        {
            if (!ModelState.IsValid)
            {
                return View(inputModel);
            }

            var reel = new Reel
            {
                Brand = inputModel.Brand,
                Model = inputModel.Model,
                ReelSize = inputModel.ReelSize,
                SpoolCapacity = inputModel.SpoolCapacity,
                Description = inputModel.Description,
                Price = inputModel.Price,
                FishingType = inputModel.FishingType,
                ImageUrl = inputModel.ImageUrl
            };

            await dbContext.Reels.AddAsync(reel);
            await dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Details), new { id = reel.Guid });
        }


        [HttpGet]
        public async Task<IActionResult> Details(string? id)
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

        [HttpGet]
        public async Task<IActionResult> Edit(string? id)
        {
            Guid reelGuid = Guid.Empty;
            bool isGuidValid = this.IsGuidValid(id, ref reelGuid);

            if (!isGuidValid)
            {
                return this.RedirectToAction(nameof(Index));
            }

            Reel? reel = await dbContext
                .Reels
                .FirstOrDefaultAsync(x => x.Guid == reelGuid && x.IsDeleted == false);

            if (reel == null)
            {
                return this.RedirectToAction(nameof(Index));
            }

            var model = new ReelAddInputModel()
            {
                Brand = reel.Brand,
                Model = reel.Model,
                ReelSize = reel.ReelSize,
                SpoolCapacity = reel.SpoolCapacity,
                Description = reel.Description,
                Price = reel.Price,
                FishingType = reel.FishingType,
                ImageUrl = reel.ImageUrl
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string? id, ReelAddInputModel inputModel)
        {
            if (!ModelState.IsValid)
            {
                return View(inputModel);
            }

            Reel? reel = await dbContext
                .Reels
                .FirstOrDefaultAsync(x => x.Guid.ToString() == id && x.IsDeleted == false);

            if (reel == null)
            {
                throw new ArgumentException("Invalid Id");
            }

            reel.Brand = inputModel.Brand;
            reel.Model = inputModel.Model;
            reel.ReelSize = inputModel.ReelSize;
            reel.SpoolCapacity = inputModel.SpoolCapacity;
            reel.Description = inputModel.Description;
            reel.Price = inputModel.Price;
            reel.FishingType = inputModel.FishingType;
            reel.ImageUrl = inputModel.ImageUrl;

            await dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Details), new RouteValueDictionary { { "id", $"{id}" } });
        }

    }
}
