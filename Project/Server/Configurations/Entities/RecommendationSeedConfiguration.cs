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
                    Description = "This boook is very lovely and i recommended you to read it",
                    StaffRating = 4.5,
                    Date= DateTime.Now,
                    StaffID = 1,
                    BookID = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Recommendation
                {
                    Id = 2,
                    Description = "This book is amazing. It provides, a glimpse of the workforce world. I highly recommend it to the young adults that is searching for a job",
                    StaffRating = 5.0,
                    Date = DateTime.Now,
                    StaffID = 1,
                    BookID = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
