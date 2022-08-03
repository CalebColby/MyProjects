using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VGLibraryDAL;
using VideoGameLibrary.Models;

namespace VideoGameLibrary.Controllers
{
    public class GameController : Controller
    {
        private IGameDAL dal = new StaticGameDAL();

        private readonly ILogger<HomeController> _logger;

        public GameController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Collection()
        {
            // I need to get all the Games from the DB

            // I need to create a View Model to pass to the view
            var viewModel = new GameListViewModel();
            viewModel.Games = dal.GetAllGames().ToList();

            return View(viewModel); // Pass the model to the view so it can generate the Game List
        }
        public IActionResult Display(string id)
        {
            var viewModel = new GameListViewModel();
            viewModel.Games = dal.GetAllGames().ToList();
            GameViewModel model = null;
            foreach (var g in viewModel.Games)
            {
                if (id == g.Title)
                {
                    model = new GameViewModel(g);
                    ViewData["title"] = $"Info - {id}";
                }
            }

            if (model == null)
            {
                ViewData["title"] = "Error: Game Not Found";
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Display(string id, string LoanName)
        {
            var viewModel = new GameListViewModel();
            viewModel.Games = dal.GetAllGames().ToList();
            GameViewModel model = null;
            foreach (var g in viewModel.Games)
            {
                if (id == g.Title)
                {
                    model = new GameViewModel(g);
                    ViewData["title"] = $"Info - {id}";
                }
            }

            if (model == null)
            {
                ViewData["title"] = "Error: Game Not Found";
            }
            else
            {
                if (string.IsNullOrEmpty(LoanName))
                {
                    model.LoanedDate = null;
                    model.LoanedTo = null;
                }
                else
                {
                    model.LoanedTo = LoanName;
                    model.LoanedDate = DateOnly.FromDateTime(DateTime.Now).ToString();
                }

                dal.UpdateGame(new Game(model.GameId, model.Title, model.Platform, model.Genre, model.ESRBRating,
                model.year, model.CoverImagePath, model.LoanedTo, model.LoanedDate));
            }

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}