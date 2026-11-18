using Library.Data.Interfaces;
using Library.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Stubs
{
    public class ReaderRepositoryStub : IReaderRepository
    {
        public void Add(Reader reader) { }
        public void Delete(int id) { }
        public Reader GetById(int id) => Reader.Create(1, "Пустой читатель", 1);
        public IEnumerable<Reader> GetAll() => [];
        public void Update(Reader reader) { }
    }
}
