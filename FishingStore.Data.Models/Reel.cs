using System.ComponentModel.DataAnnotations;

using FishingStore.Data.Models.Enums;
using static FishingStore.Common.EntityValidationConstants.Reel;

namespace FishingStore.Data.Models
{
    public class Reel
    {
        public Reel()
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
        public int ReelSize { get; set; }

        [Required]
        public int SpoolCapacity { get; set; }

        [Required]
        [MaxLength(DescriptionMaxValue)]
        public string Description { get; set; } = null!;

        [Required]
        public decimal Price { get; set; }

        [Required]
        public FishingType FishingType { get; set; }
    }
}
