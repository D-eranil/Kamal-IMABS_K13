using CMS.CustomTables;
using CMS.CustomTables.Types.IMABS;
using CMS.Helpers;
using Kentico.Forms.Web.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System.Collections.Generic;
using System.Linq;

namespace IMABS.Components.ViewComponents.IconSelectorDropDown
{
    public class IconSelectorDropDownViewComponent: SelectorFormComponent<IconDropDownComponentProperties>
    {
        
        ////GET: IconDropDownComponent
        //public ViewViewComponentResult Invoke(IconDropDownComponentProperties properties)
        //{
        //    return View("~/Components/Widgets/FeatureWidget/_FeatureWidget.cshtml", new FeatureWidgetViewModel
        //    {
        //        BackgroundImageUrl = $"/getattachment/" + properties.BackgroundImage?.FirstOrDefault().FileGuid + "/attachment.aspx", //image == null ? null : mediaFileUrlRetriever.Retrieve(image).RelativePath,
        //        HoverTitle = properties.HoverTitle,
        //        Title = properties.Title,
        //        ActionLinkUrl = properties.ActionLinkUrl
        //    });

        //}
        //// Retrieves data to be displayed in the selector
        //protected override IEnumerable<SelectListItem> GetItems()
        //{

        //    return CustomTableItemProvider.GetItems(IconClassItem.CLASS_NAME)
        //                                      .ToList().Select(x => new SelectListItem
        //                                      {
        //                                          Text = ValidationHelper.GetString(x.GetValue("Name"), ""),
        //                                          Value = ValidationHelper.GetString(x.GetValue("Value"), ""),
        //                                      }).ToList();

        //}
        //private readonly MediaFileRepository mediaFileRepository;
        //private readonly IMediaFileUrlRetriever mediaFileUrlRetriever;


        ///// <summary>
        ///// Creates an instance of <see cref="FeatureWidgetViewComponent"/> class.
        ///// </summary>
        ///// <param name="mediaFileRepository">Repository for media files.</param>
        ///// <param name="mediaFileUrlRetriever">The media file URL retriever.</param>
        //public FeatureWidgetViewComponent(MediaFileRepository mediaFileRepository, IMediaFileUrlRetriever mediaFileUrlRetriever)
        //{
        //    this.mediaFileRepository = mediaFileRepository;
        //    this.mediaFileUrlRetriever = mediaFileUrlRetriever;
        //}

        //private MediaFileInfo GetImage(FeatureWidgetProperties properties)
        //{
        //    var imageGuid = properties.BackgroundImage.FirstOrDefault()?.FileGuid ?? Guid.Empty;
        //    if (imageGuid == Guid.Empty)
        //    {
        //        return null;
        //    }

        //    return mediaFileRepository.GetMediaFile(imageGuid, SiteContext.CurrentSiteID);
        //}


    }
}
