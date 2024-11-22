namespace FishingStore.Web.ViewModels.FullSet
{
    public class FullSetCreateViewModel
    {
        public IEnumerable<Data.Models.Rod> Rods { get; set; } = new List<Data.Models.Rod>();
        public IEnumerable<Data.Models.Reel> Reels { get; set; } = new List<Data.Models.Reel>();
        public IEnumerable<Data.Models.Line> Lines { get; set; } = new List<Data.Models.Line>();
        public IEnumerable<Data.Models.Hook> Hooks { get; set; } = new List<Data.Models.Hook>();

        
        public Guid RodGuid { get; set; }
        public Guid ReelGuid { get; set; }
        public Guid LineGuid { get; set; }
        public Guid HookGuid { get; set; }
    }
}
