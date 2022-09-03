namespace Routing.Models
{
    public class NamedCowViewModel
    {
        public NamedCowViewModel(int cowNum, string cowName)
        {
            this.mooNum = cowNum;
            this.Name = cowName;
        }

        public string Name { get; set; }
        public int mooNum { get; set; }
    }
}
