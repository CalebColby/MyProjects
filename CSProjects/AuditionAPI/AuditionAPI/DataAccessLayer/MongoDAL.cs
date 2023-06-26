using MongoDB.Driver;
using MongoDB.Bson;
using AuditionAPI.Models;

namespace AuditionAPI.DataAccessLayer
{
    public class MongoDAL : iDAL
    {
        private string connectionUri =
            "mongodb+srv://CalebC:oKEDrCJCP9faTU2u@csc380performancedataba.a97fdzf.mongodb.net/?retryWrites=true&w=majority";
        private IMongoDatabase database;
        private IMongoCollection<Preformance> preformances;
        private IMongoCollection<Professional> professionals;
        public MongoDAL()
        {
            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            // Set the ServerApi field of the settings object to Stable API version 1
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            // Create a new client and connect to the server
            var client = new MongoClient(settings);
            database = client.GetDatabase("AuditionAPI");
            preformances = database.GetCollection<Preformance>("Performances");
            professionals = database.GetCollection<Professional>("Professionals");
            try
            {
                var result = client.GetDatabase("admin").RunCommand<BsonDocument>(new BsonDocument("ping", 1));
                Console.WriteLine("Pinged your deployment. You successfully connected to MongoDB!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void createPreformance(Preformance newPreformance)
        {
            preformances.InsertOne(newPreformance);
        }

        public void createProfessional(Professional newProfessional)
        {
            professionals.InsertOne(newProfessional);
        }

        public void deletePreformance(Guid deleteID)
        {
            preformances.DeleteOne(p => p.Id == deleteID);
        }

        public void deleteProfessional(Guid deleteID)
        {
            professionals.DeleteOne(p => p.Id == deleteID);
        }

        public List<Preformance> getAllPreformances()
        {
            return preformances.Find<Preformance>(p => !p.Equals(null)).ToList();
        }

        public List<Professional> getAllProfessionals()
        {
            return professionals.Find<Professional>(p => !p.Equals(null)).ToList();
        }

        public Preformance getPreformanceByID(Guid searchID)
        {
            return getAllPreformances().Where(p => p.Id == searchID).First();
        }

        public Preformance GetPreformanceByName(string searchName)
        {
            return getAllPreformances().Where(p => p.Title == searchName).First();
        }

        public Professional getProfessionalByID(Guid searchID)
        {
            return getAllProfessionals().Where(p => p.Id == searchID).First();
        }

        public Professional GetProfessionalByName(string searchName)
        {
            return getAllProfessionals().Where(p => p.Name == searchName).First();
        }

        public void updatePreformanceByID(Guid updateID, Preformance updatePreformance)
        {
            preformances.FindOneAndReplace((p => p.Id == updateID), updatePreformance);
        }

        public void updateProfessionalByID(Guid updateID, Professional updateProfessional)
        {
            professionals.FindOneAndReplace((p => p.Id == updateID), updateProfessional);
        }
    }
}
