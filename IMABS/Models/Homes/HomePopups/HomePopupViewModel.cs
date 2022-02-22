using CMS.DocumentEngine.Types.IMABS;
using Kentico.Content.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMABS.Models.Homes.HomePopups
{
    public class HomePopupViewModel
    {
        public string Name { get; set; }
        public string Heading { get; set; }
        public string Image { get; set; }
        public string SiteLink { get; set; }
        public string SiteLinkText { get; set; }
        public string FindoutMoreLink { get; set; }
        public string FindoutMoreLinkText { get; set; }

        public static HomePopupViewModel GetViewModel(HomePopup homePopup)
        {
            var model = homePopup == null ? new HomePopupViewModel() : new HomePopupViewModel
            {
                Name = homePopup.Fields.Name,
                Heading = homePopup.Fields.Heading,
                Image = homePopup.Fields.Image.GetPath(),
                SiteLink = homePopup.Fields.SiteLink,
                SiteLinkText = homePopup.Fields.SiteLinkText,
                FindoutMoreLink = homePopup.Fields.FindoutMoreLink,
                FindoutMoreLinkText = homePopup.Fields.FindoutMoreLinkText
            };

            return model;
        }
    }
}
