using CMS.DocumentEngine.Types.IMABS;
using IMABS.Controllers;
using IMABS.Models.LandingPages;
using IMABS.Repositories;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

[assembly: RegisterPageRoute(Tools.CLASS_NAME, typeof(ToolsController))]
namespace IMABS.Controllers
{
	public class ToolsController : Controller
    {
        private readonly IPageDataContextRetriever pageDataContextRetriever;
        private readonly IPageDataContextInitializer pageDataContextInitializer;

        public ToolsController(IPageDataContextRetriever _pageDataContextRetriever,
            IPageDataContextInitializer _pageDataContextInitializer)
        {
            pageDataContextRetriever = _pageDataContextRetriever;
            pageDataContextInitializer = _pageDataContextInitializer;
        }
        public async Task<ActionResult> Index()
        {
            //var tools = ToolsProvider.GetTools().FirstOrDefault(); 
            var tools = pageDataContextRetriever.Retrieve<Tools>().Page;

            ViewBag.EnableCallToTactionBanner = tools.Fields.EnableCallToTactionBanner;
            ViewBag.EnablePromotionsBanner = tools.Fields.EnablePromotionsBanner;
            ViewBag.EnableBreadcrumb = tools.Fields.EnableBreadcrumb;

            pageDataContextInitializer.Initialize(tools);

            return View(tools);
        }
    }
}
