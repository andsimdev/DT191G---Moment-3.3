using System.ComponentModel.DataAnnotations;

namespace DT191G___Moment_3._3.Models
{
    public class Track
    {
        [Required]
        public string? artist { get; set; }
        [Required]
        [Key]
        public string? title { get; set; }
        [Required]
        public int length { get; set; }
        [Required]
        public string? category { get; set; }
    }
}
