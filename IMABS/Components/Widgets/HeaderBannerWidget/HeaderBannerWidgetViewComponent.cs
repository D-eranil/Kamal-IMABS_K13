using CMS.MediaLibrary;
using CMS.SiteProvider;
using IMABS.Repositories;
using Kentico.Components.Web.Mvc.FormComponents;
using Kentico.Content.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IMABS.Components.Widgets.HeaderBannerWidget
{
	public class HeaderBannerWidgetViewComponent : ViewComponent
    {
        private readonly MediaFileRepository mediaFileRepository;
        private readonly IMediaFileUrlRetriever mediaFileUrlRetriever;


        /// <summary>
        /// Creates an instance of <see cref="HeaderBannerWidgetViewComponent"/> class.
        /// </summary>
        /// <param name="mediaFileRepository">Repository for media files.</param>
        /// <param name="mediaFileUrlRetriever">The media file URL retriever.</param>
        public HeaderBannerWidgetViewComponent(MediaFileRepository mediaFileRepository, IMediaFileUrlRetriever mediaFileUrlRetriever)
        {
            this.mediaFileRepository = mediaFileRepository;
            this.mediaFileUrlRetriever = mediaFileUrlRetriever;
        }

        private MediaFileInfo GetImage(IList<MediaFilesSelectorItem> images)
        {
            if (images!= null)
            {
                var imageGuid = images.FirstOrDefault()?.FileGuid ?? Guid.Empty;
                if (imageGuid == Guid.Empty)
                {
                    return null;
                }

                return mediaFileRepository.GetMediaFile(imageGuid, SiteContext.CurrentSiteID);
            }
            else
            {
                return null;
            }
        }


        // GET: HeaderBannerWidget
        public ViewViewComponentResult Invoke(HeaderBannerWidgetProperties properties)
        {
            var mobileImage= GetImage(properties.MobileImage);
            var tabletImage = GetImage(properties.TabletImage);
            var desktopImage = GetImage(properties.DesktopImage);

            return View("~/Components/Widgets/HeaderBannerWidget/_HeaderBannerWidget.cshtml", new HeaderBannerWidgetViewModel
            {
                Background = properties.Background,
                MobileImage = mobileImage,
                TabletImage = tabletImage,
                DesktopImage = desktopImage,
                Title = properties.Title,
                SubTitle = properties.SubTitle,
                Description = properties.Description
            });
        }
    }
}
