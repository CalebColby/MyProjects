using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Routing.Models;

namespace Routing.Controllers
{
    public class CowController : Controller
    {
        public IActionResult Index(int CowNum)
        {
            return View(CowNum);
        }

        public IActionResult NamedIndex(int CowNum, string cowName)
        {
            return View(new NamedCowViewModel(CowNum, cowName));
        }

        public IActionResult Gallary(int ItemsDisplayed, string PageNum = null)
        {
            if(string.IsNullOrEmpty(PageNum)) return View(new GallaryViewModel(ItemsDisplayed));

            try
            {
                return View(new GallaryViewModel(ItemsDisplayed, int.Parse(PageNum)));
            }
            catch (FormatException ex) { }
            
            
            if (PageNum.StartsWith("Page"))
            {
                PageNum = PageNum.Substring(4);
                try
                {
                    return View(new GallaryViewModel(ItemsDisplayed, int.Parse(PageNum)));
                }
                catch (FormatException ex) { }
            }

            return Redirect(".");
        }

        public IActionResult Favorite(string FavoriteCows)
        {
            var FavCows = FavoriteCows.Split('/');
            if(FavCows.Length == 0) return Redirect(".");
            return View(FavCows);
        }
    }
}
