using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VGLibraryDAL.Models;

namespace VGLibraryDAL.Data
{
    public class VGLContext : DbContext
    {
        public VGLContext(DbContextOptions<VGLContext> options) : base(options)
        {
                //Do something with options if needed
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<FavoriteGame> FavoriteGames { get; set; }
    }
}
