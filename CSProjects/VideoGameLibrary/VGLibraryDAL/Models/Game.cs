using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace VGLibraryDAL {
    public class Game
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

        public Game(int id, string title, string platform, string genre, string ESRBRating, string year,
            string coverImagePath = null, string loanedTo = null, string loanedDate = null)
        {
            GameId = id;
            Title = title;
            Platform = platform;
            Genre = genre;
            this.ESRBRating = ESRBRating;
            Year = year;
            CoverImagePath = coverImagePath;
            LoanedTo = loanedTo;
            LoanedDate = loanedDate;
        }
    }
}
