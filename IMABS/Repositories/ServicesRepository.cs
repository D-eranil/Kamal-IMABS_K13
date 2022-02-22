using CMS.DocumentEngine.Types.IMABS;
using CMS.SiteProvider;
using System.Collections.Generic;
using System.Linq;

namespace IMABS.Repositories
{
    public class ServicesRepository
    {
        private readonly string mCultureName = "en-US";
        private readonly bool mLatestVersionEnabled = true;

        //public ServicesRepository(string cultureName, bool latestVersionEnabled)
        //{
        //    mCultureName = cultureName;
        //    mLatestVersionEnabled = latestVersionEnabled;
        //}
        public List<Services> GetPages()
        {
            var data = ServicesProvider
                       .GetServices()
                       .LatestVersion(mLatestVersionEnabled)
                       .Published(mLatestVersionEnabled)
                       .OnSite(SiteContext.CurrentSiteName)
                       .Culture(mCultureName)
                       .CombineWithDefaultCulture()
                       .OrderBy("NodeOrder")
                       .ToList();
            return data;
        }

    }
}
