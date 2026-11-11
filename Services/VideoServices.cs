using Icedodo.Models;

namespace Icedodo.Services
{
    public class VideoServices : IVideoServices
    {
        static List<VideoCategory> videos = new()
        {
           
            new VideoCategory
            {
                ID=1,
                Title="Heliopolis",
                ImageUrl="VideoImages/heliopolis.png",
                VideoId="N5MKAMbnwmI",
            }
        };
    }
}
