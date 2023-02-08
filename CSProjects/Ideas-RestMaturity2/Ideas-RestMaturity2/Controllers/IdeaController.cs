using Ideas_RestMaturity2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Xml.Linq;

namespace Ideas_RestMaturity2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IdeaController : ControllerBase
    {

        private List<Idea> Ideas = new List<Idea>();

        private readonly ILogger<IdeaController> _logger;

        public IdeaController(ILogger<IdeaController> logger)
        {
            _logger = logger;
            addToIdeas(new Idea("Serious Idea", "An Idea that is Serious"));
            addToIdeas(new Idea("Silly Idea", "An Idea that is Silly"));
            addToIdeas(new Idea("Passable Idea", "An Idea that is Passable"));
        }

        [HttpGet(Name = "GetIdeas")]
        public IActionResult GetIdeas()
        {
            return Ok(Ideas);
        }

        [HttpPost(Name = "PostIdeas")]
        public HttpStatusCode PostIdea(string name, string? description = null)
        {
            addToIdeas(new Idea(name, description));
            return HttpStatusCode.OK;
        }

        [HttpPut]
        public IActionResult PutIdea(int id, string name, string? description = null)
        {
            try
            {
                Ideas[id] = new Idea(name, description, id);
                return Ok(Ideas[id]);
            }catch(ArgumentOutOfRangeException aoore)
            {
                return NotFound(aoore.Message);
            }
        }

        [HttpPatch]
        public IActionResult PatchIdea(int id, string? name = null, string? description = null)
        {
            try
            {
                if (!string.IsNullOrEmpty(name)) Ideas[id].Name = name;
                if (!string.IsNullOrEmpty(description)) Ideas[id].Description = description;
                return Ok(Ideas[id]);
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                return NotFound(aoore.Message);
            }
        }

        [HttpDelete]
        public IActionResult DeleteIdea(int id)
        {
            try
            {
                Ideas.RemoveAt(id);

                for(int i = 0; i < Ideas.Count; i++)
                {
                    Ideas[i].Id = id;
                }

                return Ok();
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                return NotFound(aoore.Message);
            }
        }

        private void addToIdeas(Idea newIdea)
        {
            newIdea.Id = Ideas.Count;

            Ideas.Add(newIdea);
        }
    }
}