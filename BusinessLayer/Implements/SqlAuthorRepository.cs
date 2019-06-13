using BooksWebApp.Models;
using BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.Implements
{
    public class SqlAuthorRepository : IAuthorRepository
    {
        private PublishingHouseContext context;
        public SqlAuthorRepository()
        {
            context = new PublishingHouseContext();
        }
        public Authors AddAuthor(Authors author)
        {
            context.Authors.Add(author);
            return author;
        }

        public Authors DeleteAuthor(int id)
        {
            var authorForRemove = context.Authors.FirstOrDefault(b => b.IdAuthor == id);

            if (authorForRemove != null)
            {
                context.Authors.Remove(authorForRemove);
                context.SaveChanges();
            }

            return authorForRemove;
        }

        public List<Authors> GetAllAuthors()
        {
            return context.Authors.ToList();
        }

        public Authors GetAuthorById(int id)
        {
            return context.Authors.FirstOrDefault(a => a.IdAuthor == id);
        }

        public Authors UpdateAuthors(Authors newAuthor, Authors oldAuthors)
        {
            context.Entry(oldAuthors).CurrentValues.SetValues(newAuthor);
            context.SaveChanges();
            return newAuthor;
        }
    }
}
