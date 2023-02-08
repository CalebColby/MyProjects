using GameExchange_L1_.Interfaces;
using GameExchange_L1_.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace GameExchange_L1_.Controllers
{
    [ApiController]
    [Route("User/{UserID:int}")]
    public class UserController : Controller
    {
        private readonly IDataAccessLayer dal;

        public UserController(IDataAccessLayer dal)
        {
            this.dal = dal;
        }

        

        [HttpGet()]
        public IActionResult GetUser(int UserID)
        {
            try
            {
                return Ok(dal.GetUser(UserID));
            }catch(Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("{UserPassword}/ReceivedOffers")]
        public IActionResult GetAllRecievedOffers(int UserID, string UserPassword)
        {
            try
            {
                var CurrentUserData = dal.GetUser(UserID);
                if (CurrentUserData.Password != UserPassword) return BadRequest("The Provided Password doesn't match the record");
                List<Offer> Offers = dal.GetAllOffers();
                return Ok(Offers.Where(o => o.RecipientID == UserID && o.Status == OfferStatus.PENDING));
            }catch(Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("{UserPassword}/MadeOffers")]
        public IActionResult GetAllMadeOffers(int UserID, string UserPassword)
        {
            try
            {
                var CurrentUserData = dal.GetUser(UserID);
                if (CurrentUserData.Password != UserPassword) return BadRequest("The Provided Password doesn't match the record");
                List<Offer> Offers = dal.GetAllOffers();
                return Ok(Offers.Where(o => o.SenderID == UserID && o.Status == OfferStatus.PENDING));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost("{UserPassword}/RegisterNewGame")]
        public IActionResult RegisterNewGameToUserById(int UserID, string UserPassword, string GameName, string GamePublisher,
            int GameReleaseYear, string GamePlatform, Conditions GameCondition)
        {
            try
            {
                var CurrentUserData = dal.GetUser(UserID);
                if (CurrentUserData.Password != UserPassword) return BadRequest("The Provided Password doesn't match the record");
                var newGame = new Game(UserID, GameName, GamePublisher, GameReleaseYear, GamePlatform, GameCondition);
                CurrentUserData.OwnedGameIDs.Add(dal.AddNewGame(newGame));
                return Ok(newGame);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPut("{UserPassword}")]
        public IActionResult updateUserData(int UserID, string UserPassword, string NewName, 
            string NewEmail, string NewPassword ,string NewAddress)
        {
            try
            {
                var CurrentUserData = dal.GetUser(UserID);
                if (CurrentUserData.Password != UserPassword) return BadRequest("The Provided Password doesn't match the record");
                User updatedUserData = new User(NewName, NewEmail, NewAddress, NewPassword, UserID);
                dal.UpdateUser(updatedUserData);
                return Ok(updatedUserData);
            }catch(Exception ex)
            {
                return NotFound(ex.Message);
            }

        }

        [HttpDelete("{UserPassword}")]
        public IActionResult deleteUser(int UserID, string UserPassword)
        {
            try
            {
                var CurrentUserData = dal.GetUser(UserID);
                if (CurrentUserData.Password != UserPassword) return BadRequest("The Provided Password doesn't match the record");
                dal.DeleteUser(UserID);
                return Ok($"The User Data with UserID {UserID} has been deleted");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
