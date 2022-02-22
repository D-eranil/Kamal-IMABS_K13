using CMS.MediaLibrary;
using CMS.SiteProvider;
using IMABS.Repositories;
using Kentico.Content.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Linq;

namespace IMABS.Components.Widgets.FeatureWidget
{
    public class FeatureWidgetViewComponent : ViewComponent
    {
        private readonly MediaFileRepository mediaFileRepository;
        private readonly IMediaFileUrlRetriever mediaFileUrlRetriever;


        /// <summary>
        /// Creates an instance of <see cref="FeatureWidgetViewComponent"/> class.
        /// </summary>
        /// <param name="mediaFileRepository">Repository for media files.</param>
        /// <param name="mediaFileUrlRetriever">The media file URL retriever.</param>
        public FeatureWidgetViewComponent(MediaFileRepository mediaFileRepository, IMediaFileUrlRetriever mediaFileUrlRetriever)
        {
            this.mediaFileRepository = mediaFileRepository;
            this.mediaFileUrlRetriever = mediaFileUrlRetriever;
        }
        
        private MediaFileInfo GetImage(FeatureWidgetProperties properties)
        {
            var imageGuid = properties.BackgroundImage.FirstOrDefault()?.FileGuid ?? Guid.Empty;
            if (imageGuid == Guid.Empty)
            {
                return null;
            }

            return mediaFileRepository.GetMediaFile(imageGuid, SiteContext.CurrentSiteID);
        }


        // GET: FeatureWidget
        public ViewViewComponentResult Invoke(FeatureWidgetProperties properties)
        {
            var image = GetImage(properties);
            var imag = $"/getattachment/" + properties.BackgroundImage?.FirstOrDefault().FileGuid + "/attachment.aspx";
            return View("~/Components/Widgets/FeatureWidget/_FeatureWidget.cshtml", new FeatureWidgetViewModel
            {
                BackgroundImageUrl = image == null ? null : mediaFileUrlRetriever.Retrieve(image).RelativePath,
                HoverTitle = properties.HoverTitle,
                Title = properties.Title,
                ActionLinkUrl = properties.ActionLinkUrl
            });
        }
    }
}
