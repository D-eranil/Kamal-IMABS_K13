using Kentico.Components.Web.Mvc.FormComponents;
using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMABS.Components.Widgets.VideoCardWidget
{
    public class VideoCardWidgetProperties : IWidgetProperties
    {
        /// <summary>
     /// Titel to be displayed.
     /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 1, Label = "Video Title")]
        public string VideoTitle { get; set; }



        /// <summary>
        /// Guid of an image to be displayed.
        /// </summary>
        /// 
        [EditingComponent(MediaFilesSelector.IDENTIFIER, Order = 2, Label = "Video Icon Image")]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.LibraryName), "IMABS.Media")]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.AllowedExtensions), ".gif;.svg;.png;.jpg;.jpeg")]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.MaxFilesLimit), 1)]
        //[EditingComponent(FileUploaderComponent.IDENTIFIER, Order = 3, Label = "Background Image")]
        public IList<MediaFilesSelectorItem> VideoIconImage { get; set; }

        /// <summary>
        /// Titel to be displayed on hover.
        /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 3, Label = "Video Icon Alt Text")]
        public string VideoIconAltText { get; set; }

        /// <summary>
        /// Titel to be displayed on hover.
        /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 4, Label = "Redirection Url")]
        public string RedirectionUrl { get; set; }

    }
}
