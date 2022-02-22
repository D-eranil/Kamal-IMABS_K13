using CMS.MediaLibrary;

namespace IMABS.Components.Widgets.HeaderBannerWidget
{
	public class HeaderBannerWidgetViewModel
	{
		public string Background { get; set; }
		public string Title { get; set; }
		public string SubTitle { get; set; }
		public string Description { get; set; }
		public MediaFileInfo MobileImage { get; set; }
		public MediaFileInfo TabletImage { get; set; }
		public MediaFileInfo DesktopImage { get; set; }
	}
}
