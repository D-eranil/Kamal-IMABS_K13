using CMS.DocumentEngine.Types.IMABS;
using IMABS.Controllers;
using IMABS.Models.Leaderships;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;

[assembly: RegisterPageRoute(Leadership.CLASS_NAME, typeof(LeadershipController))]
namespace IMABS.Controllers
{
    public class LeadershipController : Controller
    {
        private readonly IPageDataContextRetriever dataRetriever;
        private readonly IPageDataContextInitializer pageDataContextInitializer;

        public LeadershipController(IPageDataContextRetriever dataRetriever,
            IPageDataContextInitializer _pageDataContextInitializer)
        {
            this.dataRetriever = dataRetriever;
            pageDataContextInitializer = _pageDataContextInitializer;
        }


        public IActionResult Index()
        {
            var ls = dataRetriever.Retrieve<Leadership>().Page;
            if (ls == null)
            {
                return null;
            }
            pageDataContextInitializer.Initialize(ls);

            //view model code
            var model = LeadershipViewModel.GetViewModel(ls);

            ViewBag.EnableCallToTactionBanner = ls.Fields.EnableCallToTactionBanner;
            ViewBag.EnableBreadcrumb = ls.Fields.EnableBreadcrumb;

            return View(model);
        }
    }
}
