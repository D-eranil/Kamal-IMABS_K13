using IMABS.Models.Headers.MainNavigations;
using System.Collections.Generic;

namespace IMABS.Models.Footers
{
    public class FooterViewModel
    {
        public List<MainMenuViewModel> MainMenuDtos { get; set; }
        public List<BottomMenuViewModel> BottomMenus { get; set; }
        public string FooterLogoUrl { get; set; }
        public string CopyRightText { get; set; }
        public string FooterLogoText { get; set; }
        public string FooterTNCText { get; set; }
    }
}
