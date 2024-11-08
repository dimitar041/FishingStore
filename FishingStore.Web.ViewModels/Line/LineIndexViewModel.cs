namespace FishingStore.Web.ViewModels.Line
{
    public class LineIndexViewModel
    {
        public required string Guid { get; set; }

        public required string Brand { get; set; }

        public required string Model { get; set; }

        public required string FishingType { get; set; }

        public decimal Price { get; set; }

        public string? ImageUrl { get; set; }
    }
}
