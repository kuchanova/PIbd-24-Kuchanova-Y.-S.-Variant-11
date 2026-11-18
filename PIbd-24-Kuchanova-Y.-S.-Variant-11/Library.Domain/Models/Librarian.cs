using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Models
{
    public class Librarian
    {
        public int Id { get; private set; }
        public string FullName { get; private set; }

        private Librarian(int id, string fullName)
        {
            Id = id;
            FullName = fullName;
        }

        public static Librarian Create(int id, string fullName)
        {
            if (id <= 0)
                throw new ArgumentException("ID должен быть больше 0", nameof(id));

            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("ФИО библиотекаря не может быть пустым", nameof(fullName));

            return new Librarian(id, fullName);
        }
    }
}
