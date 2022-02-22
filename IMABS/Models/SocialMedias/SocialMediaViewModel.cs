using CMS.DocumentEngine.Types.IMABS;
using Kentico.Content.Web.Mvc;

namespace IMABS.Models.SocialMedias
{
	public class SocialMediaViewModel
    {
        public string SocialMediaPlatform { get; set; }
        public string SocialMediaURL { get; set; }
        public string SocialMediaLogo { get; set; }
		public string SocialMediaClass { get; set; }

		public static SocialMediaViewModel GetViewModel(SocialMedia socialMedia)
        {
            return socialMedia == null ? null : new SocialMediaViewModel
            {
                SocialMediaPlatform = socialMedia.Fields.Platform,
                SocialMediaLogo = socialMedia.Fields.Logo.GetPath(),
                SocialMediaURL = socialMedia.Fields.URL,
                SocialMediaClass=socialMedia.Fields.Class
            };
        }
    }
}
