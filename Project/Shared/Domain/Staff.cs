using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        [Required(ErrorMessage = "Username is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Username does not meet length requirements. Username must be at least 3 characters long ")]
        public string? Username { get; set; }


        [Required(ErrorMessage = "Password is required")]
        [MinLength(6, ErrorMessage = "Password does not meet length requirements. Password must be at least 6 characters long")]
        public string? Password { get; set; }


        [Required(ErrorMessage = "Contact Info is required")]
        [RegularExpression("^[0-9]{8}$", ErrorMessage = "Contact Info must be an 8-digit number")]
        public string? ContactInfo { get; set; }


        [Required(ErrorMessage = "Email Address is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string? EmailAddress { get; set; }


        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "First Name does not meet length requirements. First Name must be at least 2 characters long ")]
        public string? FirstName { get; set;}


        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Last Name does not meet length requirements. Last Name must be at least 2 characters long ")]
        public string? LastName { get; set;}


        public virtual List<Recommendation>? Recommendations { get; set; }
    }
}
