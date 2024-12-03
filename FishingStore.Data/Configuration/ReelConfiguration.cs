using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using FishingStore.Data.Models;
using FishingStore.Data.Models.Enums;
using static FishingStore.Common.EntityValidationConstants.Reel;

namespace FishingStore.Data.Configuration
{
    public class ReelConfiguration : IEntityTypeConfiguration<Reel>
    {
        public void Configure(EntityTypeBuilder<Reel> builder)
        {
            builder
                .Property(r => r.Price)
                .IsRequired()
                .HasColumnType("decimal(18, 2)");

            builder.HasData(SeedReels());
        }

        private static List<Reel> SeedReels()
        {
            var reels = new List<Reel>();

            var brands = new[] { "Shimano", "Abu Garcia", "Daiwa", "Penn", "Okuma", "Lew's", "Quantum" };
            var models = new[]
            {
            "Vanford 2500", "Silver Max 3000", "Fuego LT 2000", "Battle II 4000", "Avenger ABF6500",
            "Tournament MB 3000", "Smoke S3 2000", "Revo X 3000", "Tatula SV 2500", "KastKing Sharky III 3000"
            };

            var descriptions = new[]
            {
            "High-performance reel with exceptional durability and smooth drag.",
            "Versatile spinning reel for all types of fishing.",
            "Lightweight design that doesn’t compromise on strength.",
            "Engineered for precision casting and reliability.",
            "Perfect for both freshwater and saltwater environments.",
            "Features a high gear ratio for quick retrieves.",
            "Designed for professional anglers and enthusiasts alike.",
            "Robust construction with advanced corrosion resistance.",
            "Equipped with smooth ball bearings for a seamless experience.",
            "Great value for money with outstanding performance."
            };
            
            var reelSizes = new[] { 1000, 2000, 3000, 3500, 4000, 4500, 5000, 5500, 6000 };

            var rand = new Random();

            for (int i = 0; i < 50; i++)
            {
                var reel = new Reel
                {
                    Brand = brands[rand.Next(brands.Length)],
                    Model = models[rand.Next(models.Length)],
                    ReelSize = reelSizes[rand.Next(reelSizes.Length)],
                    SpoolCapacity = rand.Next(20, 80) * 10, 
                    Description = descriptions[rand.Next(descriptions.Length)],
                    Price = Math.Round((decimal)(rand.NextDouble() * 650 + 50), 2), 
                    FishingType = (FishingType)rand.Next(0, 4),
                    ImageUrl = NoImgReelUrl,
                    IsDeleted = false
                };

                reels.Add(reel);
            }

            return reels;
        }
    }
}
