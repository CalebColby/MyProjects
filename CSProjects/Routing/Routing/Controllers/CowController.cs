using Microsoft.AspNetCore.Mvc;

namespace Routing.Controllers
{
    public class CowController : Controller
    {
        public IActionResult Index(int CowNum)
        {
            return View(CowNum);
        }
    }
}
