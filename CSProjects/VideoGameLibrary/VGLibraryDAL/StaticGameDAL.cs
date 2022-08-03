using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGLibraryDAL
{
    public class StaticGameDAL : IGameDAL
    {
        private List <Game> Games;

        public StaticGameDAL()
        {
            Games = new List <Game>();
            this.AddGame(new Game(0, "Persona 5 Royal", "PS4", "RPG", "M", "2019", "/img/Persona5RCover.jpg"));
            this.AddGame(new Game(0, "Legend of Zelda: Twilight Princess", "GameCube", " Action RPG", "T", "2006", "/img/LoZ_TwilightPrincessCover.jpg"));
            this.AddGame(new Game(0, "Xenoblade Chronicles X", "Wii U", "Action RPG", "T", "2015", "/img/XenoXCover.jpg"));
            this.AddGame(new Game(0, "Super Smash Bros Ultimate", "Switch", "Fighting Platformer", "E10", "2018", "/img/SmashUltimateCover.jpg"));
            this.AddGame(new Game(0, "StarCraft 2", "PC", "RTS", "T", "2010", "/img/Starcraft2Cover.jpg"));
        }

        public int AddGame(Game newGame)
        {
            int id = Games.Max(g => g.GameId) + 1;
            newGame.GameId = id;
            Games.Add(newGame);
            return id;
        }

        public void DeleteGame(int id)
        {
            var gameToBeRemoved = Games.Find(g => g.GameId == id);
            if (gameToBeRemoved != null) Games.Remove(gameToBeRemoved);
        }

        public int UpdateGame(Game game)
        {
            var GameToBeUpdated = Games.Find(g => g.GameId == game.GameId);
            if (GameToBeUpdated != null)
            {
                DeleteGame(game.GameId);
                Games.Add(game);
                return -1;
            }
            else
            {
                return this.AddGame(game);
            }
        }

        public IEnumerable<Game> FilterGames(string genre = null, string platform = null, string esrbRating = null)
        {
            List<Game> RGames = GetAllGames().ToList();
            var BGames = new List<Game>();
            if (genre != null)
            {
                BGames.AddRange((IEnumerable<Game>)RGames.Select(g => g.Genre != genre));
            }
            if (platform != null)
            {
                BGames.AddRange((IEnumerable<Game>)RGames.Select(g => g.Platform != platform));
            }
            if (esrbRating != null)
            {
                BGames.AddRange((IEnumerable<Game>)RGames.Select(g => g.ESRBRating != esrbRating));
            }

            foreach (var game in BGames)
            {
                RGames.Remove(game);
            }
            return RGames;
        }

        public IEnumerable<Game> GetAllGames()
        {
            return Games;
        }

        public IEnumerable<Game> SearchGames(string keyword)
        {
            return Games.Where(g => g.Title.ToLower().Contains(keyword.ToLower()));
        }
        public IEnumerable<Game> SearchGames(string keyword, IEnumerable<Game> searchList)
        {
            return searchList.Where(g => g.Title.ToLower().Contains(keyword.ToLower()));
        }

        
    }
}
