namespace Labb_3_Webb_API.Models
{
    public class Link
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public Interest Interest { get; set; }

        public int InterestId { get; set; }

    }
}
