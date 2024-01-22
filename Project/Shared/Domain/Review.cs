using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project.Shared.Domain
{
    public class Review : BaseDomainModel
    {
        public int UserRating { get; set; }

        public string? Title { get; set; }

        public string? Content { get; set; }

        public virtual AppUser? AppUser { get; set; }

        public int AppUserID { get; set; }

        public virtual Book? Book { get; set; }

        public int BookID { get; set; }

    }
}