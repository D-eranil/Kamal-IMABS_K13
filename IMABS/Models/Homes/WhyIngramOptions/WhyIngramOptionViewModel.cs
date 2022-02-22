using CMS.DocumentEngine.Types.IMABS;
using IMABS.Models.Homes.ActionLinks;
using IMABS.Repositories;
using Kentico.Content.Web.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace IMABS.Models.Homes.WhyIngramOptions
{
    public class WhyIngramOptionViewModel
    {
        public string ImageHeading { get; set; }
        public string NavigationLink { get; set; }
        public string NavigationLinkId { get; set; }
        public string BackgroundImage { get; set; }
        public List<ActionLinkViewModel> ActionLinks { get; set; }

        public static WhyIngramOptionViewModel GetViewModel(WhyIngramOption whyIngramOption)
        {
            HomeRepository mhomeRepository = new HomeRepository();

            return whyIngramOption == null ? null : new WhyIngramOptionViewModel
            {
                ImageHeading = whyIngramOption.Fields.ImageHeading,
                NavigationLink = whyIngramOption.Fields.NavigationLink,
                NavigationLinkId = whyIngramOption.Fields.NavigationLinkId,
                BackgroundImage = whyIngramOption.Fields.BackgroundImage.GetPath(),
                ActionLinks = mhomeRepository.GetActionLinks(whyIngramOption.NodeGUID.ToString()).Select(ActionLinkViewModel.GetViewModel).OrderByDescending(x => x.NodeOrder).ToList()
            };
        }
    }
}
