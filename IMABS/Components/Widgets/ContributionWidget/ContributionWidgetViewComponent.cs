using CMS.MediaLibrary;
using CMS.SiteProvider;
using IMABS.Repositories;
using Kentico.Content.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMABS.Components.Widgets.ContributionWidget
{
    public class ContributionWidgetViewComponent : ViewComponent
    {
        private readonly MediaFileRepository mediaFileRepository;
        private readonly IMediaFileUrlRetriever mediaFileUrlRetriever;


        /// <summary>
        /// Creates an instance of <see cref="FeatureWidgetViewComponent"/> class.
        /// </summary>
        /// <param name="mediaFileRepository">Repository for media files.</param>
        /// <param name="mediaFileUrlRetriever">The media file URL retriever.</param>
        public ContributionWidgetViewComponent(MediaFileRepository mediaFileRepository, 
                                                IMediaFileUrlRetriever mediaFileUrlRetriever)
        {
            this.mediaFileRepository = mediaFileRepository;
            this.mediaFileUrlRetriever = mediaFileUrlRetriever;
        }

        private MediaFileInfo GetImage(ContributionWidgetProperties properties)
        {
            var imageGuid = properties.BackgroundImage?.FirstOrDefault()?.FileGuid ?? Guid.Empty;
            if (imageGuid == Guid.Empty)
            {
                return null;
            }

            return mediaFileRepository.GetMediaFile(imageGuid, SiteContext.CurrentSiteID);
        }


        // GET: FeatureWidget
        public ViewViewComponentResult Invoke(ContributionWidgetProperties properties)
        {
            var image = GetImage(properties);
            var imag = $"/getattachment/" + properties.BackgroundImage?.FirstOrDefault().FileGuid + "/attachment.aspx";
            return View("~/Components/Widgets/ContributionWidget/_ContributionWidget.cshtml", new ContributionWidgetViewModel
            {
                BackgroundImageUrl = image == null ? null : mediaFileUrlRetriever.Retrieve(image).RelativePath,
                ImgAltText = properties.ImgAltText,
                Title = properties.Title
            });
        }
    }
}
