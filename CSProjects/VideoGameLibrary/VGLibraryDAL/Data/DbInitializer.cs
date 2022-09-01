using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VGLibraryDAL.Models;

namespace VGLibraryDAL.Data
{
    public static class DbInitializer
    {
        public static void Initialize(VGLContext context)
        {
            context.Database.EnsureCreated();

            SetupGames(context);
            SetupUsers(context);
        }

        public static void SetupUsers(VGLContext context)
        {
            if (context.Users.Any())
            {
                return;
            }

            var newUsers = new User()
            {
                FirstName = "Joseph",
                LastName = "Colby"

            };
        }

        public static void SetupGames(VGLContext context)
        {
            if (context.Games.Any())
            {
                return;
            }

            var Games = new Game[]
            {
                new Game( "Persona 5 Royal", "PS4", "RPG", "M", "2019", "/img/Persona5RCover.jpg"),
                new Game( "Legend of Zelda: Twilight Princess", "GameCube", "Action RPG", "T", "2006",
                    "/img/LoZ_TwilightPrincessCover.jpg"),
                new Game( "Xenoblade Chronicles X", "Wii U", "Action RPG", "T", "2015", "/img/XenoXCover.jpg"),
                new Game( "Super Smash Bros Ultimate", "Switch", "Fighting Platformer", "E10", "2018",
                    "/img/SmashUltimateCover.jpg"),
                new Game( "StarCraft 2", "PC", "RTS", "T", "2010", "/img/Starcraft2Cover.jpg"),
            };

            context.Games.AddRange(Games);
            context.SaveChanges();
        }
    }
}
