using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project.Shared.Domain
{
    public class Review : BaseDomainModel
    {
        [Required(ErrorMessage = "UserRating is required")]
        [Range(0.0, 5.0, ErrorMessage = "Please enter a rating between 0 and 5 only")]
        public double UserRating { get; set; }


        [Required(ErrorMessage = "Title is required")]
        public string? Title { get; set; }


        [Required(ErrorMessage = "Content is required")]
        public string? Content { get; set; }


        public virtual AppUser? AppUser { get; set; }
        [Required(ErrorMessage = "AppUserID is required")]
        public int? AppUserID { get; set; }


        public virtual Book? Book { get; set; }
        [Required(ErrorMessage = "BookID is required")]
        public int? BookID { get; set; }

    }
}