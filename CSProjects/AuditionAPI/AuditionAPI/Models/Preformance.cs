namespace AuditionAPI.Models
{
    public class Preformance
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; } = "Default";
        public Guid DirectorId { get; private set; }
        public Guid CastingDirectorId { get; private set; }
        public string Venue { get; private set; } = "Default Studios/Stadium";

        //string = Character Name, Guid = Preformer Id
        public Dictionary<string, Guid> Characters = new Dictionary<string, Guid>();

        //Might only have one date, especially in cases of recorded preformances instead of live ones
        public List<DateOnly> PreformanceDates = new List<DateOnly>();

        //Might be empty if no one has auditioned
        public List<Guid> AudtionedPreformerIds = new List<Guid>();

        public Preformance(Guid id, string title, Guid directorId, Guid castingDirectorId, string venue)
        {
            Id = id;
            Title = title;
            DirectorId = directorId;
            CastingDirectorId = castingDirectorId;
            Venue = venue;
        }

        public Preformance(string title, Guid directorId, Guid castingDirectorId, string venue)
        {
            Id = Guid.NewGuid();
            Title = title;
            DirectorId = directorId;
            CastingDirectorId = castingDirectorId;
            Venue = venue;
        }
    }
}
