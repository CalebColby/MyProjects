using PetDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDAL.Interfaces
{
    public interface IPetDAL
    {
        public IEnumerable<Pet> GetAllPets();
        public IEnumerable<Pet> SearchPets(string keyword);
        public IEnumerable<Pet> FilterPets(string animal = null, int minAge = 0, int maxAge = 30);
        public IEnumerable<Pet> GetPetListByUser(string ownerID);
        public Pet GetPetById(int id);
        public int AddPet(Pet newPet);
        public void DeletePet(int id);
        public void UpdatePet(int id, Pet newPet);
    }
}
