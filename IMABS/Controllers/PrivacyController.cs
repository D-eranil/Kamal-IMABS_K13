using CMS.DocumentEngine.Types.IMABS;
using IMABS.Controllers;
using IMABS.Models.Privacies;
using IMABS.Repositories;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;

[assembly: RegisterPageRoute(Privacy.CLASS_NAME, typeof(PrivacyController))]
namespace IMABS.Controllers
{
    public class PrivacyController : Controller
    {
        private readonly IPageDataContextRetriever dataRetriever;
        private readonly IPageDataContextInitializer pageDataContextInitializer;

        public PrivacyController(IPageDataContextRetriever dataRetriever,
            IPageDataContextInitializer _pageDataContextInitializer)
        {
            this.dataRetriever = dataRetriever;
            pageDataContextInitializer = _pageDataContextInitializer;
        }

        public IActionResult Index(string url)
        {
            var privacyPg = dataRetriever.Retrieve<Privacy>().Page;
            if (privacyPg == null)
            {
                return null;
            }
            pageDataContextInitializer.Initialize(privacyPg);

            PrivacyViewModel model = PrivacyViewModel.GetViewModel(privacyPg);

            return View(model);
        }
    }
}
