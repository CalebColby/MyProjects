using VGLibraryDAL;

namespace VideoGameLibrary.Models
{
    public class GameViewModel
    {
        public int GameId = 0;
        public string Title;
        public string Platform;
        public string Genre;
        public string ESRBRating;
        public string Year;
        public string CoverImagePath;
        public string LoanedTo;
        public string LoanedDate;

        public GameViewModel(string title, string platform, string genre, string ESRBRating, string year,
            string coverImagePath = null, string loanedTo = null, string loanedDate = null)
        {
            Title = title;
            Platform = platform;
            Genre = genre;
            this.ESRBRating = ESRBRating;
            Year = year;
            CoverImagePath = coverImagePath;
            LoanedTo = loanedTo;
            LoanedDate = loanedDate;
        }

        public GameViewModel(Game game)
        {
            GameId = game.GameId;
            Title = game.Title;
            Platform = game.Platform;
            Genre = game.Genre;
            ESRBRating = game.ESRBRating;
            Year = game.Year;
            CoverImagePath = game.CoverImagePath;
            LoanedTo = game.LoanedTo;
            LoanedDate = game.LoanedDate;
        }
    }
}

