using CMS.CustomTables;
using CMS.CustomTables.Types.IMABS;
using CMS.Helpers;
using IMABS.Components.ViewComponents.IconSelectorDropDown;
using Kentico.Forms.Web.Mvc;
using Kentico.Web.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace IMABS.Components.FormComponents.IconSelectorDropDown
{
    public class IconSelectorDropDownComponent : SelectorFormComponent<IconDropDownComponentProperties>
    {
        public const string IDENTIFIER = "IconDropDownComponent";

        // Retrieves data to be displayed in the selector
        protected override IEnumerable<HtmlOptionItem> GetHtmlOptions()
        {
            var sampleData = CustomTableItemProvider.GetItems(IconClassItem.CLASS_NAME)
                                                .ToList().Select(x => new SelectListItem
                                                {
                                                    Text = ValidationHelper.GetString(x.GetValue("Name"), ""),
                                                    Value = ValidationHelper.GetString(x.GetValue("Value"), ""),
                                                }).ToList();

            // Iterates over retrieved data and transforms it into SelectListItems
            foreach (var item in sampleData)
            {
                var listItem = new HtmlOptionItem()
                {
                    Value = item.Value,
                    Text = item.Text
                };

                yield return listItem;
            }

        }
    }
}