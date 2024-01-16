﻿namespace Project.Shared.Domain
{
    public class Book :BaseDomainModel
    {
        public int BookId { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public int? BookRating { get; set; }

        public int? PublishYear { get; set; }

        public string? Edition { get; set;}

        public string? Subject { get; set;}

        public string? SchoolLevel { get; set;}

        public int? NumberOfPages { get; set; }

        public string? BookImage { get; set; }

        public int PublisherID { get; set; }

        public virtual Publisher? Publisher { get; set; }

        public virtual List<Recommendation>? Recommendations { get; set;}

        public virtual List<Review>? Reviews { get; set; }
    }
}