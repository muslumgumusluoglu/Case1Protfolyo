using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;

namespace Case1Protfolyo.ViewComponents.Default_Index
{
    public class _DefaultUserMessageViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            //amaç sadece formu yükleme post çalışmıyor burada dip bilgi
            return View();
        }
    }
}
