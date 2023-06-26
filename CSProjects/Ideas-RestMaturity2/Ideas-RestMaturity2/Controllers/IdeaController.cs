using Ideas_RestMaturity2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Net;
using System.Xml.Linq;

namespace Ideas_RestMaturity2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IdeaController : ControllerBase
    {

        private List<Idea> Ideas = new List<Idea>();
        private List<Catagory> Catagories = new List<Catagory>();

        private readonly ILogger<IdeaController> _logger;

        public IdeaController(ILogger<IdeaController> logger)
        {
            _logger = logger;

            addNewCatagory(new Catagory("Red Idea"));
            addNewCatagory(new Catagory("Blue Idea"));
            addNewCatagory(new Catagory("Green Idea"));
            addNewCatagory(new Catagory("Yellow Idea"));

            addToIdeas(new Idea("Serious Idea", "An Idea that is Serious", new Random().Next(Catagories.Count)));
            addToIdeas(new Idea("Silly Idea", "An Idea that is Silly", new Random().Next(Catagories.Count)));
            addToIdeas(new Idea("Passable Idea", "An Idea that is Passable", new Random().Next(Catagories.Count)));
        }

        [HttpGet(Name = "GetIdeas")]
        public IActionResult GetIdeas()
        {
            return Ok(Ideas);
        }

        [HttpPost(Name = "PostIdeas")]
        public IActionResult PostIdea(string name, string? description = null)
        {
            addToIdeas(new Idea(name, description, new Random().Next(Catagories.Count)));
            return Ok();
        }

        [HttpPost("{name}")]
        public IActionResult PostCatagory(string name, string? description = null, int dummy = -1)
        {
            addNewCatagory(new Catagory(name, description));
            return Ok();
        }

        [HttpPatch("{ideaToBeUpdatedId:int}/{CatagoryToBeAddedToId:int}")]
        public IActionResult PatchIdeaCatagory(int ideaToBeUpdatedId, int CatagoryToBeAddedToId)
        {
            if (ideaToBeUpdatedId >= Ideas.Count) return NotFound($"There is new Idea with Id: {ideaToBeUpdatedId}");
            if (CatagoryToBeAddedToId >= Catagories.Count) return NotFound($"There is no Catagory with Id: {CatagoryToBeAddedToId}");

            Ideas[ideaToBeUpdatedId].CatagoryId = Catagories[CatagoryToBeAddedToId].CatagoryId;

            return Ok(Ideas[ideaToBeUpdatedId]);
        }

        [HttpPut()]
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

        private void addNewCatagory(Catagory newCatagory)
        {
            newCatagory.CatagoryId = Catagories.Count;

            Catagories.Add(newCatagory);
        }
    }
}