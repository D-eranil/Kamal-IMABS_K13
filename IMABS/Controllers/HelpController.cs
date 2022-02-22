using CMS.Base;
using CMS.DocumentEngine.Types.IMABS;
using CMS.MediaLibrary;
using IMABS.Controllers;
using IMABS.Models.Helps;
using IMABS.Repositories;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
[assembly: RegisterPageRoute(Help.CLASS_NAME, typeof(HelpController))]

namespace IMABS.Controllers
{
    public class HelpController : Controller
    {
        private readonly IPageDataContextRetriever dataRetriever;
        private readonly IPageDataContextInitializer pageDataContextInitializer;
        private readonly TabsRepository tabsRepository;


        private readonly IMediaFileUrlRetriever mediaFileUrlRetriever;
        private readonly IMediaLibraryInfoProvider mediaLibraryInfoProvider;
        private readonly IMediaFileInfoProvider mediaFileInfoProvider;
        private readonly ISiteService siteService;

        public HelpController(IPageDataContextRetriever dataRetriever,
            IPageDataContextInitializer _pageDataContextInitializer, TabsRepository _tabsRepository,
            IMediaFileUrlRetriever mediaFileUrlRetriever,
                              IMediaLibraryInfoProvider mediaLibraryInfoProvider,
                              IMediaFileInfoProvider mediaFileInfoProvider,
                              ISiteService siteService)
        {
            this.dataRetriever = dataRetriever;
            pageDataContextInitializer = _pageDataContextInitializer;
            //Repository
            tabsRepository = _tabsRepository;
            //Media Library
            this.mediaFileUrlRetriever = mediaFileUrlRetriever;
            this.mediaLibraryInfoProvider = mediaLibraryInfoProvider;
            this.mediaFileInfoProvider = mediaFileInfoProvider;
            this.siteService = siteService;

        }


        public IActionResult Index()
        {
            var ls = dataRetriever.Retrieve<Help>().Page;
            if (ls == null)
            {
                return null;
            }
            pageDataContextInitializer.Initialize(ls);

            // Gets an instance of the 'SampleMediaLibrary' media library for the current site
            MediaLibraryInfo mediaLibrary = mediaLibraryInfoProvider.Get("IMABS.Media", siteService.CurrentSite.SiteID);

            // Gets a collection of media files with the .jpg extension from the media library
            IEnumerable<MediaFileInfo> mediaLibraryFiles = mediaFileInfoProvider.Get()
                                        .WhereEquals("FileLibraryID", mediaLibrary.LibraryID);//TabsID
                                        //.WhereEquals("FileExtension", ".svg");

            //view model code
            var model = HelpViewModel.GetViewModel(ls, tabsRepository, mediaFileUrlRetriever, mediaLibraryFiles);
            //model.Tabs = new List<Models.Tab.TabsViewModel>();

            ViewBag.EnableCallToTactionBanner = ls.Fields.EnableCallToTactionBanner;
            ViewBag.EnableBreadcrumb = ls.Fields.EnableBreadcrumb;

            return View(model);
        }
    }
}
