﻿using System.ComponentModel.DataAnnotations;

using FishingStore.Data.Models.Enums;
using static FishingStore.Common.EntityValidationConstants.Hook;
using static FishingStore.Common.ApplicationConstants;

namespace FishingStore.Data.Models
{
    public class Hook
    {
        public Hook()
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
        public int Size { get; set; }

        [Required]
        public double MaxWeight { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        public decimal Price { get; set; }

        [Required]
        public FishingType FishingType { get; set; }

        [MaxLength(ImgUrlMaxLength)]
        public string? ImageUrl { get; set; }

        public string DisplayName => $"{Brand} {Model} - ${Price}";

        public bool IsDeleted { get; set; }
    }
}
