using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Shared.Domain;

namespace Project.Server.Configuration.Entities
{
    public class AppUserSeedConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasData
            (
                new AppUser
                {
                    Id = 1,
                    Username = "User_Ray",
                    Password = "password",
                    EmailAddress = "rayleong@bookmail.com",
                    FirstName = "Ray",
                    LastName = "Leong",
                    Gender = "Male",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new AppUser
                {
                    Id = 2,
                    Username = "User_Afiq",
                    Password = "password",
                    EmailAddress = "afiq@bookmail.com",
                    FirstName = "Ahmad",
                    LastName = "Afiq",
                    Gender = "Male",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
