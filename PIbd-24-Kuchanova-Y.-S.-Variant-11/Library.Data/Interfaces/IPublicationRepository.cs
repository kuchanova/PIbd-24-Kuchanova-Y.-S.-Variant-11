using Library.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Interfaces
{
    public interface IPublicationRepository
    {
        IEnumerable<Publication> GetAll();
        Publication GetById(int id);
        void Add(Publication publication);
        void Update(Publication publication);
        void Delete(int id);
    }
}
