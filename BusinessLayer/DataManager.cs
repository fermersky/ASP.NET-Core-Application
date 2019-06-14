
using BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class DataManager
    {
        private IBookRepository _bookRepository;
        public IBookRepository BookRepository { get => _bookRepository; }

        private IAuthorRepository _authorRepository;
        public IAuthorRepository AuthorRepository { get => _authorRepository; }

        public DataManager(IBookRepository bookRepository, IAuthorRepository authorRepository)
        {
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
        }
    }
}
