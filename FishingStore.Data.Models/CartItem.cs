using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FishingStore.Data.Models
{
    public class CartItem
    {
        [Key]
        public Guid Guid { get; set; }

        [Required]
        public Guid CartGuid { get; set; }

        [ForeignKey(nameof(CartGuid))]
        public virtual Cart Cart { get; set; } = null!;

        [Required]
        public Guid FullSetGuid { get; set; }

        [ForeignKey(nameof(FullSetGuid))] 
        public virtual FullSet FullSet { get; set; } = null!;

        public int Quantity { get; set; }
    }
}
