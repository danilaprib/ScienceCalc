using Microsoft.AspNetCore.Mvc;
using ScienceCalc.Data;

namespace ScienceCalc.Controllers
{
    public class ToolsController : Controller
    {
        private readonly ScienceCalcContext _context;
        public ToolsController(ScienceCalcContext context)
        {
            _context = context;
        }
        public IActionResult Calculator()
        {
            return View();
        }

        public IActionResult EquationSolverlculator()
        {
            return View();
        }

        public IActionResult Plots()
        {
            return View();
        }
    }
}
