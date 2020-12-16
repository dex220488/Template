using Microsoft.AspNetCore.Mvc;
using Template.SmartAdmin.Models;

namespace Template.SmartAdmin.ViewComponents
{
    public class NavigationViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            NavigationModel.RoutePathBase = HttpContext.Request.PathBase;
            var items = NavigationModel.Full;
            return View(items);
        }
    }
}