using CMS.DocumentEngine.Types.IMABS;
using IMABS.Controllers;
using IMABS.Models.ProductCategories;
using IMABS.Models.ProductCategories.ProductCategoryDetails;
using IMABS.Repositories;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

[assembly: RegisterPageRoute(CategoryIndex.CLASS_NAME, typeof(ProductCategoriesController))]
namespace IMABS.Controllers
{
    public class ProductCategoriesController : Controller
    {
        private readonly IPageDataContextRetriever dataRetriever;
        //private readonly ServicesRepository mServicesRepository;
        private readonly IPageDataContextInitializer pageDataContextInitializer;

        public ProductCategoriesController(IPageDataContextRetriever dataRetriever,
        //ServicesRepository servicesRepository,
        IPageDataContextInitializer _pageDataContextInitializer)
        {
            this.dataRetriever = dataRetriever;
            //mServicesRepository = servicesRepository;
            pageDataContextInitializer = _pageDataContextInitializer;
        }
        public IActionResult Index()
        {
            var categoryPG = dataRetriever.Retrieve<CategoryIndex>().Page;
            if (categoryPG == null)
            {
                return null;
            }
            pageDataContextInitializer.Initialize(categoryPG);
            //PageTypes / IMABS_ProductCategoryDetail
            CategoryIndexRepository mCategoryIndexRepository = new CategoryIndexRepository();
            //view model code
            var model = new ProductCategoryViewModel
            {
                productCategoryDetails = mCategoryIndexRepository.GetProductCategoryDetailPages().Select(ProductCategoryDetailViewModel.GetCategoryCardViewModel).ToList()
            };

            ViewBag.EnableCallToTactionBanner = categoryPG.Fields.EnableCallToTactionBanner;
            ViewBag.EnablePromotionsBanner = categoryPG.Fields.EnablePromotionsBanner;
            ViewBag.EnableBreadcrumb = categoryPG.Fields.EnableBreadcrumb;

            return View(model);
        }
    }
}
