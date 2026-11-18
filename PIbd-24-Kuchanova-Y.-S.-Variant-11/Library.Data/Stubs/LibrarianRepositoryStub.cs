using Library.Data.Interfaces;
using Library.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Stubs
{
    public class LibrarianRepositoryStub : ILibrarianRepository
    {
        public void Add(Librarian librarian) { }
        public void Delete(int id) { }
        public Librarian GetById(int id) => Librarian.Create(1, "Пустой библиотекарь");
        public IEnumerable<Librarian> GetAll() => [];
        public void Update(Librarian librarian) { }
    }
}
