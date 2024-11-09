namespace FishingStore.Web.ViewModels.FullSet
{
    public class FullSetIndexViewModel
    {
        public Guid FullSetGuid { get; set; }
        public Guid UserGuid { get; set; }
        public string UserName { get; set; } = string.Empty; 

        public string RodBrand { get; set; } = string.Empty;
        public string RodModel { get; set; } = string.Empty;
        public decimal RodPrice { get; set; }

        public string ReelBrand { get; set; } = string.Empty;
        public string ReelModel { get; set; } = string.Empty;
        public decimal ReelPrice { get; set; }

        public string LineBrand { get; set; } = string.Empty;
        public string LineModel { get; set; } = string.Empty;
        public decimal LinePrice { get; set; }

        public string HookBrand { get; set; } = string.Empty;
        public string HookModel { get; set; } = string.Empty;
        public decimal HookPrice { get; set; }

        public decimal TotalPrice { get; set; }  
        public decimal DiscountedPrice { get; set; }  
    }
}
