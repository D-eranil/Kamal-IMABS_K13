using CMS.DocumentEngine.Types.IMABS;

namespace IMABS.Models.ContactUs
{
	public class ContactUsSectionViewModel
	{
        public string SectionName { get; set; }
        public string ShortDescription { get; set; }
        public string SectionDetail { get; set; }
        public string SectionBackground { get; set; }

        public static ContactUsSectionViewModel GetViewModel(ContactUsSection contactUsSection)
        {
            return contactUsSection == null ? null : new ContactUsSectionViewModel
            {
                SectionName = contactUsSection.Fields.SectionName,
                ShortDescription = contactUsSection.Fields.ShortDescription,
                SectionDetail = contactUsSection.Fields.SectionDetail,
                SectionBackground = contactUsSection.Fields.SectionBackground
            };
        }
    }
}
