using CarRentalManagement.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Shared.Domain
{
    public class Author : BaseDomainModel
    {
        public string? EmailAddress { get; set; }
        public string? Biography { get; set; }
        public string? ContactInfo { get; set;}
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
    }
}
