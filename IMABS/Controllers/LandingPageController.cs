using CMS.DocumentEngine.Types.IMABS;
using IMABS.Controllers;
using IMABS.Models.LandingPages;
using IMABS.Models.Service;
using IMABS.Repositories;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

[assembly: RegisterPageRoute(LandingPage.CLASS_NAME, typeof(LandingPageController))]
namespace IMABS.Controllers
{
    public class LandingPageController : Controller
    {
        private readonly IPageDataContextRetriever dataRetriever;
        private readonly LandingPageRepository mLandingPageRepository;
        private readonly IPageDataContextInitializer pageDataContextInitializer;

        public LandingPageController(IPageDataContextRetriever dataRetriever, 
            LandingPageRepository landingPageRepository,
            IPageDataContextInitializer _pageDataContextInitializer)
        {
            this.dataRetriever = dataRetriever;
            mLandingPageRepository = landingPageRepository;
            pageDataContextInitializer = _pageDataContextInitializer;
        }

        // GET: LandingPage
        public async Task<ActionResult> Index(string NodeAliasPath)
        {
            var lp = dataRetriever.Retrieve<LandingPage>().Page;
            //var lp = mLandingPageRepository.GetLandingPage(NodeAliasPath);
            if (lp == null)
            {
                return null;
            }
            pageDataContextInitializer.Initialize(lp);

            //view model code
            var model = new LandingPageViewModel
            {
                top2Services = mLandingPageRepository.GetTop2Services(lp.NodeGUID).Select(ServiceViewModel.GetViewModel).ToList(),
                services = mLandingPageRepository.GetServices(lp.NodeGUID).Select(ServiceViewModel.GetViewModel).ToList()
            };

            ViewBag.EnableCallToTactionBanner = lp.Fields.EnableCallToTactionBanner;
            ViewBag.EnablePromotionsBanner = lp.Fields.EnablePromotionsBanner;
            ViewBag.EnableBreadcrumb = lp.Fields.EnableBreadcrumb;


            return View(model);
        }
    }
}
