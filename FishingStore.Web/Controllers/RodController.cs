using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using FishingStore.Data;
using FishingStore.Services.Data.Interfaces;
using FishingStore.Web.ViewModels.Rod;
using Rod = FishingStore.Data.Models.Rod;
using FishingStore.Web.ViewModels.Reel;


namespace FishingStore.Web.Controllers
{
    public class RodController(FishingStoreContext dbContext, IRodService rodService) : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<RodIndexViewModel> rods =
                await rodService.IndexGetAllAsync();

            return View(rods);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new RodAddInputModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(RodAddInputModel inputModel)
        {
            if (!ModelState.IsValid)
            {
                return View(inputModel);
            }

            await rodService.AddRodAsync(inputModel);

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public async Task<IActionResult> Details(string? id)
        {
            Guid rodGuid = Guid.Empty;
            bool isGuidValid = this.IsGuidValid(id, ref rodGuid);

            if (!isGuidValid)
            {
                return this.RedirectToAction(nameof(Index));
            }

            RodDetailsViewModel? model =
                await rodService.GetRodDetailsByIdAsync(rodGuid);

            if (model == null!)
            {
                return this.RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string? id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return RedirectToAction(nameof(Index));
            }

            Guid rodGuid = Guid.Empty;
            bool isGuidValid = this.IsGuidValid(id, ref rodGuid);

            if (!isGuidValid)
            {
                return RedirectToAction(nameof(Index));
            }

            var model = await rodService.GetRodForEditAsync(rodGuid);

            if (model == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string? id, RodAddInputModel inputModel)
        {
            Guid rodGuid = Guid.Empty;
            bool isGuidValid = this.IsGuidValid(id, ref rodGuid);

            if (!isGuidValid)
            {
                return this.RedirectToAction(nameof(Index));
            }

            if (!ModelState.IsValid)
            {
                return View(inputModel);
            }

            await rodService.UpdateRodAsync(rodGuid, inputModel);

            return RedirectToAction(nameof(Details), nameof(Rod), new RouteValueDictionary { { "id", $"{id}" } });
        }
    }
}
