using CMS.DataEngine;
using CMS.DocumentEngine;
using CMS.SiteProvider;
using IMABS.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMABS.Components.ViewComponents.Breadcrumbs
{
    public class BreadcrumbsViewComponent : ViewComponent
    {
        private readonly BreadcrumbRepository breadcrumbRepo;
        public BreadcrumbsViewComponent(BreadcrumbRepository breadcrumbRepository)
        {
            breadcrumbRepo = breadcrumbRepository;
        }

        public IViewComponentResult Invoke()
        {
            var nodeAlias = HttpContext.Request.Path;



            //TreeNode page = DocumentHelper.GetDocuments()
            //    .Path(nodeAlias)
            //    .OnCurrentSite()
            //    .TopN(1)
            //    .FirstOrDefault();

            TreeProvider tree = new TreeProvider();
            var page = tree.SelectSingleNode(SiteContext.CurrentSiteName, nodeAlias, "en-US");



            // get breadcrumbs excluded classes
            string breadcrumbsExcludedClasses = SettingsKeyInfoProvider.GetValue(SiteContext.CurrentSiteName + ".BreadcrumbsExcludedClassNames");
            if (page == null)
            {
                return View("~/Components/ViewComponents/breadcrumbs/Default.cshtml");
            }
            else if (breadcrumbsExcludedClasses.Split(';').Contains(page.ClassName))
            {
                return View("~/Components/ViewComponents/breadcrumbs/Default.cshtml");
            }
            return View("~/Components/ViewComponents/breadcrumbs/Default.cshtml", breadcrumbRepo.GetBreadcrumbs(page.NodeID, true));


            //return View("~/Components/ViewComponents/breadcrumbs/Default.cshtml", viewModel);
        }
    }
}
