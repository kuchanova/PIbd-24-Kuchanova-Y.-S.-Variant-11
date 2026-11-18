using Library.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Interfaces
{
    public interface ILibrarianRepository
    {
        IEnumerable<Librarian> GetAll();
        Librarian GetById(int id);
        void Add(Librarian librarian);
        void Update(Librarian librarian);
        void Delete(int id);
    }
}
