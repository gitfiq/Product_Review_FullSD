using CarRentalManagement.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Shared.Domain
{
    public class Review : BaseDomainModel
    {
        //Rating
        public double UserRating { get; set; }
        //Review Title
        public string? Title { get; set; }
        //Review Content
        public string? Content { get; set; }
        //FK to User
        public virtual AppUser? User { get; set; }
        public int UserID { get; set; }
        //FK to Book
        public virtual Book? Book { get; set; }
        public int BookID { get; set; }

        //Date time is already included in BaseDomainModel
    }
}
