using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using FishingStore.Data.Models;
using FishingStore.Data.Models.Enums;
using static FishingStore.Common.EntityValidationConstants.Rod;

namespace FishingStore.Data.Configuration
{
    public class RodConfiguration : IEntityTypeConfiguration<Rod>
    {
        public void Configure(EntityTypeBuilder<Rod> builder)
        {
            builder.HasData(SeedRods());
        }

        private static List<Rod> SeedRods()
        {
            var rods = new List<Rod>();

            var brands = new[] { "Shimano", "Abu Garcia", "Daiwa", "Penn", "Okuma" };
            var models = new[]
            {
                "Stradic CI4+", "Revo SX", "Tatula LT", "Battle II", "Celilo",
                "Catana", "Veritas", "Procyon", "Phantom", "Tsunami"
            };
            var lengths = new[] { 300, 330, 360, 390, 420, 450 };

            var descriptions = new[]
            {
                "A versatile rod perfect for carp fishing.",
                "Designed for spinning, lightweight and durable.",
                "Great sensitivity for feeder fishing.",
                "Excellent for float fishing with enhanced accuracy."
            };

            var rand = new Random();

            for (int i = 0; i < 25; i++)
            {
                var rod = new Rod
                {
                    Brand = brands[rand.Next(brands.Length)],
                    Model = models[rand.Next(models.Length)],
                    Length = lengths[rand.Next(lengths.Length)],
                    Action = rand.Next(1, 20) * 10,
                    Description = descriptions[rand.Next(descriptions.Length)],
                    Price = Math.Round((decimal)(rand.NextDouble() * 850 + 50), 2),
                    FishingType = (FishingType)rand.Next(0, 4),
                    ImageUrl = NoImgRodUrl,
                    IsDeleted = false
                };

                rods.Add(rod);
            }

            return rods;
        }
    }
}
