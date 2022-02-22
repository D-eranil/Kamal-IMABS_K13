using IMABS.Models.Banners.CallToActionBanner;
using IMABS.Repositories;
using Kentico.Content.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace IMABS.Components.Sections.CallToActionBanner
{
    
    public class CallToActionBannerViewComponent : ViewComponent
    {

        // GET: CTAButtonWidget
        public ViewViewComponentResult Invoke()
        {
            //var image = GetImage(properties);
            BannersRepository banners = new BannersRepository();
            CMS.DocumentEngine.Types.IMABS.CallToActionBanner page = new CMS.DocumentEngine.Types.IMABS.CallToActionBanner();

            if (ViewBag != null && ViewBag.PageCTABanner != null)
            {
                var nodeguid= System.Guid.Parse(ViewBag.PageCTABanner);
              page  = banners.GetCurrentCallToActionBanner(nodeguid);
            }
            else
            {
                page = banners.GetCurrentCallToActionBanner();
            }
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

            return View("~/Components/Sections/CallToActionBanner/_CallToActionBanner.cshtml", model);
        }
    }
}
