using Kentico.Components.Web.Mvc.FormComponents;
using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System.Collections.Generic;

namespace IMABS.Components.Widgets.ContributionWidget
{
    public class ContributionWidgetProperties : IWidgetProperties
    {
        /// <summary>
        /// Titel to be displayed.
        /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 1, Label = "Short description")]
        public string Title { get; set; }


        /// <summary>
        /// Guid of an image to be displayed.
        /// </summary>
        /// 
        [EditingComponent(MediaFilesSelector.IDENTIFIER, Order = 2, Label = "Background Image")]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.LibraryName), "IMABS.Media")]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.AllowedExtensions), ".gif;.svg;.png;.jpg;.jpeg")]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.MaxFilesLimit), 1)]
        //[EditingComponent(FileUploaderComponent.IDENTIFIER, Order = 3, Label = "Background Image")]
        public IList<MediaFilesSelectorItem> BackgroundImage { get; set; }

        /// <summary>
        /// Titel to be displayed on hover.
        /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 3, Label = "Image alt text")]
        public string ImgAltText { get; set; }


    }
}
