using CMS.DocumentEngine.Types.IMABS;
using Kentico.Content.Web.Mvc;

namespace IMABS.Models.Banners
{
    public class BannerSectionViewModel
    {
        public string BannerHeading { get; set; }
        public string BannerBreadcrumbsTitle { get; set; }
        public bool IsActiveBanner { get; set; }
        public string BannerImage { get; set; }
        public string ButtonLinkName { get; set; }
        public string ButtonRedirectionUrl { get; set; }

        public static BannerSectionViewModel GetViewModel(BannerSection bannerSection)
        {
            return bannerSection == null ? null : new BannerSectionViewModel
            {
                BannerHeading = bannerSection.Fields.BannerHeading,
                BannerBreadcrumbsTitle = bannerSection.Fields.BannerBreadcrumbsTitle,
                IsActiveBanner = bannerSection.Fields.IsActiveBanner,
                BannerImage = bannerSection.Fields.BannerImage.GetPath(),
                ButtonLinkName = bannerSection.Fields.ButtonLinkName,
                ButtonRedirectionUrl = bannerSection.Fields.ButtonRedirectionUrl.ToString()
            };
        }
    }
}
