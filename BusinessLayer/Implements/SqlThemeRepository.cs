using BooksWebApp.Models;
using BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.Implements
{
    public class SqlThemeRepository : IThemeRepository
    {
        PublishingHouseContext _context;
        public SqlThemeRepository()
        {
            _context = new PublishingHouseContext();
        }

        public List<Themes> GetAllThemes() => _context.Themes.ToList();
        

        public Themes GetThemeById(int themeId) => _context.Themes.FirstOrDefault(t => t.IdTheme == themeId);

    }
}
