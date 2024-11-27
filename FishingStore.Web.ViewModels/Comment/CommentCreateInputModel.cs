using System.ComponentModel.DataAnnotations;

namespace FishingStore.Web.ViewModels.Comment
{
    public class CommentCreateInputModel
    {
        [Required] 
        public Guid FullSetGuid { get; set; }

        [Required]
        public string Content { get; set; } = string.Empty;
    }
}
