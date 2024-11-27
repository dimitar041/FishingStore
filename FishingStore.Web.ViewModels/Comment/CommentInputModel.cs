namespace FishingStore.Web.ViewModels.Comment
{
    public class CommentViewModel
    {
        public Guid CommentGuid { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}