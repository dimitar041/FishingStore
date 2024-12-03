using FishingStore.Data.Models;
using FishingStore.Data;
using FishingStore.Web.ViewModels.Cart;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FishingStore.Web.Controllers
{
    public class CartController(FishingStoreContext dbContext, UserManager<ApplicationUser> userManager)
        : BaseController
    {
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var currentUser = await userManager.GetUserAsync(User);
            var cart = await dbContext.Carts
                .Include(c => c.Items)
                .ThenInclude(ci => ci.FullSet)
                .ThenInclude(f => f.Rod)
                .Include(c => c.Items)
                .ThenInclude(ci => ci.FullSet)
                .ThenInclude(f => f.Reel)
                .Include(c => c.Items)
                .ThenInclude(ci => ci.FullSet)
                .ThenInclude(f => f.Line)
                .Include(c => c.Items)
                .ThenInclude(ci => ci.FullSet)
                .ThenInclude(f => f.Hook)
                .FirstOrDefaultAsync(c => c.UserGuid == currentUser!.Id);

            if (cart == null)
            {
                cart = new Cart { UserGuid = currentUser!.Id };
                dbContext.Carts.Add(cart);
                await dbContext.SaveChangesAsync();
            }

            var cartItems = cart.Items.Select(ci => new CartItemViewModel
            {
                CartItemGuid = ci.Guid,
                FullSetGuid = ci.FullSet.Guid,
                RodBrand = ci.FullSet.Rod.Brand,
                ReelBrand = ci.FullSet.Reel.Brand,
                LineBrand = ci.FullSet.Line.Brand,
                HookBrand = ci.FullSet.Hook.Brand,
                TotalPrice = ci.FullSet.Price ,
                Quantity = ci.Quantity
            }).ToList();

            return View(cartItems);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> AddToCart(string? id)
        {
            var currentUser = await userManager.GetUserAsync(User);

            Guid fullSetGuid = Guid.Empty;
            bool isGuidValid = this.IsGuidValid(id, ref fullSetGuid);


            if (!isGuidValid)
            {
                return this.RedirectToAction(nameof(Index));
            }

            var cart = await dbContext.Carts
                .Include(c => c.Items)
                .FirstOrDefaultAsync(c => c.UserGuid == currentUser!.Id);

            if (cart == null)
            {
                cart = new Cart { UserGuid = currentUser!.Id };
                dbContext.Carts.Add(cart);
                await dbContext.SaveChangesAsync();
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

            var cartItem = cart.Items.FirstOrDefault(ci => ci.FullSetGuid == fullSetGuid);

            if (cartItem == null)
            {
                cartItem = new CartItem
                {
                    FullSetGuid = fullSetGuid,
                    Quantity = 1,
                    CartGuid = cart.Guid
                };
                dbContext.CartItems.Add(cartItem);
            }
            else
            {
                cartItem.Quantity += 1;
            }

            await dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index), nameof(FullSet));
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> RemoveFromCart(string? id)
        {
            Guid cartItemGuid = Guid.Empty;
            bool isGuidValid = this.IsGuidValid(id, ref cartItemGuid);


            if (!isGuidValid)
            {
                return this.RedirectToAction(nameof(Index));
            }

            var cartItem = await dbContext.CartItems.FindAsync(cartItemGuid);

            if (cartItem != null)
            {
                dbContext.CartItems.Remove(cartItem);
                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
    }

}
