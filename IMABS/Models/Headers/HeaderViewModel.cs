using IMABS.Models.Footers;
using IMABS.Models.Headers.MainNavigations;
using IMABS.Models.Headers.TopNavigations;
using System.Collections.Generic;

namespace IMABS.Models.Headers
{
    public class HeaderViewModel
    {
        public List<TopMenuViewModel> TopMenus { get; set; }
        public List<MainMenuViewModel> MainMenuDtos { get; set; }
        public List<MainMenuViewModel> MainMenuFooterDtos { get; set; }
        public List<BottomMenuViewModel> BottomMenus { get; set; }
        public string HeaderLogoUrl { get; set; }
        public string HeaderLogoMobileUrl { get; set; }
        public string MainMenuCTAButtonText { get; set; }
        public string MainMenuCTAButtonLink { get; set; }
    }
}
