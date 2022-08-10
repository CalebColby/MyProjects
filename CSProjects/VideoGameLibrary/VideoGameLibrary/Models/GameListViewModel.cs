using VGLibraryDAL;

namespace VideoGameLibrary.Models
{
    public class GameListViewModel
    {
        public List<Game> Games = new List<Game>();
        public List<string> Genres = new List<string>();
        public List<string> Platforms = new List<string>();
        public List<string> ESRBRatings = new List<string>();
        public bool searched = false;

        public void AddToGenres(string newGenre)
        {
            if(Genres.Count == 0) Genres.Add(newGenre);
            else
            {
                foreach (string genre in Genres) if (genre.Equals(newGenre)) return;
                Genres.Add(newGenre);
            }
        }
        public void AddToPlatforms(string newPlatform)
        {
            if (Platforms.Count == 0) Platforms.Add(newPlatform);
            else
            {
                foreach (string platform in Platforms) if (platform.Equals(newPlatform)) return;
                Platforms.Add(newPlatform);
            }
        }
        public void AddToRatings(string newRating)
        {
            if (ESRBRatings.Count == 0) ESRBRatings.Add(newRating);
            else
            {
                foreach (string rating in ESRBRatings) if (rating.Equals(newRating)) return;
                ESRBRatings.Add(newRating);
            }
        }

    }
}
