using BooksWebApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    public interface IAuthorRepository
    {
        List<Authors> GetAllAuthors();
        Authors GetAuthorById(int id);
        Authors DeleteAuthor(int id);
        Authors AddAuthor(Authors author);
        Authors UpdateAuthors(Authors newAuthor, Authors oldAuthors);
    }
}
