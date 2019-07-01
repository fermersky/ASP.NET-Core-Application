using BusinessLayer;
using PresentationLayer.Models;
using BooksWebApp.Models;
using System.Collections.Generic;
using System;

namespace PresentationLayer.Services
{
    public class BooksService
    {
        private DataManager _dataManager;

        public BooksService(DataManager dm)
        {
            this._dataManager = dm;
        }

        public List<BooksViewModel> GetBooksList()
        {
            var booksViewModelList = new List<BooksViewModel>();

            foreach (Books book in _dataManager.BookRepository.GetAllBooks())
            {
                booksViewModelList.Add(new BooksViewModel()
                {
                    Id = book.IdBook,
                    NameBook = book.NameBook,
                    Author = book.IdAuthorNavigation,
                    Theme = book.IdThemeNavigation
                });
            }

            return booksViewModelList;
        }   
        
        public BooksViewModel BooksDbToViewModel(int bookId)
        {
            var book = _dataManager.BookRepository.GetBookById(bookId);

            var bookViewModel = new BooksViewModel()
            {
                Id = book.IdBook,
                NameBook = book.NameBook,
                Author = book.IdAuthorNavigation,
                Theme = book.IdThemeNavigation,
                
            };

            return bookViewModel;
        }

        public Books AddBookToDataBase(BooksEditModel editModel)
        {
            var book = new Books()
            {
                NameBook = editModel.NameBook,
                IdTheme = editModel.ThemeId,
                IdAuthor = editModel.AuthorId,
                Pages = editModel.Pages,
                Price = editModel.Price,
                DateOfPublish = DateTime.Now,
            };

            _dataManager.BookRepository.AddBook(book);

            return book;
        }
    }
}