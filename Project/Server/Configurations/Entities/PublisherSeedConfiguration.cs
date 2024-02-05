using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Server.Data;
using Project.Shared.Domain;

namespace Project.Server.Configurations.Entities
{
    public class PublisherSeedConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.HasData(
                new Publisher
                {
                    Id = 1,
                    PublisherName = "Educational Publishing House",
                    ContactInfo = "64629603",
                    EmailAddress = "eph@popularworld.com",
                    Address = "15 Serangoon North Avenue 5, Singapore 554360",
                    WebsiteLink = "https://www.eph.com.sg/",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Publisher
                {
                    Id = 2,
                    PublisherName = "Armour Publishing",
                    ContactInfo = "65748432",
                    EmailAddress = "ap@arpub.com",
                    Address = "Bukit Merah Central, #02-07 Block 1003, Singapore 159836",
                    WebsiteLink = "https://armourpublishing.com/",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
                );
        }
    }
}
