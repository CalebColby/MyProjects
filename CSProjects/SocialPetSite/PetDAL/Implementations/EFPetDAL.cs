using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetDAL.Data;
using PetDAL.Interfaces;
using PetDAL.Models;

namespace PetDAL.Implementations
{
    public class EFPetDAL : IPetDAL
    {
        private PetContext context;

        public EFPetDAL(PetContext context)
        {
            this.context = context;
        }

        public int AddPet(Pet newPet)
        {
            context.Pets.Add(newPet);
            context.SaveChanges();
            return newPet.PetId;
        }

        public void DeletePet(int id)
        {
            var pets = GetAllPets().ToList();
            var badPet = pets.Where(p => p.PetId == id).ToList();
            context.Pets.RemoveRange(badPet);
            context.SaveChanges();
        }

        public IEnumerable<Pet> FilterPets(string animal = null, int minAge = 0, int maxAge = 30)
        {
            var pets = GetAllPets().Where(p => p.Age >= maxAge && p.Age <= minAge);
            if (animal != null)
                pets = pets.Where(p => p.Animal == animal);


            return pets;
        }

        public IEnumerable<Pet> GetPetListByUser(string ownerID)
        {
            return GetAllPets().Where(p => p.OwnerID == ownerID);
        }

        public IEnumerable<Pet> GetAllPets()
        {
            return context.Pets;
        }

        public Pet GetPetById(int id)
        {
            var Pets = GetAllPets().ToList();
            foreach (var pet in Pets)
            {
                if (pet.PetId.Equals(id))
                {
                    return pet;
                }
            }
            throw new IndexOutOfRangeException();
        }

        public IEnumerable<Pet> SearchPets(string keyword)
        {
            return GetAllPets().Where(p => p.Name.Contains(keyword) || p.Description.Contains(keyword));
        }

        public void UpdatePet(int id, Pet newPet)
        {
            var Pets = GetAllPets();
            if (id > context.Pets.Max(p => p.PetId)) throw new IndexOutOfRangeException();
            newPet.PetId = id;
            var petToBeUpdated = Pets.ElementAt(id - 1);
            petToBeUpdated = newPet;
        }
    }
}
