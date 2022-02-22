using CMS.DocumentEngine.Types.IMABS;
using CMS.SiteProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMABS.Repositories
{
    public class BannersRepository
    {
        private readonly string mCultureName = "en-US";
        private readonly bool mLatestVersionEnabled = true;
        /// <summary>
        /// Returns an object representing the Call To Action Banner.
        /// </summary>
        public CallToActionBanner GetCurrentCallToActionBanner()
        {
            return CallToActionBannerProvider.GetCallToActionBanners()
               .LatestVersion(mLatestVersionEnabled)
               .Published(mLatestVersionEnabled)
               .OnSite(SiteContext.CurrentSiteName)
               .Culture(mCultureName)
               .CombineWithDefaultCulture()
               .TopN(1);
        }

        public CallToActionBanner GetCurrentCallToActionBanner(Guid guid)
        {
            return CallToActionBannerProvider.GetCallToActionBanners()
               .LatestVersion(mLatestVersionEnabled)
               .Published(mLatestVersionEnabled)
               .Culture(mCultureName)
               .CombineWithDefaultCulture()
               .OnSite(SiteContext.CurrentSiteName)
               .Where(x=>x.DocumentGUID == guid)
               .FirstOrDefault();
        }

        /// <summary>
        /// Returns an object representing the about page.
        /// </summary>
        public PromotionsBanner GetCurrentPromotionsBanner()
        {
            return PromotionsBannerProvider.GetPromotionsBanners()
               .LatestVersion(mLatestVersionEnabled)
               .Published(mLatestVersionEnabled)
               .OnSite(SiteContext.CurrentSiteName)
               .Culture(mCultureName)
               .CombineWithDefaultCulture()
               .TopN(1);
        }
    }
}
