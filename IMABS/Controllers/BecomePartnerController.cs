using CMS.DocumentEngine.Types.IMABS;
using IMABS.Controllers;
using IMABS.Models.BecomeAPartner;
using IMABS.Models.LandingPages;
using IMABS.Repositories;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

[assembly: RegisterPageRoute(BecomePartner.CLASS_NAME, typeof(BecomePartnerController))]
namespace IMABS.Controllers
{
	public class BecomePartnerController : Controller
    {
        private readonly IPageDataContextRetriever pageDataContextRetriever;
        private readonly IPageDataContextInitializer pageDataContextInitializer;

        public BecomePartnerController(IPageDataContextRetriever _pageDataContextRetriever,
            IPageDataContextInitializer _pageDataContextInitializer)
        {
            pageDataContextRetriever = _pageDataContextRetriever;
            pageDataContextInitializer = _pageDataContextInitializer;
        }
        public async Task<ActionResult> Index()
        {
            var becomePartner = pageDataContextRetriever.Retrieve<BecomePartner>().Page;

            if (becomePartner == null)
            {
                return null;
            }
            pageDataContextInitializer.Initialize(becomePartner);

            //view model code
            var model = BecomePartnerViewModel.GetViewModel(becomePartner);

            ViewBag.EnableCallToTactionBanner = becomePartner.Fields.EnableCallToTactionBanner;
            ViewBag.EnablePromotionsBanner = becomePartner.Fields.EnablePromotionsBanner;
            ViewBag.EnableBreadcrumb = becomePartner.Fields.EnableBreadcrumb;
            ViewBag.PageCTABanner = becomePartner.Fields.CTABanner;
            pageDataContextInitializer.Initialize(becomePartner);

            return View(model);
        }
    }
}
