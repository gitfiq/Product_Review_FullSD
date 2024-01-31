using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Shared.Domain
{
    public class BookAuthorDetail : BaseDomainModel
    {
        [Required(ErrorMessage = "AuthorID is required")]
        public int? AuthorID { get; set; }
        public virtual Author? Author { get; set; }


        [Required(ErrorMessage = "BookID is required")]
        public int? BookID { get; set; }
        public virtual Book? Book { get; set; }
    }
}
