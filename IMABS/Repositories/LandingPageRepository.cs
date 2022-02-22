using CMS.DocumentEngine.Types.IMABS;
using CMS.SiteProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMABS.Repositories
{
    public class LandingPageRepository
    {
        private readonly string mCultureName = "en-US";
        private readonly bool mLatestVersionEnabled = true;


        /// <summary>
        /// Initializes a new instance of the <see cref="LandingPageRepository"/> class that returns home page sections in the specified language. 
        /// If the requested page doesn't exist in specified language then its default culture version is returned.
        /// </summary>
        /// <param name="cultureName">The name of a culture.</param>
        /// <param name="latestVersionEnabled">Indicates whether the repository will provide the most recent version of pages.</param>
        //public LandingPageRepository(string cultureName, bool latestVersionEnabled)
        //{
        //    mCultureName = cultureName;
        //    mLatestVersionEnabled = latestVersionEnabled;
        //}

        /// <summary>
        /// Returns an object representing the about page.
        /// </summary>
        public LandingPage GetLandingPage()
        {
            return LandingPageProvider.GetLandingPages()
                .LatestVersion(mLatestVersionEnabled)
                .Published(!mLatestVersionEnabled)
                .OnSite(SiteContext.CurrentSiteName)
                .Culture(mCultureName)
                .CombineWithDefaultCulture()
                .TopN(1);
        }

        public LandingPage GetLandingPage(string NodeAliasPath)
        {
            return LandingPageProvider.GetLandingPages()
                 .LatestVersion(mLatestVersionEnabled)
                 .Published(!mLatestVersionEnabled)
                 .Path(NodeAliasPath)
                 .OnSite(SiteContext.CurrentSiteName)
                 .Culture(mCultureName)
                 .CombineWithDefaultCulture()
                 .TopN(1);
        }

        public List<Services> GetServices(Guid NodeGuid)
        {
            return ServicesProvider.GetServices()
               .LatestVersion(mLatestVersionEnabled)
               .Published(!mLatestVersionEnabled)
               .OnSite(SiteContext.CurrentSiteName)
               .Culture(mCultureName)
               .CombineWithDefaultCulture()
               .OrderBy("NodeOrder")
               //.WhereGreaterThan("NodeOrder", 2)
               .Skip(2)
               .Where(x => x.Parent.NodeGUID == NodeGuid)
               .ToList();
        }

        public List<Services> GetTop2Services(Guid NodeGuid)
        {
            return ServicesProvider.GetServices()
             .LatestVersion(mLatestVersionEnabled)
             .Published(!mLatestVersionEnabled)
             .OnSite(SiteContext.CurrentSiteName)
             .Culture(mCultureName)
             .CombineWithDefaultCulture()
             .OrderBy("NodeOrder")
             .TopN(2)
             .Where(x => x.Parent.NodeGUID == NodeGuid)
             .ToList();
        }

    }
}
