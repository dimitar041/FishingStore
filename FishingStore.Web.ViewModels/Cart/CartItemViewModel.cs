namespace FishingStore.Web.ViewModels.Cart
{
    public class CartItemViewModel
    {
        public Guid CartItemGuid { get; set; }
        public Guid FullSetGuid { get; set; }
        public string RodBrand { get; set; } = null!;
        public string ReelBrand { get; set; } = null!;
        public string LineBrand { get; set; } = null!; 
        public string HookBrand { get; set; } = null!;
        public decimal TotalPrice { get; set; }
        public int Quantity { get; set; }
    }

}
