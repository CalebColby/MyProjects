using GameExchange_L1_.Interfaces;
using Microsoft.AspNetCore.Mvc;
using GameExchange_L1_.Models;
using System.Net;

namespace GameExchange_L1_.Controllers
{
    [ApiController]
    [Route("Users")]
    public class UsersController : Controller
    {
        private readonly IDataAccessLayer dal;

        public UsersController(IDataAccessLayer dal)
        {
            this.dal = dal;
        }


        [HttpPost]
        public IActionResult RegisterNewUser(string Name, string Email, string Address, string Password)
        {
            try
            {
                User newUser = new User(Name, Email, Address, Password);
                dal.AddNewUser(newUser);
                return Created("The Following object was successfully created", newUser);
            }
            catch (Exception ex) 
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetUserList()
        {
            try
            {
                var userList = dal.GetAllUsers();
                return Ok(userList);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
