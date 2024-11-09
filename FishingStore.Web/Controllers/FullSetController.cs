using FishingStore.Data;
using FishingStore.Data.Models;
using FishingStore.Web.ViewModels.FullSet;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FishingStore.Web.Controllers
{
    public class FullSetController(FishingStoreContext dbContext, UserManager<ApplicationUser> userManager) : BaseController
    {
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var currentUser = await userManager.GetUserAsync(User);

            var fullSets = await dbContext.FullSets
                .Where(f => f.UserGuid == currentUser!.Id)  
                .Include(f => f.ApplicationUser)         
                .Include(f => f.Rod)                     
                .Include(f => f.Reel)
                .Include(f => f.Line)
                .Include(f => f.Hook)
                .ToListAsync();

            var fullSetViewModels = fullSets.Select(f => new FullSetIndexViewModel()
            {
                UserGuid = f.UserGuid,
                UserName = f.ApplicationUser.UserName!,

                FullSetGuid = f.Guid,
                RodBrand = f.Rod!.Brand,
                RodModel = f.Rod.Model,
                RodPrice = f.Rod.Price,
                ReelBrand = f.Reel!.Brand,
                ReelModel = f.Reel.Model,
                ReelPrice = f.Reel.Price,
                LineBrand = f.Line!.Brand,
                LineModel = f.Line.Model,
                LinePrice = f.Line.Price,
                HookBrand = f.Hook!.Brand,
                HookModel = f.Hook.Model,
                HookPrice = f.Hook.Price,
                TotalPrice = f.Price / 0.9m,
                DiscountedPrice = f.Price
            }).ToList();

            return View(fullSetViewModels);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Create()
        {
            var rods = await dbContext.Rods.ToListAsync();
            var reels = await dbContext.Reels.ToListAsync();
            var lines = await dbContext.Lines.ToListAsync();
            var hooks = await dbContext.Hooks.ToListAsync();

            var viewModel = new FullSetCreateViewModel
            {
                Rods = rods,
                Reels = reels,
                Lines = lines,
                Hooks = hooks
            };

            return View(viewModel);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FullSetCreateViewModel viewModel)
        {

            var currentUser = await userManager.GetUserAsync(User);

            if (ModelState.IsValid)
            {
                var fullSet = new FullSet
                {
                    UserGuid = currentUser!.Id, 
                    RodGuid = viewModel.RodGuid,
                    ReelGuid = viewModel.ReelGuid,
                    LineGuid = viewModel.LineGuid,
                    HookGuid = viewModel.HookGuid,
                    Price = CalculateTotalPrice(viewModel) 
                };

                dbContext.FullSets.Add(fullSet);
                await dbContext.SaveChangesAsync();

                return RedirectToAction(nameof(Index)); 
            }

            viewModel.Rods = await dbContext.Rods.ToListAsync();
            viewModel.Reels = await dbContext.Reels.ToListAsync();
            viewModel.Lines = await dbContext.Lines.ToListAsync();
            viewModel.Hooks = await dbContext.Hooks.ToListAsync();

            return View(viewModel);
        }

        private decimal CalculateTotalPrice(FullSetCreateViewModel viewModel)
        {
            var rodPrice = dbContext.Rods.FirstOrDefault(r => r.Guid == viewModel.RodGuid)?.Price ?? 0;
            var reelPrice = dbContext.Reels.FirstOrDefault(r => r.Guid == viewModel.ReelGuid)?.Price ?? 0;
            var linePrice = dbContext.Lines.FirstOrDefault(l => l.Guid == viewModel.LineGuid)?.Price ?? 0;
            var hookPrice = dbContext.Hooks.FirstOrDefault(h => h.Guid == viewModel.HookGuid)?.Price ?? 0;

            return (rodPrice + reelPrice + linePrice + hookPrice) * 0.9m;
        }
    }
}
