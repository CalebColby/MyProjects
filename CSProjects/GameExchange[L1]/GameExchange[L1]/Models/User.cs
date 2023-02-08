namespace GameExchange_L1_.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Password { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string StreetAddress { get; private set; }

        public List<int> OwnedGameIDs = new List<int>();

        public User(string Name, string Email, string StreetAddress, string Password = null, int Id = -1)
        {
            this.Name = Name;
            this.Email = Email;
            this.StreetAddress = StreetAddress;
            this.Password = Password;
            this.Id = Id;
        }

    }
}
