using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.IMABS;
using CMS.SiteProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMABS.Repositories
{
    public class HeaderRepository
    {
        private readonly bool mLatestVersionEnabled;

        public HeaderRepository()
        {
            mLatestVersionEnabled = true;
        }


        /// <summary>
        /// Returns an enumerable collection of Main Menu ordered by a position in the content tree.
        /// </summary>
        public List<LandingPage> GetMainNavMenus()
        {
            return LandingPageProvider.GetLandingPages()
                .LatestVersion(mLatestVersionEnabled)
                .Published(!mLatestVersionEnabled)
                .OnSite(SiteContext.CurrentSiteName)
                //.Culture(mCultureName)
                .CombineWithDefaultCulture()
                .OrderBy("NodeOrder")
                .ToList();
        }


        /// <summary>
        /// Returns an enumerable collection of Main Menu ordered by a position in the content tree.
        /// </summary>
        public List<MainNavigation> GetMainMenus()
        {
            return MainNavigationProvider.GetMainNavigations()
                .LatestVersion(mLatestVersionEnabled)
                .Published(!mLatestVersionEnabled)
                .OnSite(SiteContext.CurrentSiteName)
                //.Culture(mCultureName)
                .CombineWithDefaultCulture()
                .OrderBy("NodeOrder")
                .ToList();
        }

        /// <summary>
        /// Returns an enumerable collection of Main Menu ordered by a position in the content tree.
        /// </summary>
        public List<SubNavigation> GetSubMenus(string nodeGUID = null)
        {
            if (nodeGUID == null)
            {
                return SubNavigationProvider.GetSubNavigations()
                        .LatestVersion(mLatestVersionEnabled)
                        .Published(!mLatestVersionEnabled)
                        .OnSite(SiteContext.CurrentSiteName)
                        //.Culture(mCultureName)
                        .CombineWithDefaultCulture()
                        .OrderBy("NodeOrder")
                        .ToList();
            }
            else
            {
                return SubNavigationProvider.GetSubNavigations()
                        .LatestVersion(mLatestVersionEnabled)
                        .Published(!mLatestVersionEnabled)
                        .OnSite(SiteContext.CurrentSiteName)
                        //.Culture(mCultureName)
                        .CombineWithDefaultCulture()
                        .OrderBy("NodeOrder")
                        //.Where(x => x.Parent.NodeGUID.ToString() == nodeGUID && x.AllowToViewInHeader)
                        .Where(x => x.Parent.NodeGUID.ToString() == nodeGUID)
                        .ToList();
            }
        }

        /// <summary>
        /// Returns an enumerable collection of Main Menu ordered by a position in the content tree.
        /// </summary>
        public List<SubNavigation> GetFooterSubMenus(string nodeGUID = null)
        {
            if (nodeGUID == null)
            {
                return SubNavigationProvider.GetSubNavigations()
                        .LatestVersion(mLatestVersionEnabled)
                        .Published(!mLatestVersionEnabled)
                        .OnSite(SiteContext.CurrentSiteName)
                        //.Culture(mCultureName)
                        .CombineWithDefaultCulture()
                        .OrderBy("NodeOrder")
                        .ToList();
            }
            else
            {
                return SubNavigationProvider.GetSubNavigations()
                        .LatestVersion(mLatestVersionEnabled)
                        .Published(!mLatestVersionEnabled)
                        .OnSite(SiteContext.CurrentSiteName)
                        //.Culture(mCultureName)
                        .CombineWithDefaultCulture()
                        .OrderBy("NodeOrder")
                        //.Where(x => x.Parent.NodeGUID.ToString() == nodeGUID && x.AllowToViewInFooter)
                        .Where(x => x.Parent.NodeGUID.ToString() == nodeGUID)
                        .ToList();
            }
        }


        ///// <summary>
        ///// Returns an enumerable collection of Main Menu ordered by a position in the content tree.
        ///// </summary>
        //public List<About> GetSubAboutMenus(string nodeGUID)
        //{
        //    //var docslist = DocumentHelper.GetDocuments()
        //    //        //.Contains()
        //    //        .Types("IMABS.About", "IMABS.About")
        //    //        .LatestVersion(mLatestVersionEnabled)
        //    //        .Published(!mLatestVersionEnabled)
        //    //        .OnSite(SiteContext.CurrentSiteName)
        //    //        .Culture(mCultureName)
        //    //        .CombineWithDefaultCulture()
        //    //        .OrderBy("NodeOrder")
        //    //        .Where(x => x.Parent.NodeGUID.ToString() == nodeGUID)
        //    //        .ToList();
        //    //return docslist.ToList();
        //    //return docslist
        //    //.Where(x => x.Parent.NodeGUID.ToString() == nodeGUID && x.AllowToViewInHeader)

        //    return AboutProvider.GetAbouts()
        //            .LatestVersion(mLatestVersionEnabled)
        //            .Published(!mLatestVersionEnabled)
        //            .OnSite(SiteContext.CurrentSiteName)
        //            .Culture(mCultureName)
        //            .CombineWithDefaultCulture()
        //            .OrderBy("NodeOrder")
        //            .Where(x => x.Parent.NodeGUID.ToString() == nodeGUID && x.AllowToViewInHeader)
        //            .ToList();
        //}

        ///// <summary>
        ///// Returns an enumerable collection of Main Menu ordered by a position in the content tree.
        ///// </summary>
        //public List<About> GetFooterSubAboutMenus(string nodeGUID)
        //{
        //    return AboutProvider.GetAbouts()
        //            .LatestVersion(mLatestVersionEnabled)
        //            .Published(!mLatestVersionEnabled)
        //            .OnSite(SiteContext.CurrentSiteName)
        //            .Culture(mCultureName)
        //            .CombineWithDefaultCulture()
        //            .OrderBy("NodeOrder")
        //            .Where(x => x.Parent.NodeGUID.ToString() == nodeGUID && x.AllowToViewInFooter)
        //            .ToList();
        //}


        /// <summary>
        /// Returns an enumerable collection of Main Menu ordered by a position in the content tree.
        /// </summary>
        //public List<Support> GetSubSupportMenus(string nodeGUID)
        //{
        //    return SupportProvider.GetSupports()
        //            .LatestVersion(mLatestVersionEnabled)
        //            .Published(!mLatestVersionEnabled)
        //            .OnSite(SiteContext.CurrentSiteName)
        //            .Culture(mCultureName)
        //            .CombineWithDefaultCulture()
        //            .OrderBy("NodeOrder")
        //            .Where(x => x.Parent.NodeGUID.ToString() == nodeGUID && x.AllowToViewInHeader)
        //            .ToList();
        //}

        /// <summary>
        /// Returns an enumerable collection of Main Menu ordered by a position in the content tree.
        /// </summary>
        //public List<Support> GetFooterSubSupportMenus(string nodeGUID)
        //{
        //    return SupportProvider.GetSupports()
        //            .LatestVersion(mLatestVersionEnabled)
        //            .Published(!mLatestVersionEnabled)
        //            .OnSite(SiteContext.CurrentSiteName)
        //            .Culture(mCultureName)
        //            .CombineWithDefaultCulture()
        //            .OrderBy("NodeOrder")
        //            .Where(x => x.Parent.NodeGUID.ToString() == nodeGUID && x.AllowToViewInFooter)
        //            .ToList();
        //}


        /// <summary>
        /// Returns an enumerable collection of Main Menu ordered by a position in the content tree.
        /// </summary>
        //public List<Services> GetSubServiceMenus(string nodeGUID)
        //{
        //    return ServicesProvider.GetServices()
        //            .LatestVersion(mLatestVersionEnabled)
        //            .Published(!mLatestVersionEnabled)
        //            .OnSite(SiteContext.CurrentSiteName)
        //            .Culture(mCultureName)
        //            .CombineWithDefaultCulture()
        //            .OrderBy("NodeOrder")
        //            .Where(x => x.Parent.NodeGUID.ToString() == nodeGUID && x.AllowToViewInHeader)
        //            .ToList();
        //}

        /// <summary>
        /// Returns an enumerable collection of Main Menu ordered by a position in the content tree.
        /// </summary>
        //public List<Services> GetFooterSubServiceMenus(string nodeGUID)
        //{
        //    return ServicesProvider.GetServices()
        //            .LatestVersion(mLatestVersionEnabled)
        //            .Published(!mLatestVersionEnabled)
        //            .OnSite(SiteContext.CurrentSiteName)
        //            .Culture(mCultureName)
        //            .CombineWithDefaultCulture()
        //            .OrderBy("NodeOrder")
        //            .Where(x => x.Parent.NodeGUID.ToString() == nodeGUID && x.AllowToViewInFooter)
        //            .ToList();
        //}

        /// <summary>
        /// Returns an enumerable collection of Main Menu ordered by a position in the content tree.
        /// </summary>
        //public List<Solutions> GetSubSolutionMenus(string nodeGUID)
        //{
        //    return SolutionsProvider.GetSolutions()
        //            .LatestVersion(mLatestVersionEnabled)
        //            .Published(!mLatestVersionEnabled)
        //            .OnSite(SiteContext.CurrentSiteName)
        //            .Culture(mCultureName)
        //            .CombineWithDefaultCulture()
        //            .OrderBy("NodeOrder")
        //            .Where(x => x.Parent.NodeGUID.ToString() == nodeGUID && x.AllowToViewInHeader)
        //            .ToList();
        //}

        /// <summary>
        /// Returns an enumerable collection of Main Menu ordered by a position in the content tree.
        /// </summary>
        //public List<Solutions> GetFooterSubSolutionMenus(string nodeGUID)
        //{
        //    return SolutionsProvider.GetSolutions()
        //            .LatestVersion(mLatestVersionEnabled)
        //            .Published(!mLatestVersionEnabled)
        //            .OnSite(SiteContext.CurrentSiteName)
        //            .Culture(mCultureName)
        //            .CombineWithDefaultCulture()
        //            .OrderBy("NodeOrder")
        //            .Where(x => x.Parent.NodeGUID.ToString() == nodeGUID && x.AllowToViewInFooter)
        //            .ToList();
        //}

        /// <summary>
        /// Returns an enumerable collection of Sub Menu ordered by a position in the content tree.
        /// </summary>
        public List<TopNavigation> GetTopManus()
        {
            return TopNavigationProvider.GetTopNavigations()
                .LatestVersion(mLatestVersionEnabled)
                .Published(!mLatestVersionEnabled)
                .OnSite(SiteContext.CurrentSiteName)
                //.Culture(mCultureName)
                .CombineWithDefaultCulture()
                .OrderBy("NodeOrder")
                //.Where("nodelevel = 3 and NodeHasChildren = 0")
                .ToList();
        }

        /// <summary>
        /// Returns an enumerable collection of Bottom Menu ordered by a position in the content tree.
        /// </summary>
        public List<BottomNavigation> GetBottomManus()
        {
            return BottomNavigationProvider.GetBottomNavigations()
                .LatestVersion(mLatestVersionEnabled)
                .Published(!mLatestVersionEnabled)
                .OnSite(SiteContext.CurrentSiteName)
                //.Culture(mCultureName)
                .CombineWithDefaultCulture()
                .OrderBy("NodeOrder")
                .ToList();
        }

        /// <summary>
        /// Returns an object representing the home page.
        /// </summary>
        public Header GetHeaderPage()
        {
            return HeaderProvider.GetHeaders()
                .LatestVersion(mLatestVersionEnabled)
                .Published(!mLatestVersionEnabled)
                .OnSite(SiteContext.CurrentSiteName)
                //.Culture(mCultureName)
                .CombineWithDefaultCulture()
                .TopN(1);
        }

        public List<TreeNode> GetSubMenuList(string nodeGUID = null)
        {
            //List<TreeNode> lst = new List<TreeNode>();

            //if (nodeGUID == null)
            //{
            //    DocumentHelper.GetDocuments()
            //    .LatestVersion(mLatestVersionEnabled)
            //    .Published(mLatestVersionEnabled)
            //    .CombineWithDefaultCulture()
            //    .OrderBy("NodeOrder")
            //    .ToList();
            //}
            //else
            //{
            List<TreeNode> lst = DocumentHelper.GetDocuments()
                .LatestVersion(mLatestVersionEnabled)
                .Published(mLatestVersionEnabled)
                .CombineWithDefaultCulture()
                .OrderBy("NodeOrder")
                .Where(x => x.Parent != null && x.Parent.NodeGUID.ToString() == nodeGUID)
                .ToList();
            //}

            return lst;
        }

        //public Footer GetFooterPage()
        //{
        //    return FooterProvider.GetFooters()
        //       .LatestVersion(mLatestVersionEnabled)
        //       .Published(!mLatestVersionEnabled)
        //       .OnSite(SiteContext.CurrentSiteName)
        //       .Culture(mCultureName)
        //       .CombineWithDefaultCulture()
        //       .TopN(1);
        //}
    }
}
