namespace Labb_3_Webb_API.Models
{
    public class Person
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? PhoneNumber { get; set; }

        public ICollection<PersonInterest> PersonInterests { get; set; }
    }
}
