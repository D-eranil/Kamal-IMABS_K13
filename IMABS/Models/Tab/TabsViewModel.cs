using CMS.DocumentEngine.Types.IMABS;
using CMS.MediaLibrary;
using IMABS.Repositories;
using Kentico.Content.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMABS.Models.Tab
{
    public class TabsViewModel
    {
        public string TabsName { get; set; }
        public bool? IsActive { get; set; }
        public string Image { get; set; }

        public List<AccordionItemViewModel> Items { get; set; }

        public static TabsViewModel GetViewModel(Tabs tabs, TabsRepository tabsRepository, IMediaFileUrlRetriever mediaFileUrlRetriever, IEnumerable<MediaFileInfo> mediaLibraryFiles)
        {
            var objTabsViewModel = new TabsViewModel();
            try
            {
                objTabsViewModel = tabs == null ? null : new TabsViewModel()
                {
                    TabsName = tabs.Fields.Name,
                    Image = tabs.Fields.Image,
                    IsActive = tabs.Fields.IsActive,
                    Items = tabsRepository.GetItems(tabs.NodeAliasPath).Select(sel => AccordionItemViewModel.GetViewModel(sel)).ToList()
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objTabsViewModel;
        }
    }

    public class AccordionItemViewModel
    {
        public int NodeId { get; set; }
        public string Heading { get; set; }
        public string Content { get; set; }


        public static AccordionItemViewModel GetViewModel(AccordionItem accordionItem)
        {
            var objAccordionItemViewModel = new AccordionItemViewModel();
            try
            {
                objAccordionItemViewModel = accordionItem == null ? null : new AccordionItemViewModel()
                {
                    NodeId = accordionItem.NodeID,
                    Heading = accordionItem.Heading,
                    Content = accordionItem.Content
                };
            }
            catch (Exception ex)
            {
                //manage log here
                throw ex;
            }
            return objAccordionItemViewModel;
        }
    }
}
