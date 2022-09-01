using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGLibraryDAL.Models
{
    public class FavoriteGame
    {
        public int FavoriteGameID { get; set; }
        public int UserID { get; set; }
        public int GameID { get; set; }
    }
}
