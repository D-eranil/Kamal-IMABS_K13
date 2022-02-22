using CMS.DocumentEngine.Types.IMABS;

namespace IMABS.Models.Privacies
{
    public class PrivacyViewModel
	{
		public string Name { get; set; }
		public string Heading { get; set; }
		public string Content { get; set; }

		public static PrivacyViewModel GetViewModel(Privacy privacy)
		{
			var privacyModel = privacy == null ? new PrivacyViewModel() : new PrivacyViewModel
			{
				Name = privacy.Fields.Name,
				Heading = privacy.Fields.Heading,
				Content = privacy.Fields.Content
			};

			return privacyModel;
		}
	}
}
