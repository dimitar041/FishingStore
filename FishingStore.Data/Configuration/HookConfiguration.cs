using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using FishingStore.Data.Models;
using FishingStore.Data.Models.Enums;
using static FishingStore.Common.EntityValidationConstants.Hook;

namespace FishingStore.Data.Configuration
{
    public class HookConfiguration : IEntityTypeConfiguration<Hook>
    {
        public void Configure(EntityTypeBuilder<Hook> builder)
        {
            builder
                .Property(r => r.Price)
                .IsRequired()
                .HasColumnType("decimal(18, 2)");

            builder.HasData(SeedHooks());
        }

        private static List<Hook> SeedHooks()
        {
            var hooks = new List<Hook>();

            var brands = new[] { "Eagle Claw", "Gamakatsu", "Mustad", "Owner", "VMC", "Berkley" };
            var models = new[]
            {
                "Circle Hook", "Treble Hook", "Jig Hook", "Baitholder Hook", "Octopus Hook",
                "Swimbait Hook", "Drop Shot Hook", "Wacky Hook", "Inline Hook", "Offset Hook"
            };

            var descriptions = new[]
            {
                "Strong and durable hook designed for big catches.",
                "Ideal for freshwater and saltwater fishing.",
                "Precision design for increased hooking efficiency.",
                "Perfect for a variety of bait types.",
                "Corrosion-resistant for long-lasting use.",
                "Versatile hook for various fishing techniques.",
                "Engineered for maximum strength and performance.",
                "Designed for optimal bait presentation.",
                "Lightweight yet strong for easy casting.",
                "Perfect for targeting specific fish species."
            };

            var rand = new Random();

            for (int i = 0; i < 50; i++)
            {
                var hook = new Hook
                {
                    Brand = brands[rand.Next(brands.Length)],
                    Model = models[rand.Next(models.Length)],
                    Size = rand.Next(1, 16), 
                    MaxWeight = Math.Round(rand.NextDouble() * 18 + 2, 2), 
                    Description = descriptions[rand.Next(descriptions.Length)],
                    Price = Math.Round((decimal)(rand.NextDouble() * 9 ), 2), 
                    FishingType = (FishingType)rand.Next(0, 4), 
                    ImageUrl = NoImgHookUrl, 
                    IsDeleted = false
                };

                hooks.Add(hook);
            }

            return hooks;
        }
    }
}
