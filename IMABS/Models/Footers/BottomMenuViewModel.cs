using CMS.DocumentEngine.Types.IMABS;

namespace IMABS.Models.Footers
{
    public class BottomMenuViewModel
    {
        public string NavigationItemName { get; set; }
        public string NavigationItemUrl { get; set; }
        public string NodeOrder { get; set; }
        public static BottomMenuViewModel GetViewModel(BottomNavigation bottomNavigation)
        {
            return bottomNavigation == null ? null : new BottomMenuViewModel
            {
                NavigationItemName = bottomNavigation.Fields.NavigationItemName,
                NavigationItemUrl = bottomNavigation.Fields.NavigationItemUrl,
                NodeOrder = bottomNavigation.NodeOrder.ToString()
            };
        }
    }
}
