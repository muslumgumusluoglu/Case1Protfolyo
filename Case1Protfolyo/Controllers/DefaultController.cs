using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Case1Protfolyo.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {

        private readonly AppDbContext _context;

        public DefaultController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult SendMessage(UserMessage userMessage)
        {

            _context.Add(userMessage);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
