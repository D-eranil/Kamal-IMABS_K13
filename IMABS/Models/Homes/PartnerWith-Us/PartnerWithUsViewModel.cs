using CMS.DocumentEngine.Types.IMABS;
using Kentico.Content.Web.Mvc;

namespace IMABS.Models.Homes.PartnerWith_Us
{
    public class PartnerWithUsViewModel
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string SectionImage { get; set; }
        public string CTAButtonTitle { get; set; }
        public string CTAButtonLink { get; set; }

        public static PartnerWithUsViewModel GetViewModel(PartnerWithUs partnerWithUs)
        {
            return partnerWithUs == null ? null : new PartnerWithUsViewModel
            {
                CTAButtonLink = partnerWithUs.Fields.CTAButtonLink,
                CTAButtonTitle = partnerWithUs.Fields.CTAButtonTitle,
                Description = partnerWithUs.Fields.Description,
                SectionImage = partnerWithUs.Fields.SectionImage.GetPath(),
                SubTitle = partnerWithUs.Fields.SubTitle,
                Title = partnerWithUs.Fields.Title
            };
        }
    }
}
