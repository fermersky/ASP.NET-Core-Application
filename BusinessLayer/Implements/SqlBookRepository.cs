using BooksWebApp.Models;
using BusinessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.Implements
{
    public class SqlBookRepository : IBookRepository
    {
        private PublishingHouseContext context;

        public SqlBookRepository()
        {
            context = new PublishingHouseContext();
        }


        public Books AddBook(Books book)
        {
            context.Books.Add(book);
            context.SaveChanges();

            return book;
        }

        public Books DeleteBook(int id)
        {
            var bookForRemove = context.Books.FirstOrDefault(b => b.IdBook == id);

            if (bookForRemove != null)
            {
                context.Books.Remove(bookForRemove);
                context.SaveChanges();
            }

            return bookForRemove;
        }

        public List<Books> GetAllBooks()
        {
            return context.Books
                .Include("IdThemeNavigation")
                .Include("IdAuthorNavigation")
                .ToList();
        }

        public Books GetBookById(int id)
        {
            return context.Books
                .Include("IdThemeNavigation")
                .Include("IdAuthorNavigation")
                .FirstOrDefault(b => b.IdBook == id);
        }

        public Books UpdateBook(Books newBook, Books oldBook)
        {
            context.Entry(oldBook).CurrentValues.SetValues(newBook);
            context.SaveChanges();
            return newBook;
        }
    }
}
