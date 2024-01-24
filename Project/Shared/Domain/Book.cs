using Project.Shared.Domain;

namespace Project.Shared.Domain
{
    public class Book : BaseDomainModel
    {
        public string? Title { get; set; } //H1

        public string? Description { get; set; } //p

        public double BookRating { get; set; } //p or stars

        public int? PublishYear { get; set; } //li

        public string? Edition { get; set;} //H2

        public string? Subject { get; set;} //li

        public string? SchoolLevel { get; set;} //li

        public int? NumberOfPages { get; set; }  //li

        public byte[]? Image { get; set; }  //Left BIG

        public int? PublisherID { get; set; }
        public virtual Publisher? Publisher { get; set; }
    }
}