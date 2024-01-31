using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Shared.Domain;

namespace Project.Server.Configuration.Entities
{
    public class BookSeedConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData
            (
                new Book
                {
                    Id = 1,
                    Title = "Harry Potter",
                    Description= "This book is about magic and monsters",
                    BookRating= 0.0,
                    PublishYear = 2014,
                    Edition = "1",
                    Subject = "English",
                    SchoolLevel = "Primary 5",
                    NumberOfPages = 200,
                    PublisherID = 1
                },
                new Book
                {
                    Id = 2,
                    Title = "Lord Of The Rings",
                    Description = "This book is about monsters and dwarves and humans and other things",
                    BookRating = 5.0,
                    PublishYear = 2015,
                    Edition = "1",
                    Subject = "English",
                    SchoolLevel = "Secondary 1",
                    NumberOfPages = 250,
                    PublisherID = 1
                }
            );
        }
    }
}