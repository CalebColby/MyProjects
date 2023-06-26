using AuditionAPI.DataAccessLayer;
using AuditionAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AuditionAPI.Controllers
{
    [ApiController]
    [Route("Preformers")]
    public class Preformers : Controller
    {
        private iDAL dal;

        [HttpGet(Name = "GetAllPreformances")]
        public IActionResult GetAllPreformances()
        {
            return Ok(dal.getAllPreformances());
        }

        [HttpPost("{name}/{emailAddress}/{phoneNumber}")]
        public IActionResult RegisterNewPreformer(string name, string emailAddress, string phoneNumber)
        {
            dal.createProfessional(new Professional(ProRole.Preformer,name,emailAddress,phoneNumber));
            return Ok();
        }

        [HttpPut("{PreformerName}/{PreformanceTitle}")]
        public IActionResult Audtion(string PreformerName, string PreformanceTitle)
        {
            try
            {
                var preformance = dal.GetPreformanceByName(PreformanceTitle);
                var preformer = dal.GetProfessionalByName(PreformerName);
                if (preformance == null) return NotFound($"There is no Preformance by that title: {PreformanceTitle}");
                if (preformer == null || preformer.Role != ProRole.Preformer) 
                    return NotFound($"There is no Preformer by that name: {PreformerName}");
                preformance.AudtionedPreformerIds.Add(preformer.Id);
                dal.updatePreformanceByID(preformance.Id, preformance);
                return Ok(preformance);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public Preformers(iDAL dal)
        {
            this.dal = dal;
        }
    }
}
