using CMS.DocumentEngine.Types.IMABS;

namespace IMABS.Models.Headers.TopNavigations
{
    public class TopMenuViewModel
    {
        public string NavigationItemName { get; set; }
        public string NavigationItemUrl { get; set; }
        public string IconClass { get; set; }
        public string NodeHasChild { get; set; }
        public string NodeLevel { get; set; }
        public string NodeOrder { get; set; }
        public static TopMenuViewModel GetViewModel(TopNavigation topNavigation)
        {
            return topNavigation == null ? null : new TopMenuViewModel
            {
                NavigationItemName = topNavigation.Fields.NavigationItemName,
                NavigationItemUrl = topNavigation.Fields.NavigationItemUrl,
                IconClass = topNavigation.Fields.IconClass,
                NodeHasChild = topNavigation.NodeHasChildren.ToString(),
                NodeLevel = topNavigation.NodeLevel.ToString(),
                NodeOrder = topNavigation.NodeOrder.ToString()
            };
        }
    }
}
