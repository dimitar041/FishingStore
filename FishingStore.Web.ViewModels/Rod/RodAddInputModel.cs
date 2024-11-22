using System.ComponentModel.DataAnnotations;

using FishingStore.Data.Models.Enums;
using static FishingStore.Common.EntityValidationConstants.Rod;
using static FishingStore.Common.ApplicationConstants;

namespace FishingStore.Web.ViewModels.Rod
{
    public class RodAddInputModel
    {
        [Required(ErrorMessage = "Brand is required!")]
        [MinLength(BrandMinLength, ErrorMessage = "Brand min length is 3 symbols!")]
        [MaxLength(BrandMaxLength, ErrorMessage = "Brand max length is 30 symbols!")]
        public string Brand { get; set; } = null!;

        [Required(ErrorMessage = "Model is required!")]
        [MinLength(ModelMinLength, ErrorMessage = "Model min length is 3 symbols!")]
        [MaxLength(ModelMaxLength, ErrorMessage = "Model max length is 30 symbols!")]
        public string Model { get; set; } = null!;

        [Required(ErrorMessage = "Length is required!")]
        public int Length { get; set; }

        [Required(ErrorMessage = "Action is required!")]
        public int Action { get; set; }

        [Required(ErrorMessage = "Description is required!")]
        [MinLength(DescriptionMinLength, ErrorMessage = "Description min length is 10 symbols!")]
        [MaxLength(DescriptionMaxLength, ErrorMessage = "Description max length is 1000 symbols!")]
        public string Description { get; set; } = null!;

        [Required(ErrorMessage = "Price is required!")]
        [Range(typeof(decimal), PriceMinValue, PriceMaxValue, ErrorMessage = "Price must be in range 1.00 - 900.00!")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Fishing Type is required!")]
        public FishingType FishingType { get; set; }

        [MaxLength(ImgUrlMaxLength, ErrorMessage = "Image Url max length is 200 symbols!")]
        public string? ImageUrl { get; set; }
    }
}
