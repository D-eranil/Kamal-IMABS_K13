using CMS.DocumentEngine.Types.IMABS;
using CMS.SiteProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMABS.Repositories
{
    public class BrandRepository
    {
        public static List<Brand> GetPagesByGuid(Guid NodeGuid)
        {
            var data = BrandProvider
                       .GetBrands()
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
        public List<Brand> GetPagesByGuid(List<string> NodeGuid)
        {
            var data = BrandProvider
                     .GetBrands()
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
