using Microsoft.AspNetCore.Mvc;

namespace Case1Protfolyo.ViewComponents.AdminLayout
{
    public class _AdminLayoutHeadViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
