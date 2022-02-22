using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.IMABS;
using CMS.SiteProvider;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IMABS.Repositories
{
    public class CategoryIndexRepository
    {
        public string mCultureName = "en-US";
        public bool mLatestVersionEnabled = true;

        /// <summary>
        /// Returns an object representing the Category Index page.
        /// </summary>
        public CategoryIndex GetCategoryIndexPage()
        {

            return CategoryIndexProvider.GetCategoryIndexes()
                .LatestVersion(mLatestVersionEnabled)
                .Published(mLatestVersionEnabled)
                .OnSite(SiteContext.CurrentSiteName)
                .Culture(mCultureName)
                .CombineWithDefaultCulture()
                .TopN(1);

        }

        public List<CategoryIndex> GetPages()
        {
            var data = CategoryIndexProvider
                       .GetCategoryIndexes()
                       .LatestVersion(mLatestVersionEnabled)
                       .Published(mLatestVersionEnabled)
                       .OnSite(SiteContext.CurrentSiteName)
                       .Culture(mCultureName)
                       .CombineWithDefaultCulture()
                       .OrderBy("NodeOrder")
                       .ToList();
            return data;
        }
        public ProductCategoryDetail GetProductCategoryDetailPage(string NodeAliasPath)
        {
            return ProductCategoryDetailProvider.GetProductCategoryDetails()
                .LatestVersion(mLatestVersionEnabled)
                .Published(mLatestVersionEnabled)
                .OnSite(SiteContext.CurrentSiteName)
                .Culture(mCultureName)
                .Path(NodeAliasPath)
                .CombineWithDefaultCulture()
                .OrderBy("NodeOrder")
                .TopN(1);
        }

        public List<ProductCategoryDetail> GetProductCategoryDetailPages()
        {
            return ProductCategoryDetailProvider.GetProductCategoryDetails()
                .LatestVersion(mLatestVersionEnabled)
                .Published(mLatestVersionEnabled)
                .OnSite(SiteContext.CurrentSiteName)
                .Culture(mCultureName)
                .CombineWithDefaultCulture()
                .OrderBy("NodeOrder")
                .ToList();
        }

        public List<ProductSubCategory> GetProductSubCategoryDetails(Guid NodeGUID)
        {
            return ProductSubCategoryProvider.GetProductSubCategories()
                .LatestVersion(mLatestVersionEnabled)
                .Published(mLatestVersionEnabled)
                .OnSite(SiteContext.CurrentSiteName)
                .Culture(mCultureName)
                .CombineWithDefaultCulture()
                .OrderBy("NodeOrder")
                .Where(x => x.Parent.NodeGUID == NodeGUID)
                .ToList();
        }

        public List<ProductSubCategory> GetProductSubCategoryDetails(string NodeAliasPath)
        {
            return ProductSubCategoryProvider.GetProductSubCategories()
                .LatestVersion(mLatestVersionEnabled)
                .Published(mLatestVersionEnabled)
                .OnSite(SiteContext.CurrentSiteName)
                .Culture(mCultureName)
                .CombineWithDefaultCulture()
                .Path(NodeAliasPath, PathTypeEnum.Children)
                .OrderBy("NodeOrder")
                .ToList();
        }
        
        public List<ActionLink> GetResources(string NodeAliasPath)
        {
            return ActionLinkProvider.GetActionLinks()
              .LatestVersion(mLatestVersionEnabled)
              .Published(mLatestVersionEnabled)
              .OnSite(SiteContext.CurrentSiteName)
              .Culture(mCultureName)
              .CombineWithDefaultCulture()
              .Path(NodeAliasPath, PathTypeEnum.Children)
              .OrderBy("NodeOrder")
              .ToList();
        }

        public List<ResourceLink> GetResourceLinks(string NodeAliasPath)
        {
            return ResourceLinkProvider.GetResourceLinks()
              .LatestVersion(mLatestVersionEnabled)
              .Published(mLatestVersionEnabled)
              .OnSite(SiteContext.CurrentSiteName)
              .Culture(mCultureName)
              .CombineWithDefaultCulture()
              .Path(NodeAliasPath, PathTypeEnum.Children)
              .OrderBy("NodeOrder")
              .ToList();
        }
    }
}
