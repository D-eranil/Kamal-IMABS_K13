using CMS.DocumentEngine.Types.IMABS;
using IMABS.Controllers;
using IMABS.Models.Banners;
using IMABS.Models.Homes;
using IMABS.Models.Homes.HomePopups;
using IMABS.Models.Homes.WhyIngramOptions;
using IMABS.Repositories;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

[assembly: RegisterPageRoute(Home.CLASS_NAME, typeof(HomeController))]
namespace IMABS.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPageDataContextRetriever pageDataContextRetriever;
        private readonly HomeRepository homeRepository;
        private readonly IPageDataContextInitializer pageDataContextInitializer;

        public HomeController(IPageDataContextRetriever _pageDataContextRetriever,
            HomeRepository _homeRepository,
            IPageDataContextInitializer _pageDataContextInitializer)
        {
            pageDataContextRetriever = _pageDataContextRetriever;
            this.homeRepository = _homeRepository;
            pageDataContextInitializer = _pageDataContextInitializer;
        }
        public IActionResult Index()
        {
            var home = HomeProvider.GetHomes().FirstOrDefault(); //pageDataContextRetriever.Retrieve<Home>().Page;
            HomeViewModel homeView = new HomeViewModel()
            {
                bannerSections = homeRepository.GetBanners().Select(BannerSectionViewModel.GetViewModel).ToList(),
                whyIngramOptions = homeRepository.GetWhyIngramOptions().Select(WhyIngramOptionViewModel.GetViewModel).ToList(),
                homePopupDetails = HomePopupViewModel.GetViewModel(HomePopupProvider.GetHomePopups())
            };

            ViewBag.EnableCallToTactionBanner = home.Fields.EnableCallToTactionBanner;
            ViewBag.EnablePromotionsBanner = home.Fields.EnablePromotionsBanner;

            pageDataContextInitializer.Initialize(home);

            return View(homeView);
        }
    }
}
