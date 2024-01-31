using Project.Shared.Domain;
using System.ComponentModel.DataAnnotations;

namespace Project.Shared.Domain
{
    public class Book : BaseDomainModel
    {
        [Required(ErrorMessage = "Title is required")]
        public string? Title { get; set; }


        [Required(ErrorMessage = "Description is required")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "Description does not meet length requirements. Description must be at least 5 characters long ")]
        public string? Description { get; set; }


        [Required(ErrorMessage = "Book Rating is required")]
        [Range(0.0, 5.0, ErrorMessage = "Please enter a rating between 0 and 5")]
        public double BookRating { get; set; }


        [Required(ErrorMessage = "Publish Year is required")]
        [Range(1800, 2024, ErrorMessage = "Please enter a year between 1800 and 2024")]
        public int? PublishYear { get; set; }


        public string? Edition { get; set;}


        [Required(ErrorMessage = "Subject is required")]
        public string? Subject { get; set;}


        [Required(ErrorMessage = "School Level is required")]
        public string? SchoolLevel { get; set;}


        [Required(ErrorMessage = "Number Of Pages is required")]
        public int? NumberOfPages { get; set; }


        public byte[]? Image { get; set; }


        [Required(ErrorMessage = "PublisherID is required")]
        public int? PublisherID { get; set; }
        public virtual Publisher? Publisher { get; set; }

        public virtual List<Recommendation>? Recommendations { get; set;}

        public virtual List<Review>? Reviews { get; set; }
    }
}