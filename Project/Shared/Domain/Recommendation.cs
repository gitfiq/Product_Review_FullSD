using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Shared.Domain
{
    public class Recommendation : BaseDomainModel
    {
        public string? Description { get; set; }

        public DateTime Date {  get; set; }

        public int? StaffRating { get; set; }

        public int StaffID { get; set; }

        public virtual Staff? Staff { get; set; }

        public int BookID { get; set; }

        public virtual Book? Book { get; set; }
    }
}
