using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using FishingStore.Data.Models;
using FishingStore.Data.Models.Enums;
using static FishingStore.Common.EntityValidationConstants.Line;

namespace FishingStore.Data.Configuration
{
    public class LineConfiguration : IEntityTypeConfiguration<Line>
    {
        public void Configure(EntityTypeBuilder<Line> builder)
        {
            builder
                .Property(r => r.Price)
                .IsRequired()
                .HasColumnType("decimal(18, 2)");

            builder.HasData(SeedLines());
        }

        private static List<Line> SeedLines()
        {
            var lines = new List<Line>();

            var brands = new[] { "Berkley", "SpiderWire", "Sufix", "Seaguar", "P-Line", "Yo-Zuri" };
            var models = new[]
            {
            "Trilene XL", "Stealth Braid", "Advanced Fluorocarbon", "Super Slick", "CXX Premium",
            "Tatsu Fluorocarbon", "Braid X8", "InvizX", "Ultra 8", "Tensile Line"
        };

            var descriptions = new[]
            {
            "Strong and reliable for various fishing conditions.",
            "Designed for maximum sensitivity and low visibility.",
            "Ideal for both freshwater and saltwater fishing.",
            "Resistant to abrasions and knots, ensuring durability.",
            "Offers exceptional strength-to-diameter ratio.",
            "Lightweight and easy to handle for beginners.",
            "Perfect for casting long distances with ease.",
            "Enhanced toughness for heavy cover and big fish.",
            "Provides superior knot strength and stability.",
            "Advanced technology for better performance in the water."
        };

            var rand = new Random();

            for (int i = 0; i < 30; i++)
            {
                var line = new Line
                {
                    Brand = brands[rand.Next(brands.Length)],
                    Model = models[rand.Next(models.Length)],
                    Diameter = Math.Round(rand.NextDouble() * 0.9 + 0.1, 2), 
                    MaxWeight = Math.Round(rand.NextDouble() * 18 + 2, 2),
                    LineType = (LineType)rand.Next(0, 2), 
                    Description = descriptions[rand.Next(descriptions.Length)],
                    Price = Math.Round((decimal)(rand.NextDouble() * 50), 2), 
                    FishingType = (FishingType)rand.Next(0, 4), 
                    ImageUrl = NoImgLineUrl, 
                    IsDeleted = false
                };

                lines.Add(line);
            }

            return lines;
        }
    }
}
