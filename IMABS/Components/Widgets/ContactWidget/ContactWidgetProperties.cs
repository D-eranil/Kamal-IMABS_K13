using Kentico.Components.Web.Mvc.FormComponents;
using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;

namespace IMABS.Components.Widgets.ContactWidget
{
	public class ContactWidgetProperties : IWidgetProperties
    {

        [EditingComponent(DropDownComponent.IDENTIFIER, Order = 1, Label = "Background")]
        [EditingComponentProperty(nameof(DropDownProperties.DataSource), "none;None\r\nbg-white;White\r\nbgblue;Grey\r\nbglightgrey;Light Grey")]
        public string Background { get; set; }

        /// <summary>
        /// HTML formatted text.
        /// </summary>
        [EditingComponent(RichTextComponent.IDENTIFIER, Order = 2, Label = "Text")]
        public string Text { get; set; }

    }
}
