using CMS.DocumentEngine.Types.IMABS;

namespace IMABS.Models.ProductCategories.ProductCategoryTemplateTitles
{
    public class ProductCategoryTemplateTitleViewModel
    {
        public string Name { get; set; }
        public string MainTitle { get; set; }
        public string SubCategoryTitle { get; set; }
        public string BrandTitle { get; set; }
        public string ResourceTitle { get; set; }
        public string ResourceDescription { get; set; }
        public string PopupTitle { get; set; }
        public string PopupTNCText { get; set; }
        public string TNCLinkText { get; set; }
        public string TNCLinkUrl { get; set; }

        public static ProductCategoryTemplateTitleViewModel GetViewModel(ProductCategoryTemplateTitle productCategoryTemplateTitle)
        {
            return productCategoryTemplateTitle == null ? null : new ProductCategoryTemplateTitleViewModel
            {
                BrandTitle = productCategoryTemplateTitle.Fields.BrandTitle,
                MainTitle = productCategoryTemplateTitle.Fields.MainTitle,
                Name = productCategoryTemplateTitle.Fields.Name,
                PopupTitle = productCategoryTemplateTitle.Fields.PopupTitle,
                PopupTNCText = productCategoryTemplateTitle.Fields.PopupTNCText,
                ResourceDescription = productCategoryTemplateTitle.Fields.ResourceDescription,
                ResourceTitle = productCategoryTemplateTitle.Fields.ResourceTitle,
                SubCategoryTitle = productCategoryTemplateTitle.Fields.SubCategoryTitle,
                TNCLinkText = productCategoryTemplateTitle.Fields.TNCLinkText,
                TNCLinkUrl = productCategoryTemplateTitle.Fields.TNCLinkUrl
            };
        }


        public static ProductCategoryTemplateTitleViewModel GetViewModel(CategoryIndex categoryIndex)
        {
            return categoryIndex == null ? null : new ProductCategoryTemplateTitleViewModel
            {
                BrandTitle = categoryIndex.Fields.BrandTitle,
                MainTitle = categoryIndex.Fields.MainTitle,
                Name = categoryIndex.Fields.Name,
                PopupTitle = categoryIndex.Fields.PopupTitle,
                ResourceDescription = categoryIndex.Fields.ResourceDescription,
                ResourceTitle = categoryIndex.Fields.ResourceTitle,
                SubCategoryTitle = categoryIndex.Fields.SubCategoryTitle
            };
        }
    }
}
