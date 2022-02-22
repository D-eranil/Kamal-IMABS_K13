using CMS.DocumentEngine.Types.IMABS;
using Kentico.Content.Web.Mvc;

namespace IMABS.Models.Banners.PromotionsBanners
{
    public class PromotionsBannerViewModel
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string CTAButtonText { get; set; }
        public string CTAButtonLink { get; set; }
        public string ImageUrl { get; set; }

        public static PromotionsBannerViewModel GetViewModel(PromotionsBanner promotionsBanner)
        {
            return promotionsBanner == null ? null : new PromotionsBannerViewModel
            {
                CTAButtonLink = promotionsBanner.Fields.CTAButtonLink,
                CTAButtonText = promotionsBanner.Fields.CTAButtonText,
                ImageUrl = promotionsBanner.Fields.Image.GetPath(),
                SubTitle = promotionsBanner.Fields.SubTItle,
                Title = promotionsBanner.Fields.Title
            };
        }
    }
}
