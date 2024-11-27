using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using FishingStore.Data;
using FishingStore.Data.Models;
using FishingStore.Web.ViewModels.FullSet;

namespace FishingStore.Web.Controllers
{
    public class FullSetController(FishingStoreContext dbContext, UserManager<ApplicationUser> userManager) : BaseController
    {
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var currentUser = await userManager.GetUserAsync(User);

            var fullSets = await dbContext.FullSets
                .Where(f => (f.UserGuid == currentUser!.Id || f.IsPublic == true) && f.IsDeleted == false)  
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
                RodBrand = f.Rod.Brand,
                RodModel = f.Rod.Model,
                RodPrice = f.Rod.Price,
                ReelBrand = f.Reel.Brand,
                ReelModel = f.Reel.Model,
                ReelPrice = f.Reel.Price,
                LineBrand = f.Line.Brand,
                LineModel = f.Line.Model,
                LinePrice = f.Line.Price,
                HookBrand = f.Hook.Brand,
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

            var viewModel = new FullSetCreateInputModel
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
        public async Task<IActionResult> Create(FullSetCreateInputModel viewModel)
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
                    Price = CalculateTotalPrice(viewModel),
                    IsPublic = bool.Parse(viewModel.IsPublic)
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

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Delete(string? id)
        {
            Guid fullSetGuid = Guid.Empty;
            bool isGuidValid = this.IsGuidValid(id, ref fullSetGuid);

            if (!isGuidValid)
            {
                return this.RedirectToAction(nameof(Index));
            }

            var fullSet = await dbContext
                .FullSets
                .Include(f => f.ApplicationUser)
                .Include(f => f.Rod)
                .Include(f => f.Reel)
                .Include(f => f.Line)
                .Include(f => f.Hook)
                .FirstOrDefaultAsync(f => f.Guid == fullSetGuid);

            if (fullSet == null)
            {
                throw new ArgumentException("No Full Set with this id found!");
            }

            FullSetIndexViewModel model = new FullSetIndexViewModel()
            {
                UserGuid = fullSet.UserGuid,
                UserName = fullSet.ApplicationUser.UserName!,

                FullSetGuid = fullSet.Guid,
                RodBrand = fullSet.Rod.Brand,
                RodModel = fullSet.Rod.Model,
                RodPrice = fullSet.Rod.Price,
                ReelBrand = fullSet.Reel.Brand,
                ReelModel = fullSet.Reel.Model,
                ReelPrice = fullSet.Reel.Price,
                LineBrand = fullSet.Line.Brand,
                LineModel = fullSet.Line.Model,
                LinePrice = fullSet.Line.Price,
                HookBrand = fullSet.Hook.Brand,
                HookModel = fullSet.Hook.Model,
                HookPrice = fullSet.Hook.Price,
                TotalPrice = fullSet.Price / 0.9m,
                DiscountedPrice = fullSet.Price
            };

            return View(model); 
        }

        [HttpPost, ActionName("Delete")]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string? id)
        {
            Guid fullSetGuid = Guid.Empty;
            bool isGuidValid = this.IsGuidValid(id, ref fullSetGuid);

            if (!isGuidValid)
            {
                return this.RedirectToAction(nameof(Index));
            }

            var fullSet = await dbContext
                .FullSets
                .FirstOrDefaultAsync(f => f.Guid == fullSetGuid);

            if (fullSet == null)
            {
                throw new ArgumentException("No Full Set with this id found!");
            }

            fullSet.IsDeleted = true;

            await dbContext.SaveChangesAsync(); 

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit(string? id)
        {
            Guid fullSetGuid = Guid.Empty;
            bool isGuidValid = this.IsGuidValid(id, ref fullSetGuid);

            if (!isGuidValid)
            {
                return this.RedirectToAction(nameof(Index));
            }


            var fullSet = await dbContext.FullSets
                .Include(f => f.Rod)
                .Include(f => f.Reel)
                .Include(f => f.Line)
                .Include(f => f.Hook)
                .FirstOrDefaultAsync(f => f.Guid == fullSetGuid);

            if (fullSet == null)
            {
                return NotFound();
            }


            var rods = await dbContext.Rods.ToListAsync();
            var reels = await dbContext.Reels.ToListAsync();
            var lines = await dbContext.Lines.ToListAsync();
            var hooks = await dbContext.Hooks.ToListAsync();


            var viewModel = new FullSetCreateInputModel
            {
                Rods = rods,
                Reels = reels,
                Lines = lines,
                Hooks = hooks,
                RodGuid = fullSet.RodGuid,
                ReelGuid = fullSet.ReelGuid,
                LineGuid = fullSet.LineGuid,
                HookGuid = fullSet.HookGuid
            };

            return View(viewModel);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string? id, FullSetCreateInputModel viewModel)
        {
            Guid fullSetGuid = Guid.Empty;
            bool isGuidValid = this.IsGuidValid(id, ref fullSetGuid);

            if (!isGuidValid)
            {
                return this.RedirectToAction(nameof(Index));
            }

            if (ModelState.IsValid)
            {
                var fullSet = await dbContext.FullSets
                    .FirstOrDefaultAsync(f => f.Guid == fullSetGuid);

                if (fullSet == null)
                {
                    throw new ArgumentException("Full set with this Id not found!");
                }

                fullSet.RodGuid = viewModel.RodGuid;
                fullSet.ReelGuid = viewModel.ReelGuid;
                fullSet.LineGuid = viewModel.LineGuid;
                fullSet.HookGuid = viewModel.HookGuid;
                fullSet.Price = CalculateTotalPrice(viewModel);

                await dbContext.SaveChangesAsync();

                return RedirectToAction(nameof(Index)); 
            }


            viewModel.Rods = await dbContext.Rods.ToListAsync();
            viewModel.Reels = await dbContext.Reels.ToListAsync();
            viewModel.Lines = await dbContext.Lines.ToListAsync();
            viewModel.Hooks = await dbContext.Hooks.ToListAsync();

            return View(viewModel);
        }



        private decimal CalculateTotalPrice(FullSetCreateInputModel viewModel)
        {
            var rodPrice = dbContext.Rods.FirstOrDefault(r => r.Guid == viewModel.RodGuid)!.Price;
            var reelPrice = dbContext.Reels.FirstOrDefault(r => r.Guid == viewModel.ReelGuid)!.Price;
            var linePrice = dbContext.Lines.FirstOrDefault(l => l.Guid == viewModel.LineGuid)!.Price;
            var hookPrice = dbContext.Hooks.FirstOrDefault(h => h.Guid == viewModel.HookGuid)!.Price;

            return (rodPrice + reelPrice + linePrice + hookPrice) * 0.9m;
        }
    }
}
