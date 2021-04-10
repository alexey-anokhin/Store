﻿using System.Text.RegularExpressions;

namespace Store
{

    public class Book
    {
        public int Id { get; }

        public string Isbn { get; }

        public string Author { get; }

        public string Title { get; }

        public string Description { get; }

        public decimal Price { get; }

        public int Quantity { get; set; }

        public Book(int id, string title, string isbn, string author, string description, decimal price)
        {
            Id = id;
            Title = title;
            Isbn = isbn;
            Author = author;
            Description = description;
            Price = price;
        }


        internal static bool IsIsbn(string s)
        {
            if (s == null)
                return false;

            s = s.Replace("-", "")
                 .Replace(" ", "")
                 .ToUpper();

            return Regex.IsMatch(s, @"^ISBN\d{10}(\d{3})?$");
        }
    }
}
