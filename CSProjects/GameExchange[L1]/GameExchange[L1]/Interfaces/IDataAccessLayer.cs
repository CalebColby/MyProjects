using GameExchange_L1_.Models;

namespace GameExchange_L1_.Interfaces
{
    public interface IDataAccessLayer
    {
        public int AddNewUser(User newUser);
        public List<User> GetAllUsers();
        public User GetUser(int id);
        public void UpdateUser(User updatedUser);
        public void DeleteUser(int id);
        public int AddNewGame(Game newGame);
        public List<Game> GetAllGames();
        public Game GetGame(int id);
        public void UpdateGame(Game updatedGame);
        public void DeleteGame(int id);
        public int AddNewOffer(Offer newOffer);
        public List<Offer> GetAllOffers();
        public Offer GetOffer(int id);
        public void UpdateOffer(Offer updatedOffer);
        public void DeleteOffer(int id);
    }
}
