using Microsoft.EntityFrameworkCore;

using FishingStore.Data.Models;
using FishingStore.Data.Repository.Interfaces;
using FishingStore.Services.Data.Interfaces;
using FishingStore.Web.ViewModels.Rod;

namespace FishingStore.Services.Data
{
    public class RodService : BaseService, IRodService
    {
        private readonly IRepository<Rod, Guid> rodRepository;

        public RodService(IRepository<Rod, Guid> rodRepository)
        {
            this.rodRepository = rodRepository;
        }


        public async Task<IEnumerable<RodIndexViewModel>> IndexGetAllAsync()
        {
            RodIndexViewModel[] rods = await this.rodRepository
                .GetAllAttached()
                .Where(r => r.IsDeleted == false)
                .AsNoTracking()
                .Select(r => new RodIndexViewModel()
                {
                    Brand = r.Brand,
                    FishingType = r.FishingType.ToString(),
                    Guid = r.Guid.ToString(),
                    ImageUrl = r.ImageUrl,
                    Model = r.Model,
                    Price = r.Price
                })
                .ToArrayAsync();

            return rods;
        }

        public async Task<RodDetailsViewModel> GetRodDetailsByIdAsync(Guid id)
        {
            Rod? rod = await this.rodRepository
                .GetByIdAsync(id);


            RodDetailsViewModel? model = null;
            if (rod != null)
            {
                model = new RodDetailsViewModel()
                {
                    Brand = rod.Brand,
                    Model = rod.Model,
                    Action = rod.Action,
                    Description = rod.Description,
                    FishingType = rod.FishingType.ToString(),
                    Guid = rod.Guid.ToString(),
                    ImageUrl = rod.ImageUrl,
                    Length = rod.Length,
                    Price = rod.Price,
                };
            }

            return model!;
        }
    }
}
