using BooksWebApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    public interface IBookRepository
    {
        List<Books> GetAllBooks();
        Books GetBookById(int id);
        Books DeleteBook(int id);
        Books AddBook(Books book);
        Books UpdateBook(Books newBook, Books oldBook);
    }
}
