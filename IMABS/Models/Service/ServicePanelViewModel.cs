using CMS.DocumentEngine.Types.IMABS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMABS.Models.Service
{
    public class ServicePanelViewModel
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string LinkText { get; set; }
        public string LinkUrl { get; set; }
        public string pageUrl { get; set; }
        public int NodeOrder { get; set; }
        public static ServicePanelViewModel GetViewModel(ServicePanel servicePanel)
        {
            return servicePanel == null ? null : new ServicePanelViewModel
            {
                Title = servicePanel.Fields.Title,
                SubTitle = servicePanel.SubTItle,
                LinkText = servicePanel.Fields.LinkText,
                LinkUrl = servicePanel.Fields.LinkUrl,
                pageUrl = servicePanel.NodeAliasPath,
                NodeOrder = servicePanel.NodeOrder
            };
        }
    }
}
