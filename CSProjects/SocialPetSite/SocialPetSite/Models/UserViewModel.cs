using PetDAL.Models;

namespace SocialPetSite.Models
{
    public class UserViewModel
    {
        public string UserName { get; set; }

        public bool MyPage = false;

        public List<Pet> UserPets = new List<Pet>();
    }
}
