using GameExchange_L1_.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace GameExchange_L1_.Controllers
{
    [ApiController]
    [Route("Games")]
    public class GamesController : Controller
    {
        private readonly IDataAccessLayer dal;

        public GamesController(IDataAccessLayer dal)
        {
            this.dal = dal;
        }

        [HttpGet()]
        public IActionResult GetGames()
        {
            try
            {
                var gameList = dal.GetAllGames();
                return Ok(gameList);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet("{GameID:int}")]
        public IActionResult GetGameById(int GameID)
        {
            try
            {
                return Ok(dal.GetGame(GameID));
            }catch(Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
