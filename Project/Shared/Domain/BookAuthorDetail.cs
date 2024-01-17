using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Shared.Domain
{
    public class BookAuthorDetail : BaseDomainModel
    {
        public int? AuthorID { get; set; }
        public virtual Author? Author { get; set; }
        public int? BookID { get; set; }
        public virtual Book? Book { get; set; }
    }
}
