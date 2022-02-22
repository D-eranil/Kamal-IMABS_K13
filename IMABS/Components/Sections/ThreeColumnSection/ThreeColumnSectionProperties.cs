using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;

namespace IMABS.Components.Sections.ThreeColumnSection
{
    public class ThreeColumnSectionProperties : ISectionProperties
    {
        /// <summary>
        /// Title of the section.
        /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "Title", Order = 1)]
        public string Title { get; set; }
    }
}