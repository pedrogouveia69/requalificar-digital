using Ficha12.Models;

namespace Ficha12.Data
{
    public static class LibraryDBInitializer
    {
        public static void InsertData(LibraryContext context)
        {
            var publisher = new Publisher
            {
                Name = "Mariner Books"
            };
            context.Publishers.Add(publisher);

            context.Books.Add(new Book
            {
                ISBN = "978",
                Title = "LotR",
                Author = "JRR Tolkien",
                Language = "en",
                Pages = 1216,
                Publisher = publisher,
            });

            context.SaveChanges();
        }
    }
}
