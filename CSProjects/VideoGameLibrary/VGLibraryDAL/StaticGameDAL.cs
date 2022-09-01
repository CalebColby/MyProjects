using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGLibraryDAL
{
    public class StaticGameDAL : IGameDAL
    {
        private List <Game> Games = new List<Game>();

        public StaticGameDAL()
        {
            this.AddGame(new Game(0, "Persona 5 Royal", "PS4", "RPG", "M", "2019", "/img/Persona5RCover.jpg"));
            this.AddGame(new Game(0, "Legend of Zelda: Twilight Princess", "GameCube", "Action RPG", "T", "2006", "/img/LoZ_TwilightPrincessCover.jpg"));
            this.AddGame(new Game(0, "Xenoblade Chronicles X", "Wii U", "Action RPG", "T", "2015", "/img/XenoXCover.jpg"));
            this.AddGame(new Game(0, "Super Smash Bros Ultimate", "Switch", "Fighting Platformer", "E10", "2018", "/img/SmashUltimateCover.jpg"));
            this.AddGame(new Game(0, "StarCraft 2", "PC", "RTS", "T", "2010", "/img/Starcraft2Cover.jpg"));
        }

        public int AddGame(Game newGame)
        {
            int id = 1;
            if (Games.Count != 0)
            {
                id = Games.Max(g => g.GameID) + 1;
                foreach (Game game in Games)
                {
                    if (newGame.Title.Equals(game.Title) && newGame.Platform.Equals(game.Platform)
                        && newGame.Genre.Equals(game.Genre) && newGame.ESRBRating.Equals(game.ESRBRating)
                        && newGame.Year.Equals(game.Year)) return -1;
                }
            }
            newGame.GameID = id;
            Games.Add(newGame);
            return id;
        }

        public void DeleteGame(int id)
        {
            Games.RemoveAll(g => g.GameID == id);
            int test = 0;
            test++;
            test++;
            test++;
            test++;
        }

        public int UpdateGame(Game game)
        {
            var GameToBeUpdated = Games.Find(g => g.GameID == game.GameID);
            if (GameToBeUpdated != null)
            {
                DeleteGame(game.GameID);
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

            if(genre != null) RGames = RGames.Where(g => g.Genre.Equals(genre)).ToList();
            if(platform != null) RGames = RGames.Where(g => g.Platform.Equals(platform)).ToList();
            if(esrbRating != null) RGames = RGames.Where(g => g.ESRBRating.Equals(esrbRating)).ToList();

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
