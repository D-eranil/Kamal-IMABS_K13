using CMS.DocumentEngine.Types.IMABS;
using CMS.SiteProvider;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IMABS.Repositories
{
	public class SocialMediaRepository
	{
        public static List<SocialMedia> GetPagesByGuid(Guid NodeGuid)
        {
            var data = SocialMediaProvider
                       .GetSocialMedias()
                       .LatestVersion(true)
                       .Published(true)
                       .OnSite(SiteContext.CurrentSiteName)
                       .Culture("en-US")
                       .CombineWithDefaultCulture()
                       .OrderBy("NodeOrder")
                       .Where(x => x.Parent.NodeGUID == NodeGuid)
                       .ToList();
            return data;
        }
        public List<SocialMedia> GetPagesByGuid(List<string> NodeGuid)
        {
            var data = SocialMediaProvider
                     .GetSocialMedias()
                     .LatestVersion(true)
                     .Published(true)
                     .OnSite(SiteContext.CurrentSiteName)
                     .Culture("en-US")
                     .CombineWithDefaultCulture()
                     .OrderBy("NodeOrder")
                     .WhereIn("DocumentGUID", NodeGuid)
                     .ToList();
            return data;
        }
    }
}
