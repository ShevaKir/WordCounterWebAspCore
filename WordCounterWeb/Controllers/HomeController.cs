using Microsoft.AspNetCore.Mvc;
using WordCounterWeb.Models;

namespace WordCounterWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string source = "source", int entries = 1, int top = 1)
        {
            TextParse text = new TextParse(source);
            WordAnalysis words = new WordAnalysis(text, entries);

            return View(words.GetTopWordPharse(top));
        }
    }
}
