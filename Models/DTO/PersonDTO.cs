namespace Labb_3_Web_API.Models.DTO
{
    public class PersonDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? PhoneNumber { get; set; }

        public List<InterestDTO> Interests { get; set; } 
    }
}
