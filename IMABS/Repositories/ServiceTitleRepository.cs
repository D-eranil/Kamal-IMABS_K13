using CMS.DocumentEngine.Types.IMABS;

namespace IMABS.Repositories
{
    public class ServiceTitleRepository
    {
        public static ServiceTemplateTitle GetPage()
        {
            return ServiceTemplateTitleProvider.GetServiceTemplateTitles();
        }
    }
}
