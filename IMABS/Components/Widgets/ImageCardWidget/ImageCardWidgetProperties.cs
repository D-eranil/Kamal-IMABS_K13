using Kentico.Components.Web.Mvc.FormComponents;
using Kentico.Content.Web.Mvc;
using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System.Collections.Generic;

namespace IMABS.Components.Widgets.ImageCardWidget
{
    public class ImageCardWidgetProperties : IWidgetProperties
    {
        /// <summary>
        /// Titel to be displayed.
        /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 1, Label = "Profile name")]
        public string Name { get; set; }

        /// <summary>
        /// Titel to be displayed.
        /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 1, Label = "Profile Title")]
        public string Title { get; set; }



        /// <summary>
        /// Guid of an image to be displayed.
        /// </summary>
        /// 
        [EditingComponent(MediaFilesSelector.IDENTIFIER, Order = 2, Label = "Profile Image")]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.LibraryName), "IMABS.Media")]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.AllowedExtensions), ".gif;.svg;.png;.jpg;.jpeg")]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.MaxFilesLimit), 1)]
        //[EditingComponent(FileUploaderComponent.IDENTIFIER, Order = 3, Label = "Background Image")]
        public IList<MediaFilesSelectorItem> ProfileImage { get; set; }

        /// <summary>
        /// Titel to be displayed on hover.
        /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 3, Label = "Button Text")]
        public string RedirectionButtonText { get; set; }

        /// <summary>
        /// Titel to be displayed on hover.
        /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 4, Label = "Redirection Url")]
        public string RedirectionUrl { get; set; }

        
        [EditingComponent(RichTextComponent.IDENTIFIER, Order = 4, Label = "Bio text (HTML content)")]
        public string BioText { get; set; }


        [EditingComponent(RichTextComponent.IDENTIFIER, Order = 4, Label = "Social medial links (HTML)")]
        public string SocialMediaText { get; set; }

    }
}

