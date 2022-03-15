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
            var publisher = context.Publishers.Find(book.Publisher.Id);
            if (publisher != null)
            {
                context.Books.Add(book);
                context.SaveChanges();
            }            
            return book;
        }

        public void DeleteByISBN(string isbn)
        {
            var book = context.Books.SingleOrDefault(b => b.ISBN == isbn);
            if (book != null)
            {
                context.Books.Remove(book);
                context.SaveChanges();
            }
        }

        public IEnumerable<Book> GetAll()
        {
            return context.Books.Include(p => p.Publisher);
        }

        public Book GetByISBN(string isbn)
        {
            return context.Books.Include(p => p.Publisher).SingleOrDefault(b => b.ISBN == isbn);
        }

        public void Update(string isbn, Book b)
        {
            var book = context.Books.SingleOrDefault(b => b.ISBN == isbn);
            if (book != null)
            {
                book.ISBN = b.ISBN;
                book.Publisher = b.Publisher;
                book.Author = b.Author; 
                book.Pages = b.Pages;
                book.Language = b.Language;
                book.Title = b.Title;
                context.SaveChanges();
            }
        }

        public void UpdatePublisher(string isbn, int publisherId)
        {
            var book = context.Books.SingleOrDefault(b => b.ISBN == isbn);
            if (book != null)
            {
                book.Publisher.Id = publisherId;
                context.SaveChanges();                
            }
        }
    }
}
