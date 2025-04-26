namespace BabyCare.Entities
{
    public class SocialMedia
    {
        public int SocialMediaId { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        List<Team> Teams { get; set; }
    }
}
