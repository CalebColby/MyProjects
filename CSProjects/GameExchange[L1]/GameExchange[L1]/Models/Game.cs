using Microsoft.VisualBasic;

namespace GameExchange_L1_.Models
{
    public enum Conditions
    {
        MINT,
        GOOD,
        FAIR,
        POOR
    }

    public class Game
    {
        public int Id { get; set; }
        public int OwnerID { get; private set; }
        public string Name { get; private set; }
        public string Publisher { get; private set; }
        public int Year { get; private set; }
        public string Platform { get; private set; }
        public Conditions Condition { get; private set; }
        
        public Game(int OwnerID, string Name, string Publisher, int Year, string Platform,
            Conditions Condition = Conditions.GOOD, int Id = -1)
        {
            this.OwnerID = OwnerID;
            this.Name = Name;
            this.Publisher = Publisher;
            this.Year = Year;
            this.Platform = Platform;
            this.Condition = Condition;
            this.Id = Id;
        }

        public void changeOwner(int newOwnerId)
        {
            OwnerID = newOwnerId;
        }  
    }
}
