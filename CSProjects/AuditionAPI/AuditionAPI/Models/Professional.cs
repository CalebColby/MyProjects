using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AuditionAPI.Models
{
    public enum ProRole
    {
        Preformer,
        Director
    }

    public class Professional
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; } = "Default";
        public ProRole Role { get; private set; }
        public string EmailAddress { get; private set; } = "Default@example.com";
        public string PhoneNumber { get; private set; } = "801-555-Default";


        //These are only relevant for preformers
        
        public List<Guid> PreformanceHistoryIDs { get; private set; } = new List<Guid>();
        public List<Guid> CurrentPreformancesIDs { get; private set; } = new List<Guid>();


        public Professional(ProRole role, string name, string emailAddress, string phoneNumber)
        {
            Id = Guid.NewGuid();
            Name = name;
            Role = role;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
        }

        public Professional(ProRole role, string name, string emailAddress, string phoneNumber, Guid guid)
        {
            Id = guid;
            Name = name;
            Role = role;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
        }
    }
}
