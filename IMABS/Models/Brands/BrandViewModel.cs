using CMS.DocumentEngine.Types.IMABS;
using Kentico.Content.Web.Mvc;

namespace IMABS.Models.Brands
{
    public class BrandViewModel
    {
        public string Name { get; set; }
        public string RedirectionUrl { get; set; }
        public string ImageUrl { get; set; }
        public string AltText { get; set; }

        public static BrandViewModel GetViewModel(Brand brand)
        {
            return brand == null ? null : new BrandViewModel
            {
                Name = brand.Fields.Name,
                ImageUrl = brand.Fields.Image.GetPath(),
                RedirectionUrl = brand.Fields.RedirectionUrl,
                AltText = brand.Fields.Name
            };
        }
    }
}
