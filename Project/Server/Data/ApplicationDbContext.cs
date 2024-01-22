using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Project.Server.Configuration.Entities;
using Project.Server.Configurations.Entities;
using Project.Server.Models;
using Project.Shared.Domain;
using System.Reflection.Emit;

namespace Project.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Recommendation> Recommendations { get; set;}
        public DbSet<Staff> Staffs { get; set;}
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthorDetail> BookAuthorDetails { get; set; }
        public DbSet<Review> Reviews { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new AppUserSeedConfiguration());
            builder.ApplyConfiguration(new AuthorSeedConfiguration());
            builder.ApplyConfiguration(new BookSeedConfiguration());
            builder.ApplyConfiguration(new ReviewSeedConfiguration());

            builder.ApplyConfiguration(new StaffSeedConfiguration());
            builder.ApplyConfiguration(new PublisherSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new RoleSeedConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging(); // Enable sensitive data logging

            base.OnConfiguring(optionsBuilder);
        }
    }
}