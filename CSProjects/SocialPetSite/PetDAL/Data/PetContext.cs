using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using PetDAL.Models;

namespace PetDAL.Data
{
    public class PetContext : DbContext
    {
        public PetContext(DbContextOptions<PetContext> Options) : base(Options)
        {

        }

        public DbSet<Pet> Pets { get; set; }
        //public DbSet<Message> Messages { get; set; }
    }
}
