using CMS.DocumentEngine.Types.IMABS;
using IMABS.Controllers;
using IMABS.Models.HelpItemTemplates;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;
[assembly: RegisterPageRoute(HelpItemTemplate.CLASS_NAME, typeof(HelpItemTemplateController))]

namespace IMABS.Controllers
{
    public class HelpItemTemplateController : Controller
    {
        private readonly IPageDataContextRetriever dataRetriever;
        private readonly IPageDataContextInitializer pageDataContextInitializer;

        public HelpItemTemplateController(IPageDataContextRetriever dataRetriever,
            IPageDataContextInitializer _pageDataContextInitializer)
        {
            this.dataRetriever = dataRetriever;
            pageDataContextInitializer = _pageDataContextInitializer;
        }

        public IActionResult Index()
        {
            var ls = dataRetriever.Retrieve<HelpItemTemplate>().Page;
            if (ls == null)
            {
                return null;
            }
            pageDataContextInitializer.Initialize(ls);

            var param = Request.QueryString.ToString().Split('=');
            int nodeId = 0;
            int.TryParse(param[1], out nodeId);

            //view model code
            var model = HelpItemTemplateViewModel.GetViewModel(ls, nodeId);
            //model.Tabs = new List<Models.Tab.TabsViewModel>();

            ViewBag.EnableCallToTactionBanner = ls.Fields.EnableCallToTactionBanner;
            ViewBag.EnableBreadcrumb = ls.Fields.EnableBreadcrumb;

            return View(model);
        }
    }
}
