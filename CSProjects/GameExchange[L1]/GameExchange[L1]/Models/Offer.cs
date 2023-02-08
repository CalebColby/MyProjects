using System.Runtime.CompilerServices;

namespace GameExchange_L1_.Models
{

    public enum OfferStatus
    {
        PENDING,
        ACCEPTED,
        REJECTED
    }
    public class Offer
    {
        public int Id { get; set; }
        public int SenderID { get; private set; }
        public int RecipientID { get; private set; }
        public OfferStatus Status { get; private set; }

        public List<int> OfferedGamesIDs { get; private set; }
        public List<int> ExpectedGamesIDs { get; private set; }

        public Offer(int SenderID, int RecipientID, List<int> OfferedGames, 
            List<int> ExpectedGames, int Id = -1)
        {
            this.Status = OfferStatus.PENDING;
            this.SenderID = SenderID;
            this.RecipientID = RecipientID;
            this.OfferedGamesIDs = OfferedGames;
            this.ExpectedGamesIDs = ExpectedGames;
            this.Id = Id;
        }

        public void AcceptOffer()
        {
            this.Status = OfferStatus.ACCEPTED;
        }

        public void RejectOffer()
        {
            this.Status = OfferStatus.REJECTED;
        }
    }
}
