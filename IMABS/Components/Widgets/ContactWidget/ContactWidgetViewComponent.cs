using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMABS.Components.Widgets.ContactWidget
{
	public class ContactWidgetViewComponent : ViewComponent
    {
        // GET: Contact Widget
        public ViewViewComponentResult Invoke(ContactWidgetProperties properties)
        {
            return View("~/Components/Widgets/ContactWidget/_ContactWidget.cshtml", new ContactWidgetViewModel
            {
                Text = properties.Text,
                Background=properties.Background
            });
        }
    }
}
