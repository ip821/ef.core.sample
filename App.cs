using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using sample1.Data;
using sample1.Entities;

namespace sample1
{
    public class App
    {
        private readonly DataContextFactory _dataContextFactory;
        private readonly DemoDataGenerator _demoDataGenerator;
        public App(DataContextFactory dataContextFactory, DemoDataGenerator demoDataGenerator)
        {
            _demoDataGenerator = demoDataGenerator;
            _dataContextFactory = dataContextFactory;
        }

        internal void Run()
        {
            _demoDataGenerator.Generate();

            using (var context = _dataContextFactory.CreateContext())
            {
                Console.WriteLine("List of authors:");
                var authors = context.Context.Set<Author>().ToList();
                authors.ForEach(a => Console.WriteLine($"Name: {a.Name}"));

                Console.WriteLine("List of books:");
                var books = context.Context.Set<Book>().Include(b => b.AuthorBooks).ToList();
                books.ForEach(a => Console.WriteLine($"Name: {a.Name}"));
            }
        }
    }
}