using Project.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Author> Authors { get; }
        IGenericRepository<AppUser> AppUsers { get; }
        IGenericRepository<Book> Books { get; }
        IGenericRepository<BookAuthorDetail> BookAuthorDetails { get; }
        IGenericRepository<Review> Reviews { get; }
    }
}