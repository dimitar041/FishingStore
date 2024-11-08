namespace FishingStore.Web.ViewModels.Rod
{
    public class RodDetailsViewModel
    {
        public required string Guid { get; set; }

        public required string Brand { get; set; }

        public required string Model { get; set; }

        public required string FishingType { get; set; }

        public decimal Price { get; set; }

        public int Action { get; set; }

        public int Length { get; set; }

        public required string Description { get; set; }

        public string? ImageUrl { get; set; }
    }
}
