using System;
using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "Art of Programming", "ISBN 12312-31231", "D. Khuth"),
            new Book(2, "Refactoring", "ISBN 12312-31232", "M. Flowler"),
            new Book(3, "C Programming Language", "ISBN 12312-31233", "B. Kernighan, D. Ritchie"),
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
    }
}
