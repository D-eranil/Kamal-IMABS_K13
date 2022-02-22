using CMS.DocumentEngine.Types.IMABS;
using IMABS.Models.Brands;
using IMABS.Models.ProductCategories.ProductCategoryTemplateTitles;
using IMABS.Models.ProductCategories.ProductSubCategories;
using IMABS.Models.ResourceLinks;
using IMABS.Repositories;
using Kentico.Content.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMABS.Models.ProductCategories.ProductCategoryDetails
{
    public class ProductCategoryDetailViewModel
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string RedirectionUrl { get; set; }
        public string ImageAltText { get; set; }
        public string ImageUrl { get; set; }
        public int NodeOrder { get; set; }
        public List<ProductSubCategoryViewModel> SubCategoryLst1 { get; set; }
        public List<ProductSubCategoryViewModel> SubCategoryLst2 { get; set; }
        public List<ProductSubCategoryViewModel> SubCategoryLst3 { get; set; }

        //public List<ActionLinkViewModel> pdfResources { get; set; }
        //public List<ActionLinkViewModel> videoResources { get; set; }
        //public List<ActionLinkViewModel> linkResources { get; set; }
        //public List<ActionLinkViewModel> toolResources { get; set; }

        public List<ResourceLinkViewModel> pdfResources { get; set; }
        public List<ResourceLinkViewModel> videoResources { get; set; }
        public List<ResourceLinkViewModel> linkResources { get; set; }
        public List<ResourceLinkViewModel> toolResources { get; set; }
        public List<BrandViewModel> brands { get; set; }
        //public List<FormComponent> FormComponents { get; set; }
        //public FormComponentViewModel formconfig { get; set; }
        public ProductCategoryTemplateTitleViewModel pageTitles { get; set; }

        public static ProductCategoryDetailViewModel GetViewModel(ProductCategoryDetail productCategoryDetail)
        {
            //List<ActionLinkViewModel> resourceList = new List<ActionLinkViewModel>();
            List<ResourceLinkViewModel> resourceList = new List<ResourceLinkViewModel>();

            List<ProductSubCategoryViewModel> SubCategoryList = new List<ProductSubCategoryViewModel>();

            CategoryIndexRepository mCategoryIndexRepository = new CategoryIndexRepository();

            SubCategoryList = mCategoryIndexRepository
                              //.GetProductSubCategoryDetails(productCategoryDetail.NodeGUID)
                              .GetProductSubCategoryDetails(productCategoryDetail.NodeAliasPath)
                              .Select(ProductSubCategoryViewModel.GetViewModel)
                              .ToList();

            //resourceList = mLandingPageRepository
            //             //.GetProductSubCategoryDetails(productCategoryDetail.NodeGUID)
            //             .GetResources(productCategoryDetail.NodeAliasPath)
            //             .Select(ActionLinkViewModel.GetViewModel)
            //             .ToList();
            //IGenericRepository<ResourceLink> mResourcePageRepository = new KenticoGenericRepository<ResourceLink>(productCategoryDetail.DocumentCulture, true);

            resourceList = mCategoryIndexRepository.GetResourceLinks(productCategoryDetail.NodeAliasPath).Select(ResourceLinkViewModel.GetViewModel).ToList();

            var brandsList = productCategoryDetail.Fields.Selector;

            // Get the NodeGuids of Children page type saved against the Parent page type.
            var childrenGuids = productCategoryDetail.Fields.Selector.Split(new[] { ';' }, System.StringSplitOptions.RemoveEmptyEntries).ToList();


            //get brand list
            BrandRepository mBrandRepository = new BrandRepository();

            var brandList = mBrandRepository.GetPagesByGuid(childrenGuids).Select(BrandViewModel.GetViewModel).ToList();


            ////get page titles with separate page types
            //IGenericRepository<ProductCategoryTemplateTitle> mPCTRepository = new KenticoGenericRepository<ProductCategoryTemplateTitle>(productCategoryDetail.DocumentCulture, true);
            //var pageTitles = mPCTRepository.GetPages().Select(ProductCategoryTemplateTitleViewModel.GetViewModel).FirstOrDefault();

            //get page titles with index page types
            var pageTitles = mCategoryIndexRepository.GetPages().Select(ProductCategoryTemplateTitleViewModel.GetViewModel).FirstOrDefault();


            return productCategoryDetail == null ? null : new ProductCategoryDetailViewModel
            {
                Name = productCategoryDetail.Fields.Name,
                Title = productCategoryDetail.Fields.Name,
                RedirectionUrl = (productCategoryDetail.Fields.RedirectionUrl == "#" || string.IsNullOrEmpty(productCategoryDetail.Fields.RedirectionUrl)) ? productCategoryDetail.NodeAliasPath : productCategoryDetail.Fields.RedirectionUrl,
                ImageUrl = productCategoryDetail.Fields.Image.GetPath(),
                ImageAltText = productCategoryDetail.Fields.ImageAltText,
                NodeOrder = productCategoryDetail.NodeOrder,
                SubCategoryLst1 = SubCategoryList.Take(4).ToList(),
                SubCategoryLst2 = SubCategoryList.Count > 4 ? SubCategoryList.Skip(4).Take(4).ToList() : null,
                SubCategoryLst3 = SubCategoryList.Count > 8 ? SubCategoryList.Skip(8).Take(4).ToList() : null,
                linkResources = resourceList.Where(x => x.Resource == "resource-link").ToList(),
                toolResources = resourceList.Where(x => x.Resource == "resource-tool").ToList(),
                pdfResources = resourceList.Where(x => x.Resource == "resource-pdf").ToList(),
                videoResources = resourceList.Where(x => x.Resource == "resource-video").ToList(),
                brands = brandList,
                pageTitles = pageTitles
            };
        }

        public static ProductCategoryDetailViewModel GetCategoryCardViewModel(ProductCategoryDetail productCategoryDetail)
        {
            return productCategoryDetail == null ? null : new ProductCategoryDetailViewModel
            {
                Name = productCategoryDetail.Fields.Name,
                Title = productCategoryDetail.Fields.Name,
                RedirectionUrl = (productCategoryDetail.Fields.RedirectionUrl == "#" || string.IsNullOrEmpty(productCategoryDetail.Fields.RedirectionUrl)) ? productCategoryDetail.NodeAliasPath : productCategoryDetail.Fields.RedirectionUrl,
                ImageUrl = productCategoryDetail.Fields.Image.GetPath(),
                ImageAltText = productCategoryDetail.Fields.ImageAltText,
                NodeOrder = productCategoryDetail.NodeOrder
            };
        }
    }
}


