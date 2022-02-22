using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.IMABS;
using CMS.SiteProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMABS.Repositories
{
    public class TabsRepository //: ITabsRepository
    {

        public List<Tabs> GetTabs()
        {
            return TabsProvider.GetTabs()
                //.LatestVersion(mLatestVersionEnabled)
                //.Published(!mLatestVersionEnabled)
                .Published(true)
                .OnSite(SiteContext.CurrentSiteName)
                //.Culture(mCultureName)
                .CombineWithDefaultCulture()
                .OrderBy("NodeOrder")
                //.TopN(3)
                .Where(x => x.IsActive)
                .ToList();
        }

        public List<AccordionItem> GetItems(string nodeAliasPath)
        {
            return AccordionItemProvider.GetAccordionItems()
                //.LatestVersion(mLatestVersionEnabled)
                //.Published(!mLatestVersionEnabled)
                .Path(nodeAliasPath, PathTypeEnum.Children)
                .Published(true)
                .OnSite(SiteContext.CurrentSiteName)
                //.Culture(mCultureName)
                .CombineWithDefaultCulture()
                //.OrderBy("NodeOrder")
                .ToList();
        }
    }

    //public interface ITabsRepository
    //{
    //    List<Tabs> GetTabs();
    //}
}
