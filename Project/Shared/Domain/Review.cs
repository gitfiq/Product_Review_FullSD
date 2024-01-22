using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project.Shared.Domain
{
    public class Review : BaseDomainModel
    {
        public double UserRating { get; set; }

        public string? Title { get; set; }

        public string? Content { get; set; }

        public virtual AppUser? AppUser { get; set; }

        public int AppUserID { get; set; }

        public virtual Book? Book { get; set; }

        public int BookID { get; set; }

        public virtual Staff? Staff { get; set; }

        public int StaffID { get; set; }

    }
}