using Kentico.Components.Web.Mvc.FormComponents;
using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System.Collections.Generic;

namespace IMABS.Components.Widgets.HeaderBannerWidget
{
	public class HeaderBannerWidgetProperties : IWidgetProperties
    {

        /// <summary>
        /// Background.
        /// </summary>
        [EditingComponent(DropDownComponent.IDENTIFIER, Order = 0, Label = "Background")]
        [EditingComponentProperty(nameof(DropDownProperties.DataSource), "none;None\r\nbg-white;White")]
        public string Background { get; set; }

        /// <summary>
        /// Titel to be displayed.
        /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 1, Label = "Title")]
        public string Title { get; set; }


        /// <summary>
        /// Sub titel to be displayed.
        /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 2, Label = "Sub Title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// Description to be displayed.
        /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 3, Label = "Description")]
        public string Description { get; set; }


        /// <summary>
        /// Guid of an mobile image to be displayed.
        /// </summary>
        /// 
        [EditingComponent(MediaFilesSelector.IDENTIFIER, Order = 4, Label = "Mobile Image")]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.AllowedExtensions), ".gif;.svg;.png;.jpg;.jpeg")]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.MaxFilesLimit), 1)]
        public IList<MediaFilesSelectorItem> MobileImage { get; set; }

        /// <summary>
        /// Guid of an tablet image to be displayed.
        /// </summary>
        /// 
        [EditingComponent(MediaFilesSelector.IDENTIFIER, Order = 5, Label = "Tablet Image")]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.AllowedExtensions), ".gif;.svg;.png;.jpg;.jpeg")]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.MaxFilesLimit), 1)]
        public IList<MediaFilesSelectorItem> TabletImage { get; set; }

        /// <summary>
        /// Guid of an desktop image to be displayed.
        /// </summary>
        /// 
        [EditingComponent(MediaFilesSelector.IDENTIFIER, Order = 6, Label = "Desktop Image")]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.AllowedExtensions), ".gif;.svg;.png;.jpg;.jpeg")]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.MaxFilesLimit), 1)]
        public IList<MediaFilesSelectorItem> DesktopImage { get; set; }

    }
}
