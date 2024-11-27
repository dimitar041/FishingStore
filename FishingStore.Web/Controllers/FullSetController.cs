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

            ViewData.Add("CurrentUserId", currentUser!.Id.ToString()); 

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

            var inputModel = new FullSetCreateInputModel
            {
                Rods = rods,
                Reels = reels,
                Lines = lines,
                Hooks = hooks
            };

            return View(inputModel);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FullSetCreateInputModel inputModel)
        {

            var currentUser = await userManager.GetUserAsync(User);

            if (ModelState.IsValid)
            {
                var fullSet = new FullSet
                {
                    UserGuid = currentUser!.Id, 
                    RodGuid = inputModel.RodGuid,
                    ReelGuid = inputModel.ReelGuid,
                    LineGuid = inputModel.LineGuid,
                    HookGuid = inputModel.HookGuid,
                    Price = CalculateTotalPrice(inputModel),
                    IsPublic = bool.Parse(inputModel.IsPublic)
                };

                dbContext.FullSets.Add(fullSet);
                await dbContext.SaveChangesAsync();

                return RedirectToAction(nameof(Index)); 
            }

            inputModel.Rods = await dbContext.Rods.ToListAsync();
            inputModel.Reels = await dbContext.Reels.ToListAsync();
            inputModel.Lines = await dbContext.Lines.ToListAsync();
            inputModel.Hooks = await dbContext.Hooks.ToListAsync();

            return View(inputModel);
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

            var currentUser = await userManager.GetUserAsync(User);

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


            if (fullSet.UserGuid != currentUser!.Id)
            {
                return RedirectToAction("Index");
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

            var currentUser = await userManager.GetUserAsync(User);

            var fullSet = await dbContext
                .FullSets
                .FirstOrDefaultAsync(f => f.Guid == fullSetGuid);

            if (fullSet == null)
            {
                throw new ArgumentException("No Full Set with this id found!");
            }

            if (fullSet.UserGuid != currentUser!.Id)
            {
                return RedirectToAction("Index");
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

            var currentUser = await userManager.GetUserAsync(User); 


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

            if (fullSet.UserGuid != currentUser!.Id)
            {
                return RedirectToAction("Index");
            }


            var rods = await dbContext.Rods.ToListAsync();
            var reels = await dbContext.Reels.ToListAsync();
            var lines = await dbContext.Lines.ToListAsync();
            var hooks = await dbContext.Hooks.ToListAsync();


            var inputModel = new FullSetCreateInputModel
            {
                Rods = rods,
                Reels = reels,
                Lines = lines,
                Hooks = hooks,
                RodGuid = fullSet.RodGuid,
                ReelGuid = fullSet.ReelGuid,
                LineGuid = fullSet.LineGuid,
                HookGuid = fullSet.HookGuid,
                IsPublic = fullSet.IsPublic.ToString()
            };

            return View(inputModel);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string? id, FullSetCreateInputModel inputModel)
        {
            Guid fullSetGuid = Guid.Empty;
            bool isGuidValid = this.IsGuidValid(id, ref fullSetGuid);



            if (!isGuidValid)
            {
                return this.RedirectToAction(nameof(Index));
            }


            var currentUser = await userManager.GetUserAsync(User);

            if (ModelState.IsValid)
            {
                var fullSet = await dbContext.FullSets
                    .FirstOrDefaultAsync(f => f.Guid == fullSetGuid);

                if (fullSet == null)
                {
                    throw new ArgumentException("Full set with this Id not found!");
                }


                if (fullSet.UserGuid != currentUser!.Id)
                {
                    return RedirectToAction("Index");
                }

                fullSet.RodGuid = inputModel.RodGuid;
                fullSet.ReelGuid = inputModel.ReelGuid;
                fullSet.LineGuid = inputModel.LineGuid;
                fullSet.HookGuid = inputModel.HookGuid;
                fullSet.Price = CalculateTotalPrice(inputModel);
                fullSet.IsPublic = bool.Parse(inputModel.IsPublic);

                await dbContext.SaveChangesAsync();

                return RedirectToAction(nameof(Index)); 
            }


            inputModel.Rods = await dbContext.Rods.ToListAsync();
            inputModel.Reels = await dbContext.Reels.ToListAsync();
            inputModel.Lines = await dbContext.Lines.ToListAsync();
            inputModel.Hooks = await dbContext.Hooks.ToListAsync();

            return View(inputModel);
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
