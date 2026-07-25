using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;

namespace Case1Protfolyo.ViewComponents.Default_Index
{
    public class _DefaultAboutViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public _DefaultAboutViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var abaout = _context.Abouts.FirstOrDefault();
            return View(abaout);
        }
    }

}
