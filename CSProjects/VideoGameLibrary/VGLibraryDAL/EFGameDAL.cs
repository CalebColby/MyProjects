using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VGLibraryDAL.Data;

namespace VGLibraryDAL
{
    public class EFGameDAL : IGameDAL
    {
        private VGLContext context;

        public EFGameDAL(VGLContext context)
        {
            this.context = context;
        }
        public IEnumerable<Game> GetAllGames()
        {
            var Games = context.Games.ToList();
            return Games;
        }

        public IEnumerable<Game> SearchGames(string keyword)
        {
            var Games = GetAllGames().ToList();
            return Games.Where(g => g.Title.Contains(keyword));
        }

        public IEnumerable<Game> SearchGames(string keyword, IEnumerable<Game> searchList)
        {
            var Games = GetAllGames().ToList();
            return searchList.Where(g => g.Title.Contains(keyword));
        }

        public IEnumerable<Game> FilterGames(string genre, string platform, string esrbRating)
        {
            var Games = GetAllGames().ToList();
            Games = Games.Where(g => g.Genre.Equals(genre)).ToList();
            Games = Games.Where(g => g.Platform.Equals(platform)).ToList();
            Games = Games.Where(g => g.ESRBRating.Equals(esrbRating)).ToList();
            return Games;
        }

        public int AddGame(Game game)
        {
            context.Games.Add(game);
            context.SaveChanges();
            return game.GameID;
        }

        public int UpdateGame(Game game)
        {
            var gameToUpdate = context.Games.Where(g => g.GameID == game.GameID).FirstOrDefault();
            if (gameToUpdate == null) return -1;
            
            gameToUpdate.Title = game.Title;
            gameToUpdate.Genre = game.Genre;
            gameToUpdate.Platform = game.Platform;
            gameToUpdate.ESRBRating = game.ESRBRating;
            gameToUpdate.LoanedTo = game.LoanedTo;
            gameToUpdate.LoanedDate = game.LoanedDate;
            gameToUpdate.CoverImagePath = game.CoverImagePath;

            context.SaveChanges();

            return gameToUpdate.GameID;
        }

        public void DeleteGame(int id)
        {
            var gameToDelete = context.Games.Where(g => g.GameID == id).FirstOrDefault();
            if (gameToDelete == null) return;
            context.Games.Remove(gameToDelete);
            context.SaveChanges();
        }
    }
}
