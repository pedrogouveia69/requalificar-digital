using Ficha12.Models;
using Microsoft.EntityFrameworkCore;

namespace Ficha12.Services
{
    public class BookService : IBookService
    {
        private readonly LibraryContext context;

        public BookService(LibraryContext context)
        {
            this.context = context;
        }
        public Book Create(Book book)
        {
            throw new NotImplementedException();
        }

        public void DeleteByISBN(string isbn)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAll()
        {
            return context.Books.Include(p => p.Publisher);
        }

        public Book GetByISBN(string isbn)
        {
            return context.Books.Include(p => p.Publisher).SingleOrDefault(b => b.ISBN == isbn);
        }

        public void Update(string isbn, Book book)
        {
            throw new NotImplementedException();
        }

        public void UpdatePublisher(string isbn, int publisherId)
        {
            throw new NotImplementedException();
        }
    }
}
