using Microsoft.AspNetCore.Mvc;
using ScienceCalc.Data;

namespace ScienceCalc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ScienceCalcContext _context;
        public HomeController(ScienceCalcContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Articles()
        {
            var articles = _context.articles.ToList();

            return View(articles);
        }

        public IActionResult Tools()
        {
            return View();
        }

        public IActionResult Discussions()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

    }
}
