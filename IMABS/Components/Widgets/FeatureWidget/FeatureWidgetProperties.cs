using Kentico.Components.Web.Mvc.FormComponents;
using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System.Collections.Generic;

namespace IMABS.Components.Widgets.FeatureWidget
{
    public class FeatureWidgetProperties : IWidgetProperties
    {
        /// <summary>
        /// Titel to be displayed.
        /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 1, Label = "Title")]
        public string Title { get; set; }


        /// <summary>
        /// Titel to be displayed on hover.
        /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 2, Label = "Hover Title")]
        public string HoverTitle { get; set; }


        /// <summary>
        /// Guid of an image to be displayed.
        /// </summary>
        /// 
        [EditingComponent(MediaFilesSelector.IDENTIFIER, Order = 3, Label = "Background Image")]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.LibraryName), "IMABS.Media")]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.AllowedExtensions), ".gif;.svg;.png;.jpg;.jpeg")]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.MaxFilesLimit), 1)]
        //[EditingComponent(FileUploaderComponent.IDENTIFIER, Order = 3, Label = "Background Image")]
        public IList<MediaFilesSelectorItem> BackgroundImage { get; set; }

        /// <summary>
        /// Titel to be displayed on hover.
        /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 4, Label = "Redirection Url (Action Link Url)")]
        public string ActionLinkUrl { get; set; }


    }
}
