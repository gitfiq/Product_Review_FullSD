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
                    Title = "Harry Potter"
                },
                new Book
                {
                    Id = 2,
                    Title = "Lord Of The Rings"
                }
            );
        }
    }
}