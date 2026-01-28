using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MovieWatchList.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required]
        [Range(1888, 2027, ErrorMessage = "Year must be between 1888 and 2027.")]
        public int Year { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        public bool Watched { get; set; }

        public string Status => Watched ? "✓ Watched" : "✕ Not Seen";
    }
}
