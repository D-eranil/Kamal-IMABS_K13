using CMS.DocumentEngine.Types.IMABS;

namespace IMABS.Models.ServiceTemplateTitles
{
    public class ServiceTemplateTitleViewModel
    {
        public string ServicePanelTitle { get; set; }
        public string BrandTitle { get; set; }
        public string ContactUsTitle { get; set; }
        public string ServiceListTitle { get; set; }

        public static ServiceTemplateTitleViewModel GetViewModel(ServiceTemplateTitle serviceTemplateTitle)
        {
            var model = serviceTemplateTitle == null ? new ServiceTemplateTitleViewModel() : new ServiceTemplateTitleViewModel
            {
                BrandTitle = serviceTemplateTitle.Fields.BrandTitle,
                ContactUsTitle = serviceTemplateTitle.Fields.ContactUsTitle,
                ServicePanelTitle = serviceTemplateTitle.Fields.ServicePanelTitle,
                ServiceListTitle = serviceTemplateTitle.Fields.ServiceListTitle
            };

            return model;
        }
    }
}
