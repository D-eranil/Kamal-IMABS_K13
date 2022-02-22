using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace IMABS.Components.Widgets.CTAButton
{
    public class CTAButtonWidgetViewComponent : ViewComponent
    {

        // GET: CTAButtonWidget
        public ViewViewComponentResult Invoke(CTAButtonWidgetProperties properties)
        {
            //var image = GetImage(properties);

            return View("~/Components/Widgets/CTAButton/_CTAButtonWidget.cshtml", new CTAButtonWidgetViewModel
            {
                CTAAlign=properties.CTAAlign,
                CTAText = properties.LinkText,
                CTACSSClass = properties.LinkCSSClass,
                CTAURL = properties.LinkURL,
                CTATarget = properties.LinkTarget
            });
        }
    }
}
