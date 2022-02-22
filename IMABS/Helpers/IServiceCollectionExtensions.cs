using IMABS.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace IMABS.Helpers
{
    public static class IServiceCollectionExtensions
    {
        public static void AddMyServices(this IServiceCollection services)
        {
            AddViewComponentServices(services);
            AddRepositories(services);

            //services.AddSingleton<IGenericRepository<TreeNode>, GenericRepository<TreeNode>>();
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddSingleton<HomeRepository>();
            services.AddSingleton<HeaderRepository>();
            services.AddSingleton<BreadcrumbHelperRepository>();
            services.AddSingleton<BreadcrumbRepository>();
            services.AddSingleton<BannersRepository>();
            services.AddSingleton<RepositoryCacheHelper>();
            services.AddSingleton<MediaFileRepository>();
            services.AddSingleton<LandingPageRepository>();
            services.AddSingleton<BrandRepository>();
            services.AddSingleton<ServicePanelRepository>();
            services.AddSingleton<ServicesRepository>();
            services.AddSingleton<ServiceTitleRepository>();
            services.AddSingleton<PrivacyRepository>();
            services.AddSingleton<CategoryIndexRepository>();
            services.AddSingleton<ContactUsRepository>();
            services.AddSingleton<CareersRepository>();
            services.AddSingleton<SocialMediaRepository>();
            services.AddSingleton<TabsRepository>();
        }

        private static void AddViewComponentServices(IServiceCollection services)
        {
            //services.AddSingleton<IGenericService, GenericService>();
            //services.AddSingleton<IKenticoService, KenticoService>();
        }

    }
}
