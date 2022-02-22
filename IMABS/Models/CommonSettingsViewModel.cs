using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMABS.Models
{
    public class CommonSettingsViewModel
    {
        public bool EnableCallToTactionBanner { get; set; }
        public bool EnablePromotionsBanner { get; set; }
        public bool EnableBreadcrumb { get; set; }
        public bool AllowToViewInHeader { get; set; }
        public bool AllowToViewInFooter { get; set; }
    }
}
