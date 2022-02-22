using CMS.DocumentEngine.Types.IMABS;
using CMS.MediaLibrary;
using IMABS.Models.Tab;
using IMABS.Repositories;
using Kentico.Content.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMABS.Models.Helps
{
    public class HelpViewModel : CommonSettingsViewModel
    {



        public string PageName { get; set; }
        public string SearchPlaceholderText { get; set; }
        public string SearchButtonText { get; set; }

        public List<TabsViewModel> Tabs { get; set; }

        public static HelpViewModel GetViewModel(Help help, TabsRepository tabsRepository, IMediaFileUrlRetriever mediaFileUrlRetriever, IEnumerable<MediaFileInfo> mediaLibraryFiles)
        {
            var objHelpViewModel = new HelpViewModel();
            try
            {
                objHelpViewModel = help == null ? null : new HelpViewModel()
                {

                    //map property form entity to model
                    PageName = help.Fields.PageName,
                    SearchPlaceholderText = help.Fields.SearchPlaceholderText,
                    SearchButtonText = help.Fields.SearchButtonText,
                    AllowToViewInHeader = help.Fields.AllowToViewInHeader,
                    AllowToViewInFooter = help.Fields.AllowToViewInFooter,
                    EnableBreadcrumb = help.Fields.EnableBreadcrumb,
                    EnableCallToTactionBanner = help.Fields.EnableCallToTactionBanner,
                    EnablePromotionsBanner = help.Fields.EnablePromotionsBanner,
                    Tabs = tabsRepository.GetTabs().Select(sel => TabsViewModel.GetViewModel(sel, tabsRepository, mediaFileUrlRetriever, mediaLibraryFiles)).ToList()
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objHelpViewModel;
        }


    }
}
