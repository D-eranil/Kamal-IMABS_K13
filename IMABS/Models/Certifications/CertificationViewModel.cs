using CMS.DocumentEngine.Types.IMABS;
using Kentico.Content.Web.Mvc;

namespace IMABS.Models.Certifications
{
    public class CertificationViewModel : CommonSettingsViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string DesktopBanner { get; set; }
        public string TabletBanner { get; set; }
        public string MobileBanner { get; set; }

        public string CertificationTitle { get; set; }
        public string CertificationContent { get; set; }
        public string TrainingTitle { get; set; }
        public string TrainingContent { get; set; }

        public string VideoPanelTitle { get; set; }
        public string VideoPanelSubTitle { get; set; }

        public static CertificationViewModel GetModel(Certification certification)
        {
            return certification == null ? null : new CertificationViewModel
            {
                DesktopBanner = certification.Fields.DesktopBanner?.GetPath(),
                MobileBanner = certification.Fields.MobileBanner?.GetPath(),
                TabletBanner = certification.Fields.TabletBanner?.GetPath(),
                VideoPanelSubTitle = certification.Fields.VideoPanelSubTitle,
                VideoPanelTitle = certification.Fields.VideoPanelTitle,
                Description = certification.Fields.Description,
                Name = certification.Fields.Name,
                CertificationContent = certification.Fields.Content,
                CertificationTitle = certification.Fields.Title,
                TrainingContent = certification.Fields.TrainingContent,
                TrainingTitle = certification.Fields.TrainingTitle,
                EnablePromotionsBanner = certification.Fields.EnablePromotionsBanner,
                AllowToViewInHeader = certification.Fields.AllowToViewInHeader,
                AllowToViewInFooter = certification.Fields.AllowToViewInFooter,
                EnableBreadcrumb = certification.Fields.EnableBreadcrumb,
                EnableCallToTactionBanner = certification.Fields.EnableCallToTactionBanner
            };
        }
    }
}
