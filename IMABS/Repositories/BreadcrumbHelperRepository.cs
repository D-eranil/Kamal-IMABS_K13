using CMS.DocumentEngine;
using IMABS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMABS.Repositories
{
    public class BreadcrumbHelperRepository
    {
        public string cultureName = "en-US";
        public bool latestVersionEnabled = true;
        //public string cultureName { get; set; }
        //public bool latestVersionEnabled { get; set; }



        //public BreadcrumbHelperRepository(string cultureName, bool latestVersionEnabled)
        //{
        //    this.cultureName = cultureName;
        //    this.latestVersionEnabled = latestVersionEnabled;
        //}



        public TreeNode GetBreadcrumbNode(int NodeID)
        {
            return DocumentHelper.GetDocuments()
                .WhereEquals("NodeID", NodeID)
                .Culture(cultureName)
                .CombineWithDefaultCulture()
                .CombineWithAnyCulture()
                .Published(!latestVersionEnabled)
                .LatestVersion(latestVersionEnabled)
                //.Columns("NodeID", "DocumentCulture", "DocumentName", "NodeParentID", "ClassName", "NodeAliasPath", "DocumentNamePath") // These are needed for Dynamic Route URL Slug lookup for Relative Url, and breadcrumb determination
                .Columns("NodeID", "DocumentCulture", "DocumentName", "NodeParentID", "ClassName", "NodeAliasPath") // These are needed for Dynamic Route URL Slug lookup for Relative Url, and breadcrumb determination
                .FirstOrDefault();
        }



        /// <summary>
        /// Converts the TreeNode into a breadcrumb.
        /// </summary>
        /// <param name="Page">The Page</param>
        /// <param name="IsCurrentPage">If the page is the current page</param>
        /// <returns></returns>
        public BreadcrumbViewModel PageToBreadcrumb(TreeNode Page, bool IsCurrentPage)
        {
            BreadcrumbViewModel breadcrumb = new BreadcrumbViewModel();
            breadcrumb.LinkText = Page.DocumentName;
            breadcrumb.LinkUrl = Page.NodeAliasPath;
            breadcrumb.IsCurrentPage = IsCurrentPage;
            return breadcrumb;
        }
    }
}
