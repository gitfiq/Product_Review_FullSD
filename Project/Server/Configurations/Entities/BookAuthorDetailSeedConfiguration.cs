using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Shared.Domain;

namespace Project.Server.Configuration.Entities
{
    public class BookAuthorDetailSeedConfiguration : IEntityTypeConfiguration<BookAuthorDetail>
    {
        public void Configure(EntityTypeBuilder<BookAuthorDetail> builder)
        {
            builder.HasData
            (
                new BookAuthorDetail
                {
                    Id = 1,
                    BookID = 1,
                    AuthorID = 4
                },
                new BookAuthorDetail
                {
                    Id = 2,
                    BookID = 2,
                    AuthorID = 3
                }
            );
        }
    }
}
