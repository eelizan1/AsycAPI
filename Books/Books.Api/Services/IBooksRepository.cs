using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Api.Services
{
    interface IBooksRepository
    {
        // Synchonous Methods 

        //// get all books
        //IEnumerable<Entities.Book> GetBooks();

        //// get one book by ID
        //Entities.Book GetBook(Guid id);

        // Async Methods
        Task<IEnumerable<Entities.Book>> GetBooksAsync();

        Task<Entities.Book> GetBookAsync(Guid id);
    }
}
