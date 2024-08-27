namespace Labb_3_Web_API.Models.DTO
{
    public class InterestDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<LinkDTO> Links { get; set; }
    }
}
