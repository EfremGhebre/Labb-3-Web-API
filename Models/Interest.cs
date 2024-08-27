namespace Labb_3_Webb_API.Models
{
    public class Interest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public ICollection<Link> Links { get; set; }
        public ICollection<PersonInterest> PersonInterests { get; set; }
    }
}
