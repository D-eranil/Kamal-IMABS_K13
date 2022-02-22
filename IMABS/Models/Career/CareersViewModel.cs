using CMS.DocumentEngine.Types.IMABS;
using IMABS.Models.SocialMedias;
using IMABS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;


namespace IMABS.Models.Career
{
	public class CareersViewModel
	{
		public string Title { get; set; }
        public string FindUsTitle { get; set; }
        public string FollowUsTitle { get; set; }
        public List<OpeningsViewModel> openings { get; set; }
		public List<SocialMediaViewModel> socialMedia { get; set; }


        private static CareersViewModel GetModel(Careers careers)
        {
            return careers == null ? null : new CareersViewModel
            {
                Title = careers.Fields.CareerTitle,
                FindUsTitle=careers.Fields.FindUsTitle,
                FollowUsTitle=careers.Fields.FollowUsTitle
            };
        }

        public static CareersViewModel GetPageViewModel(Careers careers)
        {
            var model = GetModel(careers);

            //get openings list
            CareersRepository mCareersRepository = new CareersRepository();
            var openingsList = mCareersRepository.GetOpenings().Select(OpeningsViewModel.GetViewModel).ToList();

            // Get the NodeGuids of Children page type saved against the Parent page type for social media.
            var childrenGuids = careers.Fields.SocialMediaSelector.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            //get socialmedia list
            SocialMediaRepository mSocialMediaRepository = new SocialMediaRepository();
            var socialMediaList = mSocialMediaRepository.GetPagesByGuid(childrenGuids).Select(SocialMediaViewModel.GetViewModel).ToList();

            
            model.openings = openingsList;
            model.socialMedia = socialMediaList;
            return model;
        }

    }

    
}
