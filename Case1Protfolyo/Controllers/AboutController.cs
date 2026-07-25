using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Case1Protfolyo.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var about = _context.Abouts.FirstOrDefault(); // ilk deger gelecek
            return View(about);
        }

        [HttpGet]
        public IActionResult CreatAbout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatAbout(About about)
        {
            _context.Abouts.Add(about);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UpdateAbout(int id)
        {
            var abaout = _context.Abouts.Find(id); //primary keye göre arama yapar
            return View(abaout);
        }

        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            _context.Abouts.Update(about);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteAbout(int id)
        {
            var abaut = _context.Abouts.Find(id);
            _context.Abouts.Remove(abaut);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
