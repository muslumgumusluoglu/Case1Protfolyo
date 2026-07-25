using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Case1Protfolyo.Controllers
{
    public class ProjectTechStackController : Controller
    {
        private readonly AppDbContext _context;

        public ProjectTechStackController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Projects.Include(x => x.ProjectTechStacks).ThenInclude(x => x.TechStack).ToList();

            return View(values);
        }

        [HttpGet]
        public IActionResult Creat()
        {

            var projects = _context.Projects.ToList();
            var techstacks = _context.TechStacks.ToList();

            ViewBag.projects = (from project in projects
                                select new SelectListItem
                                {
                                    Text = project.Name.ToString(),
                                    Value = project.Id.ToString()
                                }).ToList();


            ViewBag.techstackS = (from techstack in techstacks
                                  select new SelectListItem
                                  {
                                      Text = techstack.Name.ToString(),
                                      Value = techstack.Id.ToString()
                                  }).ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Creat(ProjectTechStack projectTechStack)
        {
            _context.ProjectTechStacks.Add(projectTechStack);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
