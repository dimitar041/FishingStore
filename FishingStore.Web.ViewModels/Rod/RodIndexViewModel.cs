using FishingStore.Data.Models.Enums;

namespace FishingStore.Web.ViewModels.Rod
{
    public class RodIndexViewModel
    {
        public required string Guid { get; set; }

        public required string Brand { get; set; }

        public required string Model { get; set; }

        public required string FishingType { get; set; }

        public decimal Price { get; set; }

        public string? ImageUrl { get; set; }
    }
}
