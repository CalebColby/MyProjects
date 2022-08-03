using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGLibraryDAL
{
    public interface IGameDAL
    {
        public IEnumerable<Game> GetAllGames();
        public IEnumerable<Game> SearchGames(string keyword);
        public IEnumerable<Game> FilterGames(string genre, string platform, string esrbRating);

        public int AddGame(Game game);

        public int UpdateGame(Game game);

        public void DeleteGame(int id);
    }
}
