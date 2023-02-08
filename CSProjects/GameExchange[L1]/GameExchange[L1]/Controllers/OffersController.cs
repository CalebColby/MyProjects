using GameExchange_L1_.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GameExchange_L1_.Controllers
{
    [ApiController]
    [Route("Offers/{AdminPassword}")]
    public class OffersController : Controller
    {
        private static string ADMIN_PASSWORD = "admin";
        private static string ADMIN_ERROR_MESSAGE = "You need the admin password in order to use this API route";
        private readonly IDataAccessLayer dal;

        public OffersController(IDataAccessLayer dal)
        {
            this.dal = dal;
        }

        [HttpGet()]
        public IActionResult GetOffers(string AdminPassword)
        {
            if (AdminPassword != ADMIN_PASSWORD) return BadRequest(ADMIN_ERROR_MESSAGE);
            return Ok(dal.GetAllOffers());
        }
    }
}
