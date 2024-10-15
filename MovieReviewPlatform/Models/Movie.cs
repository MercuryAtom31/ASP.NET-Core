using System.ComponentModel.DataAnnotations;

namespace MovieReviewPlatform.Models
{
	public class Movie
    {
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Director is required.")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Release year is required.")]
        [Range(1900, 2024, ErrorMessage = "Please enter a year between 1900 and the current year.")]
        public int ReleaseYear { get; set; }

        [Required(ErrorMessage = "Rating is required.")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        public int Rating { get; set; }

        public string Review { get; set; }

    }
}
