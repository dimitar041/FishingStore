using FishingStore.Web.ViewModels.Rod;

namespace FishingStore.Services.Data.Interfaces
{
    public interface IRodService
    {
        Task<IEnumerable<RodIndexViewModel>> IndexGetAllAsync();

        Task<RodDetailsViewModel?> GetRodDetailsByIdAsync(Guid id);

        Task<bool> AddRodAsync(RodAddInputModel inputModel);

        Task<RodAddInputModel?> GetRodForEditAsync(Guid rodGuid);

        Task<bool> UpdateRodAsync(Guid id, RodAddInputModel inputModel);

        Task<RodDeleteViewModel> GetRodDeleteViewModelByIdAsync(Guid rodGuid);

        Task<bool> DeleteRodAsync(Guid id);
    }
}