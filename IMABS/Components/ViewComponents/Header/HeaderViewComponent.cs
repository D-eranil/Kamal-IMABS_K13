using IMABS.Models.Headers;
using IMABS.Models.Headers.MainNavigations;
using IMABS.Models.Headers.TopNavigations;
using IMABS.Repositories;
using Kentico.Content.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMABS.Components.ViewComponents.Header
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly HeaderRepository headerRepository;
        public HeaderViewComponent(HeaderRepository _headerRepository)
        {
            this.headerRepository = _headerRepository;
        }
        public IViewComponentResult Invoke()
        {
            var header = headerRepository.GetHeaderPage();

            var viewModel = new HeaderViewModel
            {
                TopMenus = headerRepository.GetTopManus().Select(TopMenuViewModel.GetViewModel).ToList(),
                HeaderLogoUrl = header.Fields.Logo.GetPath(),
                HeaderLogoMobileUrl = header.Fields.MobileHeaderLogo.GetPath(),
                MainMenuDtos = headerRepository.GetMainNavMenus().Select(MainMenuViewModel.GetViewModel).ToList(),
                MainMenuCTAButtonLink = header.Fields.CTAButtonLink,
                MainMenuCTAButtonText = header.Fields.CTAButtonText
            };

            return View("~/Components/ViewComponents/Header/Default.cshtml", viewModel);
        }
    }
}
