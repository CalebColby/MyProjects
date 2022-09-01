using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDAL.Models
{
    public class Pet
    {
        public int PetId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Animal { get; set; }
        public int? Age { get; set; }
        public string? ImageURL { get; set; }
        public string? OwnerID { get; set; }

        public Pet()
        {

        }
    }
}
