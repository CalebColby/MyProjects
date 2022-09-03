using Microsoft.AspNetCore.Mvc;
using SocialPetSite.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using PetDAL.Interfaces;
using PetDAL.Models;

namespace SocialPetSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IPetDAL dal;

        private readonly UserManager<IdentityUser> userManager;

        public HomeController(ILogger<HomeController> logger, IPetDAL injectedDAL, UserManager<IdentityUser> user)
        {
            _logger = logger;
            dal = injectedDAL;
            userManager = user;
        }

        public IActionResult Index()
        {
            if (userManager.GetUserId(User) != null)
            {

            }
            Random rand = new Random();
            List<Pet> pets = dal.GetAllPets().ToList();
            Pet model = pets[rand.Next(pets.Count)];
            return View(model);
        }

        public IActionResult About()
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