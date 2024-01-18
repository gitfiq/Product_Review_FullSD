using Project.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Recommendation> Recommendations { get; }
        IGenericRepository<Staff> Staffs { get; }
        IGenericRepository<Book> Books { get; }
        IGenericRepository<BookAuthorDetail> BookAuthorDetails { get; }
        IGenericRepository<Review> Reviews { get; }
        IGenericRepository<Publisher> Publishers { get; }
        IGenericRepository<AppUser> AppUsers { get; }
        IGenericRepository<Author> Authors { get; }
    }
}