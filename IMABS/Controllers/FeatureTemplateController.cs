using CMS.DocumentEngine.Types.IMABS;
using IMABS.Controllers;
using IMABS.Models.Brands;
using IMABS.Models.FeatureTemplates;
using IMABS.Repositories;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[assembly:RegisterPageRoute(FeatureTemplate.CLASS_NAME,typeof(FeatureTemplateController))]
namespace IMABS.Controllers
{
    public class FeatureTemplateController : Controller
    {
        private readonly IPageDataContextRetriever dataRetriever;
        private readonly IPageDataContextInitializer pageDataContextInitializer;

        public FeatureTemplateController(IPageDataContextRetriever dataRetriever,
        IPageDataContextInitializer _pageDataContextInitializer)
        {
            this.dataRetriever = dataRetriever;
            pageDataContextInitializer = _pageDataContextInitializer;
        }
        public IActionResult Index()
        {
            var ft = dataRetriever.Retrieve<FeatureTemplate>().Page;
            if (ft == null)
            {
                return null;
            }
            pageDataContextInitializer.Initialize(ft);


            //view model code
            var model = FeatureTemplateViewModel.GetViewModel(ft);
            

            ViewBag.EnableCallToTactionBanner = ft.Fields.EnableCallToTactionBanner;
            ViewBag.EnablePromotionsBanner = ft.Fields.EnablePromotionsBanner;
            ViewBag.EnableBreadcrumb = ft.Fields.EnableBreadcrumb;

            return View(model);
        }
    }
}
