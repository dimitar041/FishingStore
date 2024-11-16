using FishingStore.Web.ViewModels.Rod;

namespace FishingStore.Services.Data.Interfaces;

public interface IRodService
{
    Task<IEnumerable<RodIndexViewModel>> IndexGetAllAsync();

    Task<RodDetailsViewModel> GetRodDetailsByIdAsync(Guid id);
}