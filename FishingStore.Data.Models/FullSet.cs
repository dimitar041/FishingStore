using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static FishingStore.Common.ApplicationConstants;

namespace FishingStore.Data.Models
{
    public class FullSet
    {
        public FullSet()
        {
            Guid = Guid.NewGuid();
        }

        [Key]
        public Guid Guid { get; set; }

        [Required]
        public Guid UserGuid { get; set; }

        [ForeignKey(nameof(UserGuid))]
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;

        public Guid? RodGuid { get; set; }

        [ForeignKey(nameof(RodGuid))]
        public virtual Rod? Rod { get; set; }

        public Guid? ReelGuid { get; set; }

        [ForeignKey(nameof(ReelGuid))]
        public virtual Reel? Reel { get; set; }

        public Guid? LineGuid { get; set; }

        [ForeignKey(nameof(LineGuid))]
        public virtual Line? Line { get; set; }

        public Guid? HookGuid { get; set; }

        [ForeignKey(nameof(HookGuid))] 
        public virtual Hook? Hook { get; set; }

        public decimal Price { get; set; }

        [MaxLength(ImgUrlMaxLength)]
        public string? ImageUrl { get; set; }

        public bool IsDeleted { get; set; }
    }
}
