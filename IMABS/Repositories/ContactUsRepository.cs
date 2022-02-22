using CMS.DocumentEngine.Types.IMABS;
using CMS.SiteProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMABS.Repositories
{
	public class ContactUsRepository
	{
        /// <summary>
        /// get contactus sections
        /// </summary>
        /// <returns>ContactUsSection</returns>
        public List<ContactUsSection> GetContactUsSections()
        {
            return ContactUsSectionProvider.GetContactUsSections()
                .Published(true)
                .OnSite(SiteContext.CurrentSiteName)
                .CombineWithDefaultCulture()
                .OrderBy("NodeOrder")
                .ToList();
        }
    }
}
