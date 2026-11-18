using Library.Data.Interfaces;
using Library.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Stubs
{
    public class LibraryCardRepositoryStub : ILibraryCardRepository
    {
        public void Add(LibraryCard card) { }
        public void Delete(int id) { }
        public LibraryCard GetById(int id) => LibraryCard.Create(1, "0000", DateTime.Now, DateTime.Now.AddYears(1));
        public IEnumerable<LibraryCard> GetAll() => [];
        public void Update(LibraryCard card) { }
    }
}
