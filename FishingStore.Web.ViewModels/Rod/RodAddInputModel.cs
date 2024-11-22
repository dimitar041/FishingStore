using System.ComponentModel.DataAnnotations;

using FishingStore.Data.Models.Enums;
using static FishingStore.Common.EntityValidationConstants.Rod;
using static FishingStore.Common.ApplicationConstants;

namespace FishingStore.Web.ViewModels.Rod
{
    public class RodAddInputModel
    {
        [Required]
        [MinLength(BrandMinLength)]
        [MaxLength(BrandMaxLength)]
        public string Brand { get; set; } = null!;

        [Required]
        [MinLength(ModelMinLength)]
        [MaxLength(ModelMaxLength)]
        public string Model { get; set; } = null!;

        [Required]
        public int Length { get; set; }

        [Required]
        public int Action { get; set; }

        [Required]
        [MinLength(DescriptionMinValue)]
        [MaxLength(DescriptionMaxValue)]
        public string Description { get; set; } = null!;

        [Required]
        [Range(typeof(decimal), PriceMinValue, PriceMaxValue)]
        public decimal Price { get; set; }

        [Required]
        public FishingType FishingType { get; set; }

        [MaxLength(ImgUrlMaxLength)]
        public string? ImageUrl { get; set; }
    }
}
