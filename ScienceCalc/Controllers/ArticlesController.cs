using Microsoft.AspNetCore.Mvc;
using ScienceCalc.Data;

namespace ScienceCalc.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly ScienceCalcContext _context;
        public ArticlesController(ScienceCalcContext context)
        {
            _context = context;
        }
        public Article GetArticle(int id)
        {
            return _context.articles.Find(id);
        }

        public IActionResult ArticlePage(int id)
        {
            var article = GetArticle(id);
            return View(article);
        }
    }
}
