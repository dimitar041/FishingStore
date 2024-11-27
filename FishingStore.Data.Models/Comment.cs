using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using static FishingStore.Common.EntityValidationConstants.Comment;
namespace FishingStore.Data.Models
{
    public class Comment
    {
        [Key]
        public Guid Guid { get; set; }

        [Required]
        public Guid FullSetGuid { get; set; }

        [ForeignKey(nameof(FullSetGuid))]
        public virtual FullSet FullSet { get; set; } = null!;

        [Required]
        public Guid UserGuid { get; set; }

        [ForeignKey(nameof(UserGuid))] 
        public virtual ApplicationUser User { get; set; } = null!;

        [Required]
        [MaxLength(ContentMaxLength)]
        public string Content { get; set; } = null!;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
