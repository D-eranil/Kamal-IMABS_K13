using CMS.DocumentEngine.Types.IMABS;
using Kentico.Content.Web.Mvc;

namespace IMABS.Models.BlockquoteContents
{
    public class BlockquoteContentViewModel : CommonSettingsViewModel
    {
        public string PageName { get; set; }
        public string Subheading { get; set; }
        public string PageContent { get; set; }
        public string BlockquoteText { get; set; }
        public string DesktopBanner { get; set; }
        public string TabletBanner { get; set; }
        public string MobileBanner { get; set; }

        public string PageCTABanner { get; set; }
        public static BlockquoteContentViewModel GetViewModel(BlockquoteContent whyIngramMicro)
        {
            var model = whyIngramMicro == null ? null : new BlockquoteContentViewModel
            {
                PageName = whyIngramMicro.Fields.PageName,
                Subheading = whyIngramMicro.Fields.Subheading,
                PageContent = whyIngramMicro.Fields.PageContent,
                BlockquoteText = whyIngramMicro.Fields.BlockquoteText,
                EnableBreadcrumb = whyIngramMicro.Fields.EnableBreadcrumb,
                EnableCallToTactionBanner = whyIngramMicro.Fields.EnableCallToTactionBanner,
                EnablePromotionsBanner = whyIngramMicro.Fields.EnablePromotionsBanner,
                AllowToViewInFooter = whyIngramMicro.Fields.AllowToViewInFooter,
                AllowToViewInHeader = whyIngramMicro.Fields.AllowToViewInHeader,
                DesktopBanner = whyIngramMicro.Fields.DesktopBanner.GetPath(),
                MobileBanner = whyIngramMicro.Fields.MobileBanner.GetPath(),
                TabletBanner = whyIngramMicro.Fields.TabletBanner.GetPath(),
                PageCTABanner = whyIngramMicro.Fields.CTABanner
            };

            return model;
        }
    }
}

