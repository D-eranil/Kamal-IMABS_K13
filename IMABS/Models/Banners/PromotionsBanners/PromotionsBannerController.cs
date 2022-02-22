using IMABS.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMABS.Models.Banners.PromotionsBanners
{
    public class PromotionsBannerController : Controller
    {

        public ActionResult Index()
        {
            //AcceptVerbsAttribute page = DocumentHelper.GetDocuments<CallToActionBanner>().PublishedVersion().Published()

            BannersRepository banners = new BannersRepository();
            var page = banners.GetCurrentPromotionsBanner();
            if (page == null)
            {
                return null;
            }

            PromotionsBannerViewModel model = PromotionsBannerViewModel.GetViewModel(page);

            return PartialView("Sections/_PromotionsBanner", model);
        }
    }
}
