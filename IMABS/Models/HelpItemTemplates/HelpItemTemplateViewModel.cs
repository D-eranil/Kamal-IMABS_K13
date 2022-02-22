using CMS.DocumentEngine.Types.IMABS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMABS.Models.HelpItemTemplates
{
    public class HelpItemTemplateViewModel
    {
        public string PageName { get; set; }
        public string Heading { get; set; }
        public string Content { get; set; }
        public string SearchTitle { get; set; }
        public string SearchPlaceholder { get; set; }
        public string SearchButtonText { get; set; }
        public string ParentPageName { get; set; }

        public static HelpItemTemplateViewModel GetViewModel(HelpItemTemplate helpItemTemplate, int nodeId)
        {
            var objHelpItemTemplateViewModel = new HelpItemTemplateViewModel();
            try
            {
                AccordionItem objHelpItemTemplate = AccordionItemProvider.GetAccordionItem(nodeId, helpItemTemplate.DocumentCulture, helpItemTemplate.NodeSiteName).FirstOrDefault();
                objHelpItemTemplateViewModel = helpItemTemplate == null ? null : new HelpItemTemplateViewModel()
                {

                    //map property form entity to model
                    PageName = objHelpItemTemplate.Fields.Heading,
                    Heading = objHelpItemTemplate.Fields.Heading,
                    Content = objHelpItemTemplate.Fields.Content,
                    SearchButtonText = helpItemTemplate.Fields.SearchButtonText,
                    SearchPlaceholder = helpItemTemplate.Fields.SearchPlaceholder,
                    SearchTitle = helpItemTemplate.Fields.SearchTitle,
                    ParentPageName = helpItemTemplate.Parent?.DocumentName,

                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objHelpItemTemplateViewModel;
        }
    }
}
