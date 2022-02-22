using CMS.DocumentEngine.Types.IMABS;
using CMS.SiteProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMABS.Repositories
{
    public class PrivacyRepository
    {
        private readonly string mCultureName = "en-US";
        private readonly bool mLatestVersionEnabled = true;
        public Privacy GetPageByAlias(string NodeAliasPath)
        {
            var data = PrivacyProvider
                       .GetPrivacies()
                       .LatestVersion(mLatestVersionEnabled)
                       .Published(mLatestVersionEnabled)
                       .Path(NodeAliasPath)
                       .OnSite(SiteContext.CurrentSiteName)
                       .Culture(mCultureName)
                       .CombineWithDefaultCulture()
                       .OrderBy("NodeOrder")
                       .TopN(1);
            return data;
        }
    }
}
