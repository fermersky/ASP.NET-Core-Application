using BooksWebApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    public interface IThemeRepository
    {
        Themes GetThemeById(int themeId);
        List<Themes> GetAllThemes();
    }
}
