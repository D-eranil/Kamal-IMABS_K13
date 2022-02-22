using Kentico.Components.Web.Mvc.FormComponents;
using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System.Collections.Generic;

namespace IMABS.Components.Widgets.CTATileWidget
{
	public class CTATileWidgetProperties : IWidgetProperties
    {
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 1, Label = "Title")]
        public string Title { get; set; }

        [EditingComponent(MediaFilesSelector.IDENTIFIER, Order = 2)]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.MaxFilesLimit), 1)]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.AllowedExtensions), ".gif;.png;.jpg;.jpeg;.svg;")]
        public IList<MediaFilesSelectorItem> Image { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 3, Label = "Redirection Url", ExplanationText = "(Redirection path when user click on this widget)")]
        public string RedirectionUrl { get; set; }

    }
}
