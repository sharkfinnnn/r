namespace Icedodo.Models
{
    public class VideoCategory
    {

        public int ID { get; set; }
        public int CatergoryId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string VideoId { get; set; } = string.Empty;


    }
}
