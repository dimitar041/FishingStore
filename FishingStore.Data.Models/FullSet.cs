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

        [Required]
        public Guid RodGuid { get; set; }

        [ForeignKey(nameof(RodGuid))]
        public virtual Rod Rod { get; set; }

        [Required]
        public Guid ReelGuid { get; set; }

        [ForeignKey(nameof(ReelGuid))]
        public virtual Reel Reel { get; set; }

        [Required]
        public Guid LineGuid { get; set; }

        [ForeignKey(nameof(LineGuid))]
        public virtual Line Line { get; set; }

        [Required]
        public Guid HookGuid { get; set; }

        [ForeignKey(nameof(HookGuid))] 
        public virtual Hook Hook { get; set; }

        [Required]
        public decimal Price { get; set; }

        public bool IsDeleted { get; set; }
    }
}
