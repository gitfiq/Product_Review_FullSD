using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Shared.Domain
{
    public class Publisher : BaseDomainModel
    {
        [Required(ErrorMessage = "Publisher's Name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Publisher's Name does not meet length requirements. Publisher's Name must be at least 2 characters long ")]
        public string? PublisherName { get; set;}


        [Required(ErrorMessage = "Publisher's Email Address is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string? EmailAddress { get; set; }


        public string? ContactInfo { get; set;}


        [Required(ErrorMessage = "Publisher's Address is required")]
        public string? Address { get; set;}


        public string? WebsiteLink { get; set; }
    }
}
