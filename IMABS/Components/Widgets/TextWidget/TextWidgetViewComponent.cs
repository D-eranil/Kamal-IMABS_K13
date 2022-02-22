using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace IMABS.Components.Widgets.TextWidget
{
    public class TextWidgetViewComponent:ViewComponent
    {
        // GET: TextWidget
        public ViewViewComponentResult Invoke(TextWidgetProperties properties)
        {
            //var image = GetImage(properties);

            return View("~/Components/Widgets/TextWidget/_TextWidget.cshtml", new TextWidgetViewModel
            {
                Text = properties.Text
            });
        }
    }
}
