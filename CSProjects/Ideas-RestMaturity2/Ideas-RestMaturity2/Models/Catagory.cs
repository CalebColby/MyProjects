namespace Ideas_RestMaturity2.Models
{
    public class Catagory
    {
        public int CatagoryId { get; set; }
        public string CatagoryName { get; set; }
        public string? CatagoryDescription { get; set; }

        public Catagory(string catagoryName, string? catagoryDescription = null, int catagoryId = -1)
        {
            CatagoryId = catagoryId;
            CatagoryName = catagoryName;
            CatagoryDescription = catagoryDescription;
        }
    }
}
