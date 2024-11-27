﻿namespace FishingStore.Web.ViewModels.Comment
{
    public class CommentViewModel
    {
        public string UserName { get; set; } = null!;
        public string Content { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
    }
}