using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Server.Data;
using Project.Shared.Domain;

namespace Project.Server.Configurations.Entities
{
    public class BookAuthorDetailSeedConfiguration : IEntityTypeConfiguration<BookAuthorDetail>
    {
        public void Configure(EntityTypeBuilder<BookAuthorDetail> builder)
        {
            builder.HasData(
                new BookAuthorDetail
                {
                    Id = 1,
                    AuthorID = 1,
                    BookID = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
                );
        }
    }
}
