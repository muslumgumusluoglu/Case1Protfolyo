using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;

namespace Case1Protfolyo.ViewComponents.Default_Index
{
    public class _DefaultContactInfoViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public _DefaultContactInfoViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var abaout = _context.ContactInfos.FirstOrDefault();
            return View(abaout);
        }
    }
}
