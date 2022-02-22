using CMS.DocumentEngine.Types.IMABS;
using CMS.SiteProvider;
using Kentico.Content.Web.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace IMABS.Repositories
{
    public class HomeRepository
    {
        //private readonly IPageRetriever pageRetriever;


        ///// <summary>
        ///// Initializes a new instance of the <see cref="HomeRepository"/> class that returns home page sections. 
        ///// </summary>
        ///// <param name="pageRetriever">Retriever for pages based on given parameters.</param>
        //public HomeRepository(IPageRetriever pageRetriever)
        //{
        //    this.pageRetriever = pageRetriever;
        //}

        ///// <summary>
        ///// Asynchronously returns an enumerable collection of home page sections ordered by a position in the content tree.
        ///// </summary>
        ///// <param name="nodeAliasPath">The node alias path of the home in the content tree.</param>
        ///// <param name="cancellationToken">The cancellation instruction.</param>
        //public Task<IEnumerable<BannerSection>> GetHomeSectionsAsync(string nodeAliasPath, CancellationToken cancellationToken)
        //{
        //    return pageRetriever.RetrieveAsync<BannerSection>(
        //        query => query
        //            .Path(nodeAliasPath, PathTypeEnum.Children)
        //            .OrderBy("NodeOrder"),
        //        cache => cache
        //            .Key($"{nameof(HomeRepository)}|{nameof(GetHomeSectionsAsync)}|{nodeAliasPath}")
        //            // Include path dependency to flush cache when a new child page is created or page order is changed.
        //            .Dependencies((_, builder) => builder.PagePath(nodeAliasPath, PathTypeEnum.Children).PageOrder()),
        //        cancellationToken);
        //}

        public List<BannerSection> GetBanners()
        {
            return BannerSectionProvider.GetBannerSections()
                //.LatestVersion(mLatestVersionEnabled)
                //.Published(!mLatestVersionEnabled)
                .Published(true)
                .OnSite(SiteContext.CurrentSiteName)
                //.Culture(mCultureName)
                .CombineWithDefaultCulture()
                .OrderBy("NodeOrder")
                .TopN(3)
                .Where(x => x.IsActiveBanner)
                .ToList();
        }
        /// <summary>
        /// Returns an enumerable collection of Why Ingram Option sections ordered by a position in the content tree.
        /// </summary>
        public List<WhyIngramOption> GetWhyIngramOptions()
        {
            return WhyIngramOptionProvider.GetWhyIngramOptions()
                //.LatestVersion(mLatestVersionEnabled)
                //.Published(!mLatestVersionEnabled)
                .Published(true)
                .OnSite(SiteContext.CurrentSiteName)
                //.Culture(mCultureName)
                .CombineWithDefaultCulture()
                .OrderBy("NodeOrder")
                .ToList();
        }

        /// <summary>
        /// Returns an enumerable collection of ActionLink under why ingram sections ordered by a position in the content tree.
        /// </summary>
        public List<ActionLink> GetActionLinks(string NodeGUID)
        {
            return ActionLinkProvider.GetActionLinks()
                //.LatestVersion(mLatestVersionEnabled)
                //.Published(!mLatestVersionEnabled)
                .Published(true)
                .OnSite(SiteContext.CurrentSiteName)
                //.Culture(mCultureName)
                .CombineWithDefaultCulture()
                .OrderBy("NodeOrder")
                .Where(x => x.Parent.NodeGUID.ToString() == NodeGUID)
                .ToList();
        }


        /// <summary>
        /// Returns an object representing the Partner With Us page.
        /// </summary>
        public PartnerCentral GetPartnerCentralDetails()
        {
            return PartnerCentralProvider.GetPartnerCentrals()
                //.LatestVersion(mLatestVersionEnabled)
                //.Published(!mLatestVersionEnabled)
                .Published(true)
                .OnSite(SiteContext.CurrentSiteName)
                //.Culture(mCultureName)
                .CombineWithDefaultCulture()
                .TopN(1);
        }

        /// <summary>
        /// Returns an object representing the Partner With Us page.
        /// </summary>
        public PartnerWithUs GetPartnerWithUsPage()
        {
            return PartnerWithUsProvider.GetPartnerWithUs()
                //.LatestVersion(mLatestVersionEnabled)
                //.Published(!mLatestVersionEnabled)
                .Published(true)
                .OnSite(SiteContext.CurrentSiteName)
                //.Culture(mCultureName)
                .CombineWithDefaultCulture()
                .TopN(1);
        }


        /// <summary>
        /// Returns an object representing the home page.
        /// </summary>
        public Home GetHomePage()
        {
            return HomeProvider.GetHomes()
                //.LatestVersion(mLatestVersionEnabled)
                //.Published(!mLatestVersionEnabled)
                .Published(true)
                .OnSite(SiteContext.CurrentSiteName)
                //.Culture(mCultureName)
                .CombineWithDefaultCulture()
                .TopN(1);
        }

    }
}
