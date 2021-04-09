using System;
using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(0, "Art of Programming", "ISBN 12312-31231", "D. Knuth", "LoremLoremLoremLoremLoremLoremLoremLoremLorem", 7.59m),
            new Book(1, "Refactoring", "ISBN 12312-31232", "M. Flowler", "LoremLoremLoremLoremLoremLoremLoremLoremLorem", 6.30m),
            new Book(2, "C Programming Language", "ISBN 12312-31233", "B. Kernighan, D. Ritchie", "LoremLoremLoremLoremLoremLoremLoremLoremLorem", 5.27m),
        };

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn == isbn)
                        .ToArray();
        }     

        public Book[] GetAllByTitleOrAuthor(string query)
        {
            return books.Where(book => book.Author.Contains(query)
                                    || book.Title.Contains(query))
                        .ToArray();
        }

        public Book GetById(int id)
        {
            return books.Single(book => book.Id == id);
        }
    }
}
