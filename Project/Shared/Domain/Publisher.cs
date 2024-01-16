using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Shared.Domain
{
    public class Publisher : BaseDomainModel
    {
        public int PublisherId { get; set; }

        public string? PublisherName { get; set;}

        public string? EmailAddress { get; set; }

        public string? ContactInfo { get; set;}

        public string? Address { get; set;}

        public string? WebsiteLink { get; set; }
    }
}
