using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;

namespace IMABS.Components.Widgets.CTAButton
{
    public class CTAButtonWidgetProperties : IWidgetProperties
    {
        [EditingComponent(DropDownComponent.IDENTIFIER, Order = 0, Label = "Button Align")]
        [EditingComponentProperty(nameof(DropDownProperties.DataSource), "text-center;Center\r\ntext-left;Left\r\ntext-right;Right")]
        public string CTAAlign { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 1, Label = "Button text")]
        public string LinkText { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 2, Label = "CSS class")]
        public string LinkCSSClass { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 3, Label = "Enter URL")]
        public string LinkURL { get; set; }

        //[EditingComponent(TextInputComponent.IDENTIFIER, Order = 4, Label = "Enter target to open in specifed window")]
        // Assigns a selector component to the SelectedOption property
        [EditingComponent(DropDownComponent.IDENTIFIER, Order = 4, Label = "Open in")]
        // Configures the list options available in the selector
        [EditingComponentProperty(nameof(DropDownProperties.DataSource), "_blank;New Window\r\n_self;Self\r\n_parent;Parent;_top:Full Window")]
        public string LinkTarget { get; set; }
    }
}
