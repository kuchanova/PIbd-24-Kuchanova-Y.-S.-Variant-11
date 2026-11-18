using Library.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Interfaces
{
    public interface ILibrarianThemeRepository
    {
        IEnumerable<LibrarianTheme> GetAll();
        void Add(LibrarianTheme librarianTheme);
    }
}
