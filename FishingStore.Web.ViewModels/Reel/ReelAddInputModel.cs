using FishingStore.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using static FishingStore.Common.EntityValidationConstants.Reel;
using static FishingStore.Common.ApplicationConstants;


namespace FishingStore.Web.ViewModels.Reel
{
    public class ReelAddInputModel
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
        public int ReelSize { get; set; }

        [Required]
        public int SpoolCapacity { get; set; }

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