using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace VGLibraryDAL {
    public class Game
    {
        public int GameID { get; set; }
        public string Title { get; set; }
        public string Platform { get; set; }
        public string Genre { get; set; }
        public string ESRBRating { get; set; }
        public string Year { get; set; }
        public string CoverImagePath { get; set; }
        public string? LoanedTo { get; set; }
        public string? LoanedDate { get; set; }

        public Game()
        {

        }

        public Game(int id, string title, string platform, string genre, string ESRBRating, string year,
            string coverImagePath = null, string loanedTo = null, string loanedDate = null)
        {
            GameID = id;
            Title = title;
            Platform = platform;
            Genre = genre;
            this.ESRBRating = ESRBRating;
            Year = year;
            CoverImagePath = coverImagePath;
            LoanedTo = loanedTo;
            LoanedDate = loanedDate;
        }

        public Game(string title, string platform, string genre, string ESRBRating, string year,
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
    }
}
