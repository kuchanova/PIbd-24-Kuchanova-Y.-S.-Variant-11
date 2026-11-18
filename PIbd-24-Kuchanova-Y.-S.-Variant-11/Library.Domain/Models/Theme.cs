using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Models
{
    public class Theme
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        private Theme(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static Theme Create(int id, string name)
        {
            if (id <= 0)
                throw new ArgumentException("ID должен быть больше 0", nameof(id));

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Название тематики не может быть пустым", nameof(name));

            return new Theme(id, name);
        }
    }
}
