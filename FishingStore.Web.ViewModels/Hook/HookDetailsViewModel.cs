namespace FishingStore.Web.ViewModels.Hook
{
    public class HookDetailsViewModel
    {
        public required string Guid { get; set; }

        public required string Brand { get; set; }

        public required string Model { get; set; }

        public required string FishingType { get; set; }

        public decimal Price { get; set; }

        public double MaxWeight { get; set; }

        public int Size { get; set; }

        public required string Description { get; set; }

        public string? ImageUrl { get; set; }
    }
}
