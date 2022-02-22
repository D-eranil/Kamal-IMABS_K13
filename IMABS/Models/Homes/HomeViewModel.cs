using IMABS.Models.Banners;
using IMABS.Models.Homes.HomePopups;
using IMABS.Models.Homes.WhyIngramOptions;
using System.Collections.Generic;

namespace IMABS.Models.Homes
{
    public class HomeViewModel
    {
        public List<BannerSectionViewModel> bannerSections { get; set; }
        public List<WhyIngramOptionViewModel> whyIngramOptions { get; set; }
        public HomePopupViewModel homePopupDetails { get; set; }
    }
}
