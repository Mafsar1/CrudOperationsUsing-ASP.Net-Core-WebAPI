using System.ComponentModel.DataAnnotations;

namespace SuperHeroAPIDotNet7.Models
{
    public class SuperHero
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]  
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? Place { get; set; }
        [Required]
        public string? Description { get; set; }
    }
}
