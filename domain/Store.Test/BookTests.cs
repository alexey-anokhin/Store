using System;
using Xunit;

namespace Store.Test
{
    public class BookTests
    {
        [Fact]
        public void IsIbn_WithNull_ReturnFalse()
        {
            bool actual = Book.IsIsbn(null);

            Assert.False(actual);
        }

        [Fact]
        public void IsIbn_WithBlankString_ReturnFalse()
        {
            bool actual = Book.IsIsbn("   ");

            Assert.False(actual);
        }

        [Fact]
        public void IsIbn_WithInvalidIsbn_ReturnFalse()
        {
            bool actual = Book.IsIsbn("ISBN 123");

            Assert.False(actual);
        }

        [Fact]
        public void IsIbn_WithIsbn10_ReturnTruer()
        {
            bool actual = Book.IsIsbn("IsBn 123-456-789 0");

            Assert.True(actual);
        }

        [Fact]
        public void IsIbn_WithIsbn13_ReturnTruer()
        {
            bool actual = Book.IsIsbn("IsBn 123-456-789 0123");

            Assert.True(actual);
        }

        [Fact]
        public void Isisbn_WithTranshStart_ReturnFalse()
        {
            bool actual = Book.IsIsbn("xxx IsBn 123-456-789 0123 yyy");

            Assert.False(actual);
        }
    }
}
