using Library.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Interfaces
{
    public interface IReaderRepository
    {
        IEnumerable<Reader> GetAll();
        Reader GetById(int id);
        void Add(Reader reader);
        void Update(Reader reader);
        void Delete(int id);
    }
}
