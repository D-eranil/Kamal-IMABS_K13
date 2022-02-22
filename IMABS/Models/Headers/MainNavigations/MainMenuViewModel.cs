using CMS.DocumentEngine.Types.IMABS;
using IMABS.Models.Headers.SubNavigations;
using IMABS.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace IMABS.Models.Headers.MainNavigations
{
    public class MainMenuViewModel
    {
        public string MenuItemName { get; set; }
        public bool AllowToViewInFooter { get; set; }
        public bool AllowToViewInHeader { get; set; }
        public bool HasChildren { get; set; }
        public string NodeAliasPath { get; set; }
        public List<SubMenuViewModel> subMenu { get; set; }

        public static MainMenuViewModel GetViewModel(LandingPage landingPage)
        {
            List<SubMenuViewModel> subMenus = new List<SubMenuViewModel>();
            HeaderRepository mHeaderRepository = new HeaderRepository();

            subMenus = mHeaderRepository.GetSubMenuList(landingPage.NodeGUID.ToString()).Select(SubMenuViewModel.GetViewModel).Where(x => x.AllowToViewInHeader).ToList();

            return landingPage == null ? null : new MainMenuViewModel
            {
                MenuItemName = landingPage.Fields.Name,
                AllowToViewInFooter = landingPage.Fields.AllowToViewInFooter,
                AllowToViewInHeader = landingPage.Fields.AllowToViewInHeader,
                HasChildren = landingPage.NodeHasChildren,
                subMenu = subMenus,
                NodeAliasPath = (subMenus != null && subMenus.Count > 0) ? "#" : landingPage.NodeAliasPath
                //mHeaderRepository.GetSubAboutMenus(landingPage.NodeGUID.ToString()).Select(SubMenuViewModel.GetViewModel).ToList()
            };
        }

        public static MainMenuViewModel GetFooterViewModel(LandingPage landingPage)
        {
            HeaderRepository mHeaderRepository = new HeaderRepository();


            List<SubMenuViewModel> subMenus = new List<SubMenuViewModel>();
            
            subMenus = mHeaderRepository.GetSubMenuList(landingPage.NodeGUID.ToString()).Select(SubMenuViewModel.GetFooterViewModel).Where(x => x.AllowToViewInFooter).ToList();



            return landingPage == null ? null : new MainMenuViewModel
            {
                MenuItemName = landingPage.Fields.Name,
                AllowToViewInFooter = landingPage.Fields.AllowToViewInFooter,
                AllowToViewInHeader = landingPage.Fields.AllowToViewInHeader,
                HasChildren = landingPage.NodeHasChildren,
                subMenu = subMenus
                //mHeaderRepository.GetFooterSubMenus(landingPage.NodeGUID.ToString()).Select(SubMenuViewModel.GetViewModel).ToList()
            };
        }
    }
}