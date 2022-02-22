using Kentico.Components.Web.Mvc.FormComponents;
using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System.Collections.Generic;

namespace IMABS.Components.Widgets.SupportWidget
{
    public class SupportWidgetProperties : IWidgetProperties
    {
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 1, Label = "Title", ExplanationText = "(Category Name)")]
        public string Title { get; set; }

        //[EditingComponent(TextInputComponent.IDENTIFIER, Order = 3, Label = "Icon Class")]
        //[EditingComponent("IMABS.IconSelector", DefaultValue = "", ExplanationText = "", Label = "Select Icon", Order = 3)]
        //[EditingComponent("IMABS.IconSelector")]
        //public string IconClass { get; set; }
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 2, Label = "Description", ExplanationText = "(Description under the title)")]
        public string Description { get; set; }

        [EditingComponent(MediaFilesSelector.IDENTIFIER, Order = 4)]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.MaxFilesLimit), 1)]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.AllowedExtensions), ".gif;.png;.jpg;.jpeg;.svg;")]
        public IList<MediaFilesSelectorItem> Image { get; set; }


        [EditingComponent("IMABS.IconSelector", DefaultValue = "", ExplanationText = "", Label = "Select Support Class Type", Order = 5)]
        public string IconClass { get; set; }


        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 6, Label = "Redirection Url", ExplanationText = "(Redirection path when user click on this widget)  OR")]
        public string RedirectionUrl { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 7, Label = "Email Id", ExplanationText = "(Email id)")]
        public string EmailId { get; set; }
    }
}
