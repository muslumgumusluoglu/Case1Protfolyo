using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace Case1Protfolyo.ViewComponents.AdminLayout
{
    public class _AdminLayoutSidebarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.FullName = HttpContext.Session.GetString("FullName");//sessiondaki FullName i alıoruz.
            return View();
        }
    }
}
