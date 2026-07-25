using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Case1Protfolyo.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly AppDbContext _context;

        public ExperienceController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var experience = _context.Experiences.ToList();
            return View(experience);
        }


        [HttpGet]
        public IActionResult CreatExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatExperience(Experience experience)
        {
            _context.Experiences.Add(experience);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var experience = _context.Experiences.Find(id);
            return View(experience);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            _context.Experiences.Update(experience);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperience(int id)
        {
            var project = _context.Experiences.Find(id);
            _context.Remove(project);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
