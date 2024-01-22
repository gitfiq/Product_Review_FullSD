using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Shared.Domain;

namespace Project.Server.Configuration.Entities
{
    public class ReviewSeedConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasData
            (
                new Review
                {
                    Id = 1,
                    UserRating = 5,
                    Title = "I love this book",
                    Content = "This book has changed my life, and I would highly recommend this to anyone who is in school.",
                    AppUserID = 1,
                    BookID = 1
                }
            );
        }
    }
}
