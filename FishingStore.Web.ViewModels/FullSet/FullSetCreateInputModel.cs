using System.ComponentModel.DataAnnotations;

namespace FishingStore.Web.ViewModels.FullSet
{
    public class FullSetCreateInputModel
    {
        public IEnumerable<Data.Models.Rod> Rods { get; set; } = new List<Data.Models.Rod>();
        public IEnumerable<Data.Models.Reel> Reels { get; set; } = new List<Data.Models.Reel>();
        public IEnumerable<Data.Models.Line> Lines { get; set; } = new List<Data.Models.Line>();
        public IEnumerable<Data.Models.Hook> Hooks { get; set; } = new List<Data.Models.Hook>();

        [Required(ErrorMessage = "Rod is required!")]
        public Guid RodGuid { get; set; }

        [Required(ErrorMessage = "Reel is required!")]
        public Guid ReelGuid { get; set; }

        [Required(ErrorMessage = "Line is required!")]
        public Guid LineGuid { get; set; }

        [Required(ErrorMessage = "Hook is required!")]
        public Guid HookGuid { get; set; }

        [Required] 
        public string IsPublic { get; set; } = null!;
    }
}
