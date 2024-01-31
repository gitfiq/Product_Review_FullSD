using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Project.Shared.Domain;


namespace Project.Server.Configuration.Entities
{
    public class RecommendationSeedConfiguration : IEntityTypeConfiguration<Recommendation>
    {
        public void Configure(EntityTypeBuilder<Recommendation> builder)
        {
            builder.HasData
            (
                new Recommendation
                {
                    Id = 1,
                    Description = "this book is very lovely and I recommended it to whoever is interested in math",
                    StaffRating = 5.0,
                    Date= DateTime.Now,
                    StaffID = 1,
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
