using System.Collections.Generic;

namespace sample1.Entities
{
    public class Book
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public IList<AuthorBook> AuthorBooks { get; private set; }

        private Book() { }
        public Book(string name, Author author)
        {
            Name = name;
            AuthorBooks = new List<sample1.Entities.AuthorBook> { new AuthorBook { Author = author, Book = this } };
        }
    }
}