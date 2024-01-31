using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Shared.Domain
{
    public class Recommendation : BaseDomainModel
    {
        [Required(ErrorMessage = "Description is required")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "Description does not meet length requirements. Description must be at least 5 characters long ")]
        public string? Description { get; set; }


        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Date, ErrorMessage = "Please enter a valid date")]
        public DateTime Date {  get; set; }


        [Required(ErrorMessage = "StaffRating is required")]
        [Range(0.0, 5.0, ErrorMessage = "Please enter a rating between 0 and 5 only")]
        public double? StaffRating { get; set; }


        [Required(ErrorMessage = "StaffID is required")]
        public int? StaffID { get; set; }

        public virtual Staff? Staff { get; set; }


        [Required(ErrorMessage = "BookID is required")]
        public int? BookID { get; set; }

        public virtual Book? Book { get; set; }
    }
}
