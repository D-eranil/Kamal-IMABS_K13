using CMS.DocumentEngine.Types.IMABS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMABS.Models.Leaderships
{
    public class LeadershipViewModel : CommonSettingsViewModel
    {
        public string LeadershipPageName { get; set; }
        public string PageHeading { get; set; }
        public string PageSubHeading { get; set; }

        public static LeadershipViewModel GetViewModel(Leadership leadership)
        {
            var model = leadership == null ? null : new LeadershipViewModel
            {
                LeadershipPageName = leadership.Fields.PageName,
                PageHeading = leadership.Fields.PageHeading,
                PageSubHeading = leadership.Fields.PageSubHeading,
                EnableBreadcrumb = leadership.Fields.EnableBreadcrumb,
                EnableCallToTactionBanner = leadership.Fields.EnableCallToTactionBanner,
                AllowToViewInFooter = leadership.Fields.AllowToViewInFooter,
                AllowToViewInHeader = leadership.Fields.AllowToViewInHeader,
                EnablePromotionsBanner = leadership.Fields.EnablePromotionsBanner
            };

            return model;
        }
    }
}
