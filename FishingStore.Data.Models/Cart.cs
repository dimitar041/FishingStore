using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingStore.Data.Models
{
    public class Cart
    {
        public Cart()
        {
            Guid = Guid.NewGuid();
            Items = new List<CartItem>();
        }

        [Key]
        public Guid Guid { get; set; }

        [Required]
        public Guid UserGuid { get; set; }

        [ForeignKey(nameof(UserGuid))]
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;

        public virtual ICollection<CartItem> Items { get; set; }
    }
}
