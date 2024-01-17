using Project.Server.Data;
using Project.Server.IRepository;
using Project.Server.Models;
using Project.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project.Server.Data;
using Project.Server.Models;
using Project.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Project.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<AppUser> _appUsers;
        private IGenericRepository<Review> _reviews;
        private IGenericRepository<Author> _authors;
        private IGenericRepository<Book> _books;
        private IGenericRepository<BookAuthorDetail> _bookAuthorDetails;

        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<AppUser> AppUsers
            => _appUsers ??= new GenericRepository<AppUser>(_context);
        public IGenericRepository<Author> Authors
            => _authors ??= new GenericRepository<Author>(_context);
        public IGenericRepository<Review> Reviews
            => _reviews ??= new GenericRepository<Review>(_context);
        public IGenericRepository<Book> Books
            => _books ??= new GenericRepository<Book>(_context);
        public IGenericRepository<BookAuthorDetail> BookAuthorDetails
            => _bookAuthorDetails ??= new GenericRepository<BookAuthorDetail>(_context);
        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}