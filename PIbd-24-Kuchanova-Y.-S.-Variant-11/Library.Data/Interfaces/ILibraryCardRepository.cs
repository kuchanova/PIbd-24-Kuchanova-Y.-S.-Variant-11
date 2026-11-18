using Library.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Interfaces
{
    public interface ILibraryCardRepository
    {
        IEnumerable<LibraryCard> GetAll();
        LibraryCard GetById(int id);
        void Add(LibraryCard card);
        void Update(LibraryCard card);
        void Delete(int id);
    }
}
