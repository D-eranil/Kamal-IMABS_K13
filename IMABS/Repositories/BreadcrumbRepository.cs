using CMS.DocumentEngine;
using CMS.Helpers;
using IMABS.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IMABS.Repositories
{
    public class BreadcrumbRepository
    {
        string cultureName = "en-US";
        public bool latestVersionEnabled = true;
        private BreadcrumbHelperRepository _Helper;
        //public BreadcrumbRepository(string cultureName, bool latestVersionEnabled, BreadcrumbHelperRepository Helper)
        public BreadcrumbRepository(BreadcrumbHelperRepository Helper)
        {
            _Helper = Helper;
        }



        /// <summary>
        /// Gets the Breadcrumbs of the given page.
        /// </summary>
        /// <param name="PageIdentifier"></param>
        /// <param name="TopLevelBreadcrumb"></param>
        /// <returns></returns>
        public List<BreadcrumbViewModel> GetBreadcrumbs(int PageIdentifier, bool IncludeDefaultBreadcrumb = true)
        {
            List<BreadcrumbViewModel> Breadcrumbs = new List<BreadcrumbViewModel>();



            // Get the current Page and then loop through ancestors
            var Page = _Helper.GetBreadcrumbNode(PageIdentifier);
            bool IsCurrentPage = true;
            while (Page != null && !Page.ClassName.Equals("CMS.Root", StringComparison.InvariantCultureIgnoreCase))
            {
                Breadcrumbs.Add(_Helper.PageToBreadcrumb(Page, IsCurrentPage));
                Page = _Helper.GetBreadcrumbNode(Page.NodeParentID);
                IsCurrentPage = false;
            }

            BreadcrumbViewModel defaultBreadcrumb = GetDefaultBreadcrumb();
            if (defaultBreadcrumb != null && !string.IsNullOrEmpty(defaultBreadcrumb.LinkText))
            {
                Breadcrumbs.Add(defaultBreadcrumb);
            }



            // Reverse breadcrumb order
            Breadcrumbs.Reverse();
            return Breadcrumbs;
        }




        public BreadcrumbViewModel GetDefaultBreadcrumb()
        {
            return new BreadcrumbViewModel()
            {
                //LinkText = ResHelper.LocalizeExpression("generic.default.breadcrumbtext"),
                LinkText = ResHelper.LocalizeExpression("generic.default.breadcrumburl").Replace("/",""),
                LinkUrl = ResHelper.LocalizeExpression("generic.default.breadcrumburl"),
            };
        }

    }
}
