namespace FishingStore.Web.ViewModels.Comment
{
    public class CommentIndexViewModel
    {
        public Guid FullSetGuid { get; set; }

        public string FullSetName { get; set; } = null!;

        public List<CommentViewModel> Comments { get; set; } = new List<CommentViewModel>();
    }
}
