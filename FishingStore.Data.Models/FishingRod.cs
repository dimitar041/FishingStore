using System.ComponentModel.DataAnnotations;

namespace FishingStore.Data.Models
{
    public class FishingRod
    {
        public FishingRod()
        {
            Guid = Guid.NewGuid();
        }

        [Key]
        public Guid Guid { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string Price { get; set; }
    }
}
