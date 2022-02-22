using CMS.DocumentEngine.Types.IMABS;
using IMABS.Models.Brands;
using IMABS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IMABS.Models.FeatureTemplates
{
    public class FeatureTemplateViewModel : CommonSettingsViewModel
    {
        public string ParentPageName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PageContent { get; set; }
        public string Blockquote { get; set; }
        public string BrandTitle { get; set; }
        public string Selector { get; set; }
        public string DocumentDate { get; set; }
        public string FeatureBy { get; set; }
        public List<BrandViewModel> brands { get; set; }

        public static FeatureTemplateViewModel GetViewModel(FeatureTemplate featureTemplate)
        {
            var model = featureTemplate == null ? null : new FeatureTemplateViewModel()
            {
                Name = featureTemplate.Fields.Name,
                Description = featureTemplate.Fields.Description,
                PageContent = featureTemplate.Fields.PageContent,
                Blockquote = featureTemplate.Fields.Blockquote,
                Selector = featureTemplate.Fields.Selector,
                AllowToViewInFooter = featureTemplate.Fields.AllowToViewInFooter,
                AllowToViewInHeader = featureTemplate.Fields.AllowToViewInHeader,
                EnableBreadcrumb = featureTemplate.Fields.EnableBreadcrumb,
                EnableCallToTactionBanner = featureTemplate.Fields.EnableCallToTactionBanner,
                EnablePromotionsBanner = featureTemplate.Fields.EnablePromotionsBanner,
                FeatureBy = featureTemplate.Fields.FeatureBy,
                DocumentDate = featureTemplate.DocumentCreatedWhen.ToString("MMMM dd, yyyy"),
                BrandTitle = featureTemplate.Fields.BrandTitle
            };


            // Get the NodeGuids of Children page type saved against the Parent page type for brands.
            var childrenGuids = featureTemplate.Fields.Selector.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            model.ParentPageName = featureTemplate.Parent.DocumentName;
            //get brand list
            BrandRepository mBrandRepository = new BrandRepository();
            model.brands = mBrandRepository.GetPagesByGuid(childrenGuids).Select(BrandViewModel.GetViewModel).ToList();

            return model;
        }
    }
}
