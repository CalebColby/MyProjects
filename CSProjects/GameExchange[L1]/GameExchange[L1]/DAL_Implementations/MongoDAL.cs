using GameExchange_L1_.Interfaces;
using GameExchange_L1_.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace GameExchange_L1_.DAL_Implementations
{
    public class MongoDAL : IDataAccessLayer
    {
        private readonly IMongoCollection<Game> GamesCollection;
        private readonly IMongoCollection<Offer> OffersCollection;
        private readonly IMongoCollection<User> UsersCollection;

        public MongoDAL(IOptions<GameExchangeDatabaseSettings> gameExchangeDatabaseSettings)
        {
            var mongoClinet = new MongoClient(gameExchangeDatabaseSettings.Value.ConnectionString);
            var mongoDatabase = mongoClinet.GetDatabase(gameExchangeDatabaseSettings.Value.DatabaseName);

            GamesCollection = mongoDatabase.GetCollection<Game>(gameExchangeDatabaseSettings.Value.GamesCollectionName);
            OffersCollection = mongoDatabase.GetCollection<Offer>(gameExchangeDatabaseSettings.Value.OffersCollectionName);
            UsersCollection = mongoDatabase.GetCollection<User>(gameExchangeDatabaseSettings.Value.UsersCollectionName);
        }

        public int AddNewGame(Game newGame)
        {
            newGame.Id = GetAllGames().Count;
            while (true)
            {
                try
                {
                    GamesCollection.InsertOne(newGame);
                    return newGame.Id;
                }catch(Exception ex)
                {
                    newGame.Id++;
                }
            }
        }

        public int AddNewOffer(Offer newOffer)
        {
            newOffer.Id = GetAllOffers().Count;
            while (true)
            {
                try
                {
                    OffersCollection.InsertOne(newOffer);
                    return newOffer.Id;
                }
                catch (Exception ex)
                {
                    newOffer.Id++;
                }
            }
        }

        public int AddNewUser(User newUser)
        {
            newUser.Id = GetAllUsers().Count;
            while (true)
            {
                try
                {
                    UsersCollection.InsertOne(newUser);
                    return newUser.Id;
                }
                catch (Exception ex)
                {
                    newUser.Id++;
                }
            }
        }

        public void DeleteGame(int id)
        {
            GamesCollection.DeleteOne(g => g.Id == id);
        }

        public void DeleteOffer(int id)
        {
            OffersCollection.DeleteOne(o => o.Id == id);
        }

        public void DeleteUser(int id)
        {
            UsersCollection.DeleteOne(u => u.Id == id);
        }

        public List<Game> GetAllGames()
        {
            return GamesCollection.Find(_ => true).ToList();
        }

        public List<Offer> GetAllOffers()
        {
            return OffersCollection.Find(_ => true).ToList();
        }

        public List<User> GetAllUsers()
        {
            return UsersCollection.Find(_ => true).ToList();
        }

        public Game GetGame(int id)
        {
            return GamesCollection.FindSync(g => g.Id == id).First();
        }

        public Offer GetOffer(int id)
        {
            return OffersCollection.Find(o => o.Id == id).First();
        }

        public User GetUser(int id)
        {
            return UsersCollection.Find(u => u.Id == id).First();
        }

        public void UpdateGame(Game updatedGame)
        {
            GamesCollection.FindOneAndReplace(g => g.Id == updatedGame.Id, updatedGame);
        }

        public void UpdateOffer(Offer updatedOffer)
        {
            OffersCollection.FindOneAndReplace(o => o.Id == updatedOffer.Id, updatedOffer);
        }

        public void UpdateUser(User updatedUser)
        {
            UsersCollection.FindOneAndReplace(u => u.Id == updatedUser.Id, updatedUser);
        }
    }
}
