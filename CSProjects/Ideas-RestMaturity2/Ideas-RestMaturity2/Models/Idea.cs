namespace Ideas_RestMaturity2.Models
{
    public class Idea
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int CatagoryId { get; set; }


        public Idea(string name, string description = null, int CataID = -1, int id = -1)
        {
            Name = name;
            Description = description;
            Id = id;
        }
    }
}
