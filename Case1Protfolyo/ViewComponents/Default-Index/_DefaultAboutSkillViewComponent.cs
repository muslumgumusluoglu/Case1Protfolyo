using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Context;

namespace Case1Protfolyo.ViewComponents.Default_Index
{
    public class _DefaultAboutSkillViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public _DefaultAboutSkillViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Skills.ToList();
            return View(values);
        }
    }
}
