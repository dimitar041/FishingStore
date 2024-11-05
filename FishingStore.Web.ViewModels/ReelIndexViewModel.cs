namespace FishingStore.Web.ViewModels
{
    public class ReelIndexViewModel
    {
        public required string Guid { get; set; }

        public required string Brand { get; set; }

        public required string Model { get; set; }

        public required string FishingType { get; set; }

        public decimal Price { get; set; }

        public int ReelSize { get; set; }

        public int SpoolCapacity { get; set; }

        public required string Description { get; set; }

        public string? ImageUrl { get; set; }
    }
}
