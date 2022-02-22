using CMS.DocumentEngine.Types.IMABS;

namespace IMABS.Models.Homes.ActionLinks
{
    public class ActionLinkViewModel
    {
        public string ItemName { get; set; }
        public string ItemUrl { get; set; }
        public string ItemIconClass { get; set; }
        public string ResourceType { get; set; }
        public bool HasChildren { get; set; }
        public int NodeOrder { get; set; }

        public static ActionLinkViewModel GetViewModel(ActionLink actionLink)
        {
            return actionLink == null ? null : new ActionLinkViewModel
            {
                ItemName = actionLink.Fields.ItemName,
                ItemUrl = actionLink.Fields.ItemUrl,
                ResourceType = actionLink.Fields.ResourceType,
                ItemIconClass = actionLink.Fields.ItemIconClass,
                HasChildren = actionLink.NodeHasChildren,
                NodeOrder = actionLink.NodeOrder
            };
        }
    }
}
