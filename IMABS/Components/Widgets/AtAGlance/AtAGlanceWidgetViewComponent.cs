using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMABS.Components.Widgets.AtAGlance
{
    public class AtAGlanceWidgetViewComponent : ViewComponent
    {

        // GET: FeatureWidget
        public ViewViewComponentResult Invoke(AtAGlanceWidgetProperties properties)
        {

            return View("~/Components/Widgets/AtAGlance/_AtAGlanceWidget.cshtml", new AtAGlanceViewModel
            {
                IconClass = properties.IconClass,
                Title = properties.Title,
                Stats = properties.Stats
            });
        }
    }
}
