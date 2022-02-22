using CMS.MediaLibrary;
using CMS.SiteProvider;
using IMABS.Repositories;
using Kentico.Content.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Linq;

namespace IMABS.Components.Widgets.ImageCardWidget
{
    public class ImageCardWidgetViewComponent : ViewComponent
    {
        private readonly MediaFileRepository mediaFileRepository;
        private readonly IMediaFileUrlRetriever mediaFileUrlRetriever;


        /// <summary>
        /// Creates an instance of <see cref="FeatureWidgetViewComponent"/> class.
        /// </summary>
        /// <param name="mediaFileRepository">Repository for media files.</param>
        /// <param name="mediaFileUrlRetriever">The media file URL retriever.</param>
        public ImageCardWidgetViewComponent(MediaFileRepository mediaFileRepository, 
            IMediaFileUrlRetriever mediaFileUrlRetriever)
        {
            this.mediaFileRepository = mediaFileRepository;
            this.mediaFileUrlRetriever = mediaFileUrlRetriever;
        }

        private MediaFileInfo GetImage(ImageCardWidgetProperties properties)
        {
            var imageGuid = properties.ProfileImage?.FirstOrDefault()?.FileGuid ?? Guid.Empty;
            if (imageGuid == Guid.Empty)
            {
                return null;
            }

            return mediaFileRepository.GetMediaFile(imageGuid, SiteContext.CurrentSiteID);
        }


        // GET: FeatureWidget
        public ViewViewComponentResult Invoke(ImageCardWidgetProperties properties)
        {
            var image = GetImage(properties);

            return View("~/Components/Widgets/ImageCardWidget/_ImageCardWidget.cshtml", new ImageCardWidgetViewModel
            {
                ProfileImage = image == null ? null : mediaFileUrlRetriever.Retrieve(image).RelativePath,
                Name = properties.Name,
                Title = properties.Title,
                RedirectionButtonText = properties.RedirectionButtonText,
                RedirectionUrl = properties.RedirectionUrl,
                BioText = properties.BioText,
                SocialMediaText = properties.SocialMediaText?.Replace("<p>", "").Replace("</p>", "")
            }) ;
        }
    }
}
