using CMS.DocumentEngine.Types.IMABS;
using IMABS.Controllers;
using IMABS.Models.Certifications;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;

[assembly: RegisterPageRoute(Certification.CLASS_NAME, typeof(CertificationController))]
namespace IMABS.Controllers
{
    public class CertificationController : Controller
    {
        private readonly IPageDataContextRetriever dataRetriever;
        //private readonly LandingPageRepository mLandingPageRepository;
        private readonly IPageDataContextInitializer pageDataContextInitializer;

        public CertificationController(IPageDataContextRetriever dataRetriever,
            //LandingPageRepository landingPageRepository,
            IPageDataContextInitializer _pageDataContextInitializer)
        {
            this.dataRetriever = dataRetriever;
            //mLandingPageRepository = landingPageRepository;
            pageDataContextInitializer = _pageDataContextInitializer;
        }
        public IActionResult Index()
        {
            var cert = dataRetriever.Retrieve<Certification>().Page;
            //var lp = mLandingPageRepository.GetLandingPage(NodeAliasPath);
            if (cert == null)
            {
                return null;
            }
            pageDataContextInitializer.Initialize(cert);

            //view model code
            var model = CertificationViewModel.GetModel(cert);

            ViewBag.EnableCallToTactionBanner = model.EnableCallToTactionBanner;
            ViewBag.EnablePromotionsBanner = model.EnablePromotionsBanner;
            ViewBag.EnableBreadcrumb = model.EnableBreadcrumb;


            return View(model);
        }
    }
}
