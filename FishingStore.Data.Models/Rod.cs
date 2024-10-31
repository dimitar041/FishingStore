using System.ComponentModel.DataAnnotations;

using FishingStore.Data.Models.Enums;
using static FishingStore.Common.EntityValidationConstants.Rod;

namespace FishingStore.Data.Models
{
    public class Rod
    {
        public Rod()
        {
            Guid = Guid.NewGuid();
        }

        [Key]
        public Guid Guid { get; set; }

        [Required]
        [MaxLength(BrandMaxLength)]
        public string Brand { get; set; } = null!;

        [Required] 
        [MaxLength(ModelMaxLength)] 
        public string Model { get; set; } = null!;

        [Required]
        public double Length { get; set; }

        [Required]
        public double Action { get; set; }

        [Required] 
        [MaxLength(DescriptionMaxValue)]
        public string Description { get; set; } = null!;

        [Required]
        public decimal Price { get; set; }

        [Required]
        public FishingType FishingType { get; set; }
    }
}
