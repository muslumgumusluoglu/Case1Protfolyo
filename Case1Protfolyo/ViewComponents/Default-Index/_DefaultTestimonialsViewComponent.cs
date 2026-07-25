using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;

namespace Case1Protfolyo.ViewComponents.Default_Index
{
    public class _DefaultTestimonialsViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public _DefaultTestimonialsViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var testimonials = _context.Testimonials.ToList();
            return View(testimonials);
        }
    }
}
