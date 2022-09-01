using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VGLibraryDAL;
using VGLibraryDAL.Data;
using VideoGameLibrary.Models;

namespace VideoGameLibrary.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameDAL dal;

        private readonly ILogger<HomeController> _logger;

        public GameController(ILogger<HomeController> logger, IGameDAL dal, VGLContext context)
        {
            _logger = logger;
            this.dal = new EFGameDAL(context);
        }

        public IActionResult Collection()
        {
            // I need to get all the Games from the DB

            // I need to create a View Model to pass to the view
            var viewModel = new GameListViewModel();
            viewModel.Games = dal.GetAllGames().ToList();
            foreach (var game in viewModel.Games)
            {
                viewModel.AddToGenres(game.Genre);
                viewModel.AddToPlatforms(game.Platform);
                viewModel.AddToRatings(game.ESRBRating);
            }

            return View(viewModel); // Pass the model to the view so it can generate the Game List
        }

        [HttpPost]
        public IActionResult Collection(string sKey, string Genre, string Platform, string ESRBRating)
        {
            var viewModel = new GameListViewModel();
            var Filtered = dal.FilterGames(Genre, Platform, ESRBRating);
            if (sKey == null) viewModel.Games = Filtered.ToList();
            else  viewModel.Games = dal.SearchGames(sKey, Filtered).ToList();
            foreach (var game in dal.GetAllGames())
            {
                viewModel.AddToGenres(game.Genre);
                viewModel.AddToPlatforms(game.Platform);
                viewModel.AddToRatings(game.ESRBRating);
            }

            viewModel.searched = true;
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Remove(int RemoveId)
        {
            if(RemoveId > 0) dal.DeleteGame(RemoveId);

            return Redirect("Collection");
        }

        public IActionResult Add()
        {
            ViewData["Warning"] = false;
            return View();
        }

        [HttpPost]
        public IActionResult Add(string Title, string Genre, string ESRBRating, string Platform, string Year)
        {
            if (string.IsNullOrEmpty(Title) ||
            string.IsNullOrEmpty(Genre) ||
            string.IsNullOrEmpty(ESRBRating) ||
            string.IsNullOrEmpty(Platform) ||
            string.IsNullOrEmpty(Year))
            {
                ViewData["Warning"] = true;
                return View();
            }
            dal.AddGame(new Game(0, Title, Platform, Genre, ESRBRating, Year));



            return Redirect("Collection");
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
                model.Year, model.CoverImagePath, model.LoanedTo, model.LoanedDate));
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