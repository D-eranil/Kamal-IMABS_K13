using CMS.DocumentEngine.Types.IMABS;

namespace IMABS.Models.ProductCategories.ProductSubCategories
{
    public class ProductSubCategoryViewModel
    {
        public string Name { get; set; }

        public static ProductSubCategoryViewModel GetViewModel(ProductSubCategory productSubCategory)
        {
            return productSubCategory == null ? null : new ProductSubCategoryViewModel
            {
                Name = productSubCategory.Fields.Name
            };
        }
    }
}
