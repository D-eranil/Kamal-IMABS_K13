using CMS.DocumentEngine.Types.IMABS;
using Kentico.Content.Web.Mvc;

namespace IMABS.Models.ResourceLinks
{
    public class ResourceLinkViewModel
    {
        public int ResourceLinkID { get; set; }
        public string ItemName { get; set; }
        public string ItemUrl { get; set; }
        public string Resource { get; set; }
        public string ResourceType { get; set; }
        public bool HasChildren { get; set; }
        public int NodeOrder { get; set; }
        public string WindowTarget { get; set; }
        public string ResourcePath { get; set; }


        public static ResourceLinkViewModel GetViewModel(ResourceLink resourceLink)
        {
            return resourceLink == null ? null : new ResourceLinkViewModel
            {
                ResourceLinkID = resourceLink.ResourceLinkID,
                ItemName = resourceLink.Fields.ActionLinkItemName,
                ItemUrl = resourceLink.Fields.ActionLinkItemUrl,
                ResourceType = resourceLink.Fields.ResourceType,
                Resource = resourceLink.Fields.Resource,
                HasChildren = resourceLink.NodeHasChildren,
                NodeOrder = resourceLink.NodeOrder,
                WindowTarget = resourceLink.Fields.WindowTarget,
                ResourcePath = resourceLink.Fields.ResourcePath?.GetPath()
            };
        }
    }
}
