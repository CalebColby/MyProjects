using AuditionAPI.DataAccessLayer;
using AuditionAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AuditionAPI.Controllers
{
    public class Director : Controller
    {
        private iDAL dal;

        [HttpGet(Name = "GetAllPreformances")]
        public IActionResult GetAllPreformances()
        {
            return Ok(dal.getAllPreformances());
        }

        [HttpPost("{name}/{emailAddress}/{phoneNumber}")]
        public IActionResult RegisterNewDirector(string name, string emailAddress, string phoneNumber)
        {
            dal.createProfessional(new Professional(ProRole.Director, name, emailAddress, phoneNumber));
            return Ok();
        }

        [HttpPost("{title}/{Director Name}/{Casting Director Name}/{Venue}")]
        public IActionResult PostNewPreformance(string title, string directorName, string castingDirectorName, string venue)
        {
            try
            {
                var newPreformance = new Preformance(title, dal.GetProfessionalByName(directorName).Id, 
                    dal.GetProfessionalByName(castingDirectorName).Id, venue);
                dal.createPreformance(newPreformance);
                return Ok(newPreformance);
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{CharacterName}/{PreformerName}/PreformanceName")]
        public IActionResult AcceptAudition(string characterName, string preformerName, string preformanceName)
        {
            try
            {
                var preformance = dal.GetPreformanceByName(preformanceName);
                var preformer = dal.GetProfessionalByName(preformerName);

                preformance.Characters[characterName] = preformer.Id;

                return Ok();
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public Director(iDAL dal)
        {
            this.dal = dal;
        }
    }
}
