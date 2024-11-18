namespace FishingStore.Web.ViewModels.FullSet
{
    public class FullSetIndexViewModel
    {
        public Guid FullSetGuid { get; set; }
        public Guid UserGuid { get; set; }
        public required string UserName { get; set; } 

        public required string RodBrand { get; set; } 
        public required string RodModel { get; set; } 
        public decimal RodPrice { get; set; }

        public required string ReelBrand { get; set; } 
        public required string ReelModel { get; set; } 
        public decimal ReelPrice { get; set; }

        public required string LineBrand { get; set; } 
        public required string LineModel { get; set; } 
        public decimal LinePrice { get; set; }

        public required string HookBrand { get; set; } 
        public required string HookModel { get; set; } 
        public decimal HookPrice { get; set; }

        public decimal TotalPrice { get; set; }  
        public decimal DiscountedPrice { get; set; }  
    }
}
