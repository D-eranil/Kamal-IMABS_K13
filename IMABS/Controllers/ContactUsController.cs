using CMS.DocumentEngine.Types.IMABS;
using IMABS.Controllers;
using IMABS.Models.ContactUs;
using IMABS.Repositories;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

[assembly: RegisterPageRoute(ContactUs.CLASS_NAME, typeof(ContactUsController))]
namespace IMABS.Controllers
{
	public class ContactUsController : Controller
	{
        private readonly IPageDataContextRetriever pageDataContextRetriever;
        private readonly ContactUsRepository contactUsRepository;
        private readonly IPageDataContextInitializer pageDataContextInitializer;

        public ContactUsController(IPageDataContextRetriever _pageDataContextRetriever,
            ContactUsRepository _contactUsRepository,
            IPageDataContextInitializer _pageDataContextInitializer)
        {
            pageDataContextRetriever = _pageDataContextRetriever;
            this.contactUsRepository = _contactUsRepository;
            pageDataContextInitializer = _pageDataContextInitializer;
        }
        public async Task<ActionResult> Index()
        {
            var contactUs = pageDataContextRetriever.Retrieve<ContactUs>().Page;
            ContactUsViewModel contactUsView = new ContactUsViewModel()
            {
                Title= contactUs.ContactusTitle,
                contactUsSections = contactUsRepository.GetContactUsSections().Select(ContactUsSectionViewModel.GetViewModel).ToList()
            };

            ViewBag.EnableCallToTactionBanner = contactUs.Fields.EnableCallToTactionBanner;
            ViewBag.EnablePromotionsBanner = contactUs.Fields.EnablePromotionsBanner;
            ViewBag.EnableBreadcrumb = contactUs.Fields.EnableBreadcrumb;

            pageDataContextInitializer.Initialize(contactUs);

            return View(contactUsView);
        }
    }
}
