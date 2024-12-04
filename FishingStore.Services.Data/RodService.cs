using Microsoft.EntityFrameworkCore;
using FishingStore.Data.Models;
using FishingStore.Data.Repository.Interfaces;
using FishingStore.Services.Data.Interfaces;
using FishingStore.Web.ViewModels.Rod;
using Microsoft.Extensions.Logging;

namespace FishingStore.Services.Data
{
    public class RodService(IRepository<Rod, Guid> rodRepository, ILogger<RodService> logger) : IRodService
    {
        public async Task<IEnumerable<RodIndexViewModel>> IndexGetAllAsync()
        {
            try
            {
                var rods = await rodRepository
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
            catch (Exception ex)
            {
                logger.LogError(ex, "An error occurred while fetching rods.");
                return Enumerable.Empty<RodIndexViewModel>();
            }
        }

        public async Task<RodDetailsViewModel?> GetRodDetailsByIdAsync(Guid id)
        {
            try
            {
                Rod? rod = await rodRepository.GetByIdAsync(id);

                if (rod == null || rod.IsDeleted)
                {
                    return null;
                }

                return new RodDetailsViewModel()
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
            catch (Exception ex)
            {
                logger.LogError(ex, "An error occurred while fetching rod details.");
                return null;
            }
        }

        public async Task<bool> AddRodAsync(RodAddInputModel inputModel)
        {
            try
            {
                var rod = new Rod
                {
                    Brand = inputModel.Brand,
                    Model = inputModel.Model,
                    Action = inputModel.Action,
                    Length = inputModel.Length,
                    Description = inputModel.Description,
                    Price = inputModel.Price,
                    FishingType = inputModel.FishingType,
                    ImageUrl = inputModel.ImageUrl
                };

                await rodRepository.AddAsync(rod);
                return true;
            }
            catch (DbUpdateException ex)
            {
                logger.LogError(ex, "An error occurred while adding the rod.");
                return false;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "An unexpected error occurred while adding the rod.");
                return false;
            }
        }

        public async Task<RodAddInputModel?> GetRodForEditAsync(Guid rodGuid)
        {

            try
            {
                var rod = await rodRepository.GetByIdAsync(rodGuid);

            if (rod == null)
            {
                return null; 
            }

            var model = new RodAddInputModel
            {
                Brand = rod.Brand,
                Model = rod.Model,
                Action = rod.Action,
                Length = rod.Length,
                Description = rod.Description,
                Price = rod.Price,
                FishingType = rod.FishingType,
                ImageUrl = rod.ImageUrl
            };

            return model;
            }
            catch (Exception ex) 
            {
                 logger.LogError(ex, $"Error occurred while fetching rod for edit with Guid: {rodGuid}");

                throw new InvalidOperationException($"An error occurred while retrieving the rod with Guid {rodGuid}.", ex);
            }

        }

        public async Task<bool> UpdateRodAsync(Guid id, RodAddInputModel inputModel)
        {
            try
            {
                Rod? rod = await rodRepository.GetByIdAsync(id);

                if (rod == null || rod.IsDeleted)
                {
                    return false;
                }

                rod.Brand = inputModel.Brand;
                rod.Model = inputModel.Model;
                rod.Action = inputModel.Action;
                rod.Length = inputModel.Length;
                rod.Description = inputModel.Description;
                rod.Price = inputModel.Price;
                rod.FishingType = inputModel.FishingType;
                rod.ImageUrl = inputModel.ImageUrl;

                return await rodRepository.UpdateAsync(rod);
            }
            catch (DbUpdateException ex)
            {
                logger.LogError(ex, "An error occurred while updating the rod.");
                return false;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "An unexpected error occurred while updating the rod.");
                return false;
            }
        }

        // Delete a rod (soft delete)
        public async Task<bool> DeleteRodAsync(Guid id)
        {
            try
            {
                Rod? rod = await rodRepository.GetByIdAsync(id);

                if (rod == null || rod.IsDeleted)
                {
                    return false;
                }

                rod.IsDeleted = true;

                return await rodRepository.UpdateAsync(rod);
            }
            catch (DbUpdateException ex)
            {
                logger.LogError(ex, "An error occurred while deleting the rod.");
                return false;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "An unexpected error occurred while deleting the rod.");
                return false;
            }
        }
    }
}
