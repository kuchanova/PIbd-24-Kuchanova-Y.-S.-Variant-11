using Library.Data.Interfaces;
using Library.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Stubs
{
    internal class LibrarianThemeRepositoryStub : ILibrarianThemeRepository
    {
        public void Add(LibrarianTheme librarianTheme) { }
        public IEnumerable<LibrarianTheme> GetAll() => [];
    }
}
