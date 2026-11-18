using Library.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Interfaces
{
    public interface IThemeRepository
    {
        IEnumerable<Theme> GetAll();
        Theme GetById(int id);
        void Add(Theme theme);
        void Update(Theme theme);
        void Delete(int id);
    }
}
