using CMS.DocumentEngine.Types.IMABS;
using IMABS.Controllers;
using IMABS.Models.BlockquoteContents;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;

[assembly: RegisterPageRoute(BlockquoteContent.CLASS_NAME, typeof(BlockquoteContentController))]
namespace IMABS.Controllers
{
    public class BlockquoteContentController : Controller
    {
        private readonly IPageDataContextRetriever dataRetriever;
        private readonly IPageDataContextInitializer pageDataContextInitializer;

        public BlockquoteContentController(IPageDataContextRetriever dataRetriever,
            IPageDataContextInitializer _pageDataContextInitializer)
        {
            this.dataRetriever = dataRetriever;
            pageDataContextInitializer = _pageDataContextInitializer;
        }


        public IActionResult Index()
        {
            var bqc = dataRetriever.Retrieve<BlockquoteContent>().Page;
            if (bqc == null)
            {
                return null;
            }
            pageDataContextInitializer.Initialize(bqc);

            //view model code
            var model = BlockquoteContentViewModel.GetViewModel(bqc);

            ViewBag.EnableCallToTactionBanner = bqc.Fields.EnableCallToTactionBanner;
            ViewBag.EnableBreadcrumb = bqc.Fields.EnableBreadcrumb;
            ViewBag.PageCTABanner = bqc.Fields.CTABanner;
            ViewBag.IsWhyIngramPage = false;
            if (bqc.PageName.ToLower().Contains("why ingram micro"))
            {
                ViewBag.IsWhyIngramPage = true;
            }
            

            return View(model);
        }
    }
}
