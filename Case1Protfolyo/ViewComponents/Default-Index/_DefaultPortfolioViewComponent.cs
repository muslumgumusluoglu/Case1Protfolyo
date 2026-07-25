using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Context;

namespace Case1Protfolyo.ViewComponents.Default_Index
{
    public class _DefaultPortfolioViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public _DefaultPortfolioViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Projects.Include(x => x.ProjectTechStacks).ThenInclude(x => x.TechStack).ToList();
            return View(values);
        }
    }
}
