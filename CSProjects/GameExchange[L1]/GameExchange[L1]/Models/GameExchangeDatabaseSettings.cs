namespace GameExchange_L1_.Models
{
    public class GameExchangeDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
        public string UsersCollectionName { get; set; } = null!;
        public string GamesCollectionName { get; set; } = null!;
        public string OffersCollectionName { get; set; } = null!;
    }
}
