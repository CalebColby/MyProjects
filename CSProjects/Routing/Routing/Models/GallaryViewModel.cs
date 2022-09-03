namespace Routing.Models
{
    public class GallaryViewModel
    {
        public int PageNum { get; set; }

        public int ItemsDisplayed { get; set; }

        public GallaryViewModel(int items, int pageNum = -1)
        {
                ItemsDisplayed = items;
                PageNum = pageNum;
        }
    }
}
