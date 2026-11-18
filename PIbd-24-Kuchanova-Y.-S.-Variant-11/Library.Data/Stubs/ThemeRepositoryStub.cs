using Library.Data.Interfaces;
using Library.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Stubs
{
    internal class ThemeRepositoryStub : IThemeRepository
    {
        public void Add(Theme theme)
        {
        }

        public void Delete(int id)
        {
        }

        public Theme GetById(int id)
        {
            return Theme.Create(1, "Пустая тематика");
        }

        public IEnumerable<Theme> GetAll()
        {
            return [];
        }

        public void Update(Theme theme)
        {
        }
    }
}
