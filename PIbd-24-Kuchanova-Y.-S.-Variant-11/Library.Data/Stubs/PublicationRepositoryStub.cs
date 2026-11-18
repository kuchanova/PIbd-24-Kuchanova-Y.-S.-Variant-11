using Library.Data.Interfaces;
using Library.Domain.Enums;
using Library.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Stubs
{
    internal class PublicationRepositoryStub : IPublicationRepository
    {
        public void Add(Publication publication) { }
        public void Delete(int id) { }
        public Publication GetById(int id) => Publication.Create(1, "Пустое издание", PublicationType.Book, 1);
        public IEnumerable<Publication> GetAll() => [];
        public void Update(Publication publication) { }
    }
}
