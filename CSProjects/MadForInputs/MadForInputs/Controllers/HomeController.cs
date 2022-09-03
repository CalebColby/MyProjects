using MadForInputs.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MadForInputs.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            MadLibViewModel model = null;
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(string properNoun, string noun, string adjective, string verb, string adverb)
        {
            if (string.IsNullOrEmpty(properNoun)) properNoun = "(Default Value): Paul Fox";
            if (string.IsNullOrEmpty(noun)) noun = "(Default Value): Professor";
            if (string.IsNullOrEmpty(adjective)) adjective = "(Default Value): Fun";
            if (string.IsNullOrEmpty(verb)) verb = "(Default Value): Walk";
            if (string.IsNullOrEmpty(adverb)) adverb = "(Default Value): Wildly";
            MadLibViewModel model = new MadLibViewModel(properNoun, noun, adjective, verb, adverb);
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}