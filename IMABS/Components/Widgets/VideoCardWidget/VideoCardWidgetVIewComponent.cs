using CMS.MediaLibrary;
using CMS.SiteProvider;
using IMABS.Repositories;
using Kentico.Content.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Linq;

namespace IMABS.Components.Widgets.VideoCardWidget
{
    public class VideoCardWidgetVIewComponent : ViewComponent
    {
        private readonly MediaFileRepository mediaFileRepository;
        private readonly IMediaFileUrlRetriever mediaFileUrlRetriever;


        /// <summary>
        /// Creates an instance of <see cref="FeatureWidgetViewComponent"/> class.
        /// </summary>
        /// <param name="mediaFileRepository">Repository for media files.</param>
        /// <param name="mediaFileUrlRetriever">The media file URL retriever.</param>
        public VideoCardWidgetVIewComponent(MediaFileRepository mediaFileRepository, IMediaFileUrlRetriever mediaFileUrlRetriever)
        {
            this.mediaFileRepository = mediaFileRepository;
            this.mediaFileUrlRetriever = mediaFileUrlRetriever;
        }

        private MediaFileInfo GetImage(VideoCardWidgetProperties properties)
        {
            var imageGuid = properties.VideoIconImage?.FirstOrDefault()?.FileGuid ?? Guid.Empty;
            if (imageGuid == Guid.Empty)
            {
                return null;
            }

            return mediaFileRepository.GetMediaFile(imageGuid, SiteContext.CurrentSiteID);
        }


        // GET: FeatureWidget
        public ViewViewComponentResult Invoke(VideoCardWidgetProperties properties)
        {
            var image = GetImage(properties);

            return View("~/Components/Widgets/VideoCardWidget/_VideoCardWidget.cshtml", new VideoCardWidgetViewModel
            {
                VideoIconImage = image == null ? null : mediaFileUrlRetriever.Retrieve(image).RelativePath,
                VideoIconAltText = properties.VideoIconAltText,
                VideoTitle = properties.VideoTitle,
                RedirectionUrl = properties.RedirectionUrl
            });
        }
    }
}
