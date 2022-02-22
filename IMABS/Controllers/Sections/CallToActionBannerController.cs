using IMABS.Models.Banners.CallToActionBanner;
using IMABS.Repositories;
using Kentico.Content.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace IMABS.Controllers.Sections
{
    public class CallToActionBannerController : Controller
    {
        public ActionResult Index()
        {
            //AcceptVerbsAttribute page = DocumentHelper.GetDocuments<CallToActionBanner>().PublishedVersion().Published()

            BannersRepository banners = new BannersRepository();
            var page = banners.GetCurrentCallToActionBanner();
            var model = new CallToActionBannerViewModel();
            if (page == null)
            {
                //return HttpNotFound();
                return null;
            }
            else
            {
                model.BackgroundImage = page.Fields.SectionImage.GetPath();
                model.CTAButtonLink = page.Fields.CTAButtonLink;
                model.CTAButtonText = page.Fields.CTAButtonTitle;
                model.Description = page.Fields.Description;
                model.SubTitle = page.Fields.SubTitle;
                model.Title = page.Fields.Title;
            }
            return PartialView("Sections/_CallToActionBanner", model);
        }
    }
}
