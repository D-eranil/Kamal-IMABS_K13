using Kentico.PageBuilder.Web.Mvc;

namespace IMABS.Components.Widgets.TextWidget
{
    /// <summary>
    /// Properties for Text widget.
    /// </summary>
    public class TextWidgetProperties : IWidgetProperties
    {
        /// <summary>
        /// HTML formatted text.
        /// </summary>
        public string Text { get; set; }
    }
}
