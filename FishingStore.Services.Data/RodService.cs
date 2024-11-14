using FishingStore.Services.Mapping;
using FishingStore.Data.Models;
using FishingStore.Data.Repository.Interfaces;
using FishingStore.Services.Data.Interfaces;
using FishingStore.Web.ViewModels.Rod;
using Microsoft.EntityFrameworkCore;

namespace FishingStore.Services.Data
{
    public class RodService : IRodService
    {
        private IRepository<Rod, Guid> rodRepository;

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
                .To<RodIndexViewModel>()
                .ToArrayAsync();

            return rods;
        }

        public Task<RodDetailsViewModel> RodDetailsAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
