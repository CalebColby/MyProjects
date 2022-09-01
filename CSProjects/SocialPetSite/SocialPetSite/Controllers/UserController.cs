using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PetDAL.Interfaces;
using SocialPetSite.Models;

namespace SocialPetSite.Controllers
{
    public class UserController : Controller
    {
        private readonly IPetDAL dal;
        private readonly UserManager<IdentityUser> userManager;

        public UserController(UserManager<IdentityUser> userManager, IPetDAL dal)
        {
            this.dal = dal;
            this.userManager = userManager;
        }


        public IActionResult ProfilePage(string userID)
        {
            var model = new UserViewModel();
            //model.MyPage = userManager.GetUserId(User) == userID;

            model.UserPets = dal.GetPetListByUser(userID).ToList();
            return View(model);
        }

        public IActionResult Search()
        {
            return View();
        }
    }
}
