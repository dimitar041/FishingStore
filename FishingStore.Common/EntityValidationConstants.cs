namespace FishingStore.Common
{
    public static class EntityValidationConstants
    {
        public static class Rod
        {
            public const int BrandMinLength = 3;
            public const int BrandMaxLength = 30;
            public const int ModelMinLength = 3;
            public const int ModelMaxLength = 35;
            public const string PriceMinValue = "1.00";
            public const string PriceMaxValue = "900.00";
            public const int DescriptionMinValue = 10;
            public const int DescriptionMaxValue = 1000;
            public const string NoImgRodUrl = "~/img/no-img-rod-url.jpg";
        }

        public static class Reel
        {
            public const int BrandMinLength = 3;
            public const int BrandMaxLength = 30;
            public const int ModelMinLength = 3;
            public const int ModelMaxLength = 35;
            public const string PriceMinValue = "1.00";
            public const string PriceMaxValue = "700.00";
            public const int DescriptionMinValue = 10;
            public const int DescriptionMaxValue = 1000;
            public const string NoImgReelUrl = "~/img/no-img-rod-url.jpg";
        }

        public static class Line
        {
            public const int BrandMinLength = 3;
            public const int BrandMaxLength = 30;
            public const int ModelMinLength = 3;
            public const int ModelMaxLength = 35;
            public const string PriceMinValue = "1.00";
            public const string PriceMaxValue = "50.00";
            public const int DescriptionMinValue = 5;
            public const int DescriptionMaxValue = 200;
            public const string NoImgLineUrl = "~/img/no-img-line-url.png";
        }

        public static class Hook
        {
            public const int BrandMinLength = 3;
            public const int BrandMaxLength = 30;
            public const int ModelMinLength = 3;
            public const int ModelMaxLength = 35;
            public const string PriceMinValue = "1.00";
            public const string PriceMaxValue = "10.00";
            public const int DescriptionMinValue = 5;
            public const int DescriptionMaxValue = 100;
            public const string NoImgHookUrl = "~/img/no-img-hook-url.jpg";
        }
    }
}
