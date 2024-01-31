using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Project.Shared.Domain
{
    public class Author : BaseDomainModel
    {
        [Required(ErrorMessage = "Email Address is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string? EmailAddress { get; set; }


        [Required(ErrorMessage = "Biography is required")]
        public string? Biography { get; set; }


        [Required(ErrorMessage = "Contact Info is required")]
        [RegularExpression("^[0-9]{8}$", ErrorMessage = "Contact Info must be an 8-digit number")]
        public string? ContactInfo { get; set;}


        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "First Name does not meet length requirements. First Name must be at least 2 characters long ")]
        public string? FirstName { get; set; }


        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Last Name does not meet length requirements. Last Name must be at least 2 characters long ")]
        public string? LastName { get; set;}
    }
}
