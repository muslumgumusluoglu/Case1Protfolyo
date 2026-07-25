using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Case1Protfolyo.Controllers
{
    public class TechStackController : Controller
    {
        private readonly AppDbContext _context;

        public TechStackController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var techStack = _context.TechStacks.ToList();
            return View(techStack);
        }

        [HttpGet]
        public IActionResult CreatTechStack()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatTechStack(TechStack techStack)
        {
            _context.Add(techStack);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateTechStack(int id)
        {
            var TechStack = _context.TechStacks.Find(id);
            return View(TechStack);

        }

        [HttpPost]
        public IActionResult UpdateTechStack(TechStack techStack)
        {
            _context.TechStacks.Update(techStack);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}
