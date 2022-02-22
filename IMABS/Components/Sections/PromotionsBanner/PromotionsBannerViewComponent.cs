using IMABS.Models.Banners.PromotionsBanners;
using IMABS.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace IMABS.Components.Sections.PromotionsBanner
{
    public class PromotionsBannerViewComponent : ViewComponent
    {
        // GET: CTAButtonWidget
        public ViewViewComponentResult Invoke()
        {
            BannersRepository banners = new BannersRepository();
            var page = banners.GetCurrentPromotionsBanner();
            if (page == null)
            {
                //return HttpNotFound();
                return null;
            }
            PromotionsBannerViewModel model = PromotionsBannerViewModel.GetViewModel(page);

            return View("~/Components/Sections/PromotionsBanner/_PromotionsBanner.cshtml", model);
        }
    }
}
