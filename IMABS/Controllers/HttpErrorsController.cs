using CMS.DocumentEngine.Types.IMABS;
using IMABS.Controllers;
using IMABS.Models.LandingPages;
using IMABS.Models.Service;
using IMABS.Repositories;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Kentico.PageBuilder.Web.Mvc;
using Kentico.Web.Mvc;


namespace IMABS.Controllers
{
	public class HttpErrorsController : Controller
	{
        private readonly IPageDataContextRetriever pageDataContextRetriever;
        private readonly HomeRepository homeRepository;
        private readonly IPageDataContextInitializer pageDataContextInitializer;

        public HttpErrorsController(IPageDataContextRetriever _pageDataContextRetriever,
            HomeRepository _homeRepository,
            IPageDataContextInitializer _pageDataContextInitializer)
        {
            pageDataContextRetriever = _pageDataContextRetriever;
            this.homeRepository = _homeRepository;
            pageDataContextInitializer = _pageDataContextInitializer;
        }


        // GET: HttpErrors
        public async Task<ActionResult> NotFound(string NodeAliasPath) 
        {
            var page = HomeProvider.GetHomes().FirstOrDefault();
            if (page == null)
            {
                return null;
            }
            pageDataContextInitializer.Initialize(page);

            return View();
        }
    }
}
