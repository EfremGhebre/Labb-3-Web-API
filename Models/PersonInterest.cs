namespace Labb_3_Webb_API.Models
{
    public class PersonInterest
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }

        public int InterestId { get; set; }
        public Interest Interest { get; set; }

        public ICollection<Link> Links { get; set; }
    }

}
