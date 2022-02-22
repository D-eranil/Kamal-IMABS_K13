using CMS.DocumentEngine.Types.IMABS;
using IMABS.Models.Brands;
using IMABS.Models.ServiceTemplateTitles;
using IMABS.Repositories;
using Kentico.Content.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IMABS.Models.Service
{
    public class ServiceViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string RedirectionUrl { get; set; }
        public string ImageUrl { get; set; }
        public string DesktopBanner { get; set; }
        public string TabletBanner { get; set; }
        public string MobileBanner { get; set; }

        public string ServicePanelText { get; set; }

        //contact us section
        public string Link1Text { get; set; }
        public string Link1Url { get; set; }
        public string Link2Text { get; set; }
        public string Link2Url { get; set; }
        public string ArrowImage { get; set; }

        public int NodeOrder { get; set; }
        public ServiceTemplateTitleViewModel ServiceTemplateTitles { get; set; }
        public List<BrandViewModel> brands { get; set; }
        public List<ServicePanelViewModel> topFourServicePanels { get; set; }
        public List<ServicePanelViewModel> servicePanels { get; set; }
        public List<ServiceViewModel> services { get; set; }

        public static ServiceViewModel GetViewModel(Services services)
        {
            var model = GetModel(services);
            return model;
        }

        public static ServiceViewModel GetPageViewModel(Services services)
        {
            var model = GetModel(services);

            //Service Template Titles
            //IGenericRepository<ServiceTemplateTitle> mServiceTitleRepository = new KenticoGenericRepository<ServiceTemplateTitle>(services.DocumentCulture, true);
            var titles = ServiceTemplateTitleViewModel.GetViewModel(ServiceTitleRepository.GetPage());


            // Get the NodeGuids of Children page type saved against the Parent page type for brands.
            var childrenGuids = services.Fields.Selector.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            
            //get brand list
            BrandRepository mBrandRepository = new BrandRepository();
            var brandList = mBrandRepository.GetPagesByGuid(childrenGuids).Select(BrandViewModel.GetViewModel).ToList();

            //get service list
            ServicesRepository mServicesRepository = new ServicesRepository();
            var serviceList = mServicesRepository.GetPages().Select(ServiceViewModel.GetViewModel).ToList();

            //get service panel list
            ServicePanelRepository mServicePanelRepository = new ServicePanelRepository();
            var servicePanelList = mServicePanelRepository.GetChildPagesByAlias(services.NodeAliasPath).Select(ServicePanelViewModel.GetViewModel).ToList();
            

            model.ServiceTemplateTitles = titles;

            model.brands = brandList;
            model.DesktopBanner = services.Fields.DesktopBanner?.GetPath();
            model.MobileBanner = services.Fields.MobileBanner?.GetPath();
            model.TabletBanner = services.Fields.TabletBanner?.GetPath();

            model.ArrowImage = services.Fields.ArrowImage?.GetPath();
            model.Link1Text = services.Fields.Link1Text;
            model.Link1Url = services.Fields.Link1Url;
            model.Link2Text = services.Fields.Link2Text;
            model.Link2Url = services.Fields.Link2Url;

            model.ServicePanelText = services.Fields.ServicePanelText;

            model.services = serviceList;
            model.topFourServicePanels = servicePanelList.Take(4).ToList();
            model.servicePanels = servicePanelList.Skip(4).ToList();
            return model;
        }

        private static ServiceViewModel GetModel(Services services)
        {
            return services == null ? null : new ServiceViewModel
            {
                Name = services.Fields.Name,
                RedirectionUrl = services.NodeAliasPath,
                ImageUrl = services.Fields.Image?.GetPath(),
                Description = services.Fields.Description,
                NodeOrder = services.NodeOrder
            };
        }
    }
}
