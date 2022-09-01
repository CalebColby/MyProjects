using System.ComponentModel.DataAnnotations;

namespace SocialPetSite.Models
{
    public class PetViewModel
    {
        public int PetId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string Animal { get; set; }
        [Required]
        [Range(0, 30)]
        public int? Age { get; set; }
        [Required]
        public string? ImageURL { get; set; }
        public string OwnerID { get; set; }
    }
}
