using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using FishingStore.Data;
using FishingStore.Data.Models;
using FishingStore.Web.ViewModels.Comment;
using Microsoft.AspNetCore.Authorization;

namespace FishingStore.Web.Controllers
{
    public class CommentController : BaseController
    {
        private readonly FishingStoreContext dbContext;
        private readonly UserManager<ApplicationUser> userManager;

        public CommentController(FishingStoreContext dbContext, UserManager<ApplicationUser> userManager)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
        }

        // GET: /Comment/Index/{fullSetGuid}
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Index(string? id)
        {
            Guid fullSetGuid = Guid.Empty;
            bool isGuidValid = this.IsGuidValid(id, ref fullSetGuid);

            if (!isGuidValid)
            {
                return this.RedirectToAction(nameof(Index));
            }

            var fullSet = await dbContext.FullSets
                .Include(f => f.ApplicationUser)
                .Include(f => f.Rod)
                .Include(f => f.Reel)
                .FirstOrDefaultAsync(f => f.Guid == fullSetGuid);

            if (fullSet == null)
            {
                return RedirectToAction("Index", "FullSet");
            }

            var comments = await dbContext.Comments
                .Where(c => c.FullSetGuid == fullSetGuid)
                .Include(c => c.User)
                .Select(c => new CommentViewModel
                {
                    UserName = c.User.UserName,
                    Content = c.Content,
                    CreatedAt = c.CreatedAt
                })
                .ToListAsync();

            var model = new CommentIndexViewModel
            {
                FullSetGuid = fullSetGuid,
                FullSetName = $"{fullSet.Rod.Brand} {fullSet.Rod.Model} + {fullSet.Reel.Brand}",
                Comments = comments
            };

            return View(model);
        }

        // GET: /Comment/Create/{fullSetGuid}
        [HttpGet]
        [Authorize]
        public IActionResult Create(string? id)
        {
            Guid fullSetGuid = Guid.Empty;
            bool isGuidValid = this.IsGuidValid(id, ref fullSetGuid);

            if (!isGuidValid)
            {
                return this.RedirectToAction(nameof(Index));
            }

            var inputModel = new CommentCreateInputModel()
            {
                FullSetGuid = fullSetGuid!
            };

            return View(inputModel);
        }

        // POST: /Comment/Create
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CommentCreateInputModel inputModel)
        {
            if (ModelState.IsValid)
            {
                var currentUser = await userManager.GetUserAsync(User);

                var comment = new Comment
                {
                    FullSetGuid = inputModel.FullSetGuid,
                    UserGuid = currentUser!.Id,
                    Content = inputModel.Content
                };

                dbContext.Comments.Add(comment);
                await dbContext.SaveChangesAsync();

                return RedirectToAction("Index", "Comment",new { id = inputModel.FullSetGuid });
            }

            return View(inputModel);
        }
    }
}
