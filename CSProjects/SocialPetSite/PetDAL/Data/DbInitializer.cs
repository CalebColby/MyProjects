using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using PetDAL.Models;

namespace PetDAL.Data
{
    public static class DbInitializer
    {
        public static void Initialize(PetContext context)
        {
            context.Database.EnsureCreated();

            SetupPets(context);
            SetupMessages(context);
        }

        private static void SetupMessages(PetContext context)
        {
            
        }

        private static void SetupPets(PetContext context)
        {
            if (context.Pets.Any())
            {
                return;
            }

            Pet[] pets =
            {
                new Pet()
                {
                    Name = "Steve",
                    Description = "Very Jumpy, Kinda Curious",
                    Age = 3,
                    Animal = "Frog",
                    OwnerID = "642b0d97-f2a5-4c27-863f-1e1fa996b619",
                    ImageURL = "https://cdn.britannica.com/84/206384-050-00698723/Javan-gliding-tree-frog.jpg"
                },
                new Pet()
                {
                    Name = "Paul",
                    Description = "Helpful, Expects Effort",
                    Age = 12,
                    Animal = "Fox",
                    OwnerID = "642b0d97-f2a5-4c27-863f-1e1fa996b619",
                    ImageURL = "https://www.nhm.ac.uk/content/dam/nhmwww/discover/urban-foxes/red-fox-v2-two-column.jpg.thumb.768.768.jpg"
                },
                new Pet()
                {
                    Name = "Sue",
                    Description = "Sluggish and Oblivious",
                    Age = 2,
                    Animal = "Goldfish",
                    OwnerID = "642b0d97-f2a5-4c27-863f-1e1fa996b619",
                    ImageURL = "https://image.petmd.com/files/goldfish-swimmingtoward_285011336_0.jpg"
                }
            };

            context.Pets.AddRange(pets);
            context.SaveChanges();
        }
    }
}
