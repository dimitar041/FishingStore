namespace FishingStore.Web.ViewModels.Line
{
    public class LineDetailsViewModel
    {
        public required string Guid { get; set; }

        public required string Brand { get; set; }

        public required string Model { get; set; }

        public required string FishingType { get; set; }

        public decimal Price { get; set; }

        public double Diameter { get; set; }

        public double MaxWeight { get; set; }

        public required string Description { get; set; }

        public string? ImageUrl { get; set; }
    }
}
