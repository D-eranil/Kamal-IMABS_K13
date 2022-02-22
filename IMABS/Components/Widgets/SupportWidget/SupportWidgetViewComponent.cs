using CMS.MediaLibrary;
using CMS.SiteProvider;
using IMABS.Repositories;
using Kentico.Content.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Linq;

namespace IMABS.Components.Widgets.SupportWidget
{
	public class SupportWidgetViewComponent : ViewComponent
	{
        private readonly MediaFileRepository mediaFileRepository;
        private readonly IMediaFileUrlRetriever mediaFileUrlRetriever;


        /// <summary>
        /// Creates an instance of <see cref="SupportWidgetViewComponent"/> class.
        /// </summary>
        /// <param name="mediaFileRepository">Repository for media files.</param>
        /// <param name="mediaFileUrlRetriever">The media file URL retriever.</param>
        public SupportWidgetViewComponent(MediaFileRepository mediaFileRepository, IMediaFileUrlRetriever mediaFileUrlRetriever)
        {
            this.mediaFileRepository = mediaFileRepository;
            this.mediaFileUrlRetriever = mediaFileUrlRetriever;
        }

        private MediaFileInfo GetImage(SupportWidgetProperties properties)
        {
            if (properties.Image != null)
            {
                var imageGuid = properties.Image.FirstOrDefault()?.FileGuid ?? Guid.Empty;
                if (imageGuid == Guid.Empty)
                {
                    return null;
                }

                return mediaFileRepository.GetMediaFile(imageGuid, SiteContext.CurrentSiteID);
            }
            else { 
                return null;
            }
        }


        // GET: SupportWidget
        public ViewViewComponentResult Invoke(SupportWidgetProperties properties)
        {
			var image = GetImage(properties);
			var imag = $"/getattachment/" + properties.Image?.FirstOrDefault().FileGuid + "/attachment.aspx";
            return View("~/Components/Widgets/SupportWidget/_SupportWidget.cshtml", new SupportWidgetViewModel
            {
                ImageUrl = $"/getattachment/" + properties.Image?.FirstOrDefault().FileGuid + "/attachment.aspx", //image == null ? null : mediaFileUrlRetriever.Retrieve(image).RelativePath,
                Title = properties.Title,
                Description = properties.Description,
                EmailId =properties.EmailId,
                IconClass=properties.IconClass,
                RedirectionUrl=properties.RedirectionUrl 
            });
        }
    }
}
