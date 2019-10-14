using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.Api.Context;
using Books.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Books.Api.Services
{
    public class BooksRepository : IBooksRepository, IDisposable
    {
        private BooksContext _context; 
        // These methods need to access the database via injection of the book context in the constructor 
        // Constructor injection
        public BooksRepository(BooksContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Task<Book> GetBookAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Book>> GetBooksAsync()
        {
            // also includes the Author for each book
            // without Includes, only brings in the Author id
            return await _context.Books.Include(b => b.Author).ToListAsync(); 
        }

        // Avoid leaks by disposing of the repository
        public void Dispose()
        {
            Dispose(true);
            // tells garbage collector that this repo has been cleaned up
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null; 
                }
            }
        }

    }
}
