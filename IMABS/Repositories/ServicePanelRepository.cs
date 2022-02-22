using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.IMABS;
using CMS.SiteProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMABS.Repositories
{
    public class ServicePanelRepository
    {
        private readonly string mCultureName;
        private readonly bool mLatestVersionEnabled;

        //public ServicePanelRepository(string cultureName, bool latestVersionEnabled)
        //{
        //    mCultureName = cultureName;
        //    mLatestVersionEnabled = latestVersionEnabled;
        //}

        public List<ServicePanel> GetChildPagesByAlias(string NodeAliasPath)
        {
            var data = ServicePanelProvider
                       .GetServicePanels()
                       .LatestVersion(mLatestVersionEnabled)
                       .Published(mLatestVersionEnabled)
                       .Path(NodeAliasPath, PathTypeEnum.Children)
                       .OnSite(SiteContext.CurrentSiteName)
                       .Culture(mCultureName)
                       .CombineWithDefaultCulture()
                       .OrderBy("NodeOrder")
                       .ToList();
            return data;
        }
    }
}
