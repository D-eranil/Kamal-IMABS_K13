using CMS.DocumentEngine.Types.IMABS;
using IMABS.Controllers;
using IMABS.Models.Career;
using IMABS.Repositories;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[assembly: RegisterPageRoute(Careers.CLASS_NAME, typeof(CareersController))]
namespace IMABS.Controllers
{
	public class CareersController : Controller
    {
        private readonly IPageDataContextRetriever pageDataContextRetriever;
        private readonly IPageDataContextInitializer pageDataContextInitializer;

        public CareersController(IPageDataContextRetriever _pageDataContextRetriever,
            IPageDataContextInitializer _pageDataContextInitializer)
        {
            pageDataContextRetriever = _pageDataContextRetriever;
            pageDataContextInitializer = _pageDataContextInitializer;
        }
        public async Task<ActionResult> Index()
        {
            var careerPage = pageDataContextRetriever.Retrieve<Careers>().Page;
            if (careerPage == null)
            {
                return null;
            }
            pageDataContextInitializer.Initialize(careerPage);

            //view model code
            var model = CareersViewModel.GetPageViewModel(careerPage);

            ViewBag.EnableCallToTactionBanner = careerPage.Fields.EnableCallToTactionBanner;
            ViewBag.EnablePromotionsBanner = careerPage.Fields.EnablePromotionsBanner;
            ViewBag.EnableBreadcrumb = careerPage.Fields.EnableBreadcrumb;

            pageDataContextInitializer.Initialize(careerPage);

            return View(model);
        }
    }
}
