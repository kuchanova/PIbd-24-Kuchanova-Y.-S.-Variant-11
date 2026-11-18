using Library.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Models
{
    public class Publication
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public PublicationType Type { get; private set; }
        public int ThemeId { get; private set; }

        private Publication(int id, string title, PublicationType type, int themeId)
        {
            Id = id;
            Title = title;
            Type = type;
            ThemeId = themeId;
        }

        public static Publication Create(int id, string title, PublicationType type, int themeId)
        {
            if (id <= 0)
                throw new ArgumentException("ID должен быть больше 0", nameof(id));

            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Название издания не может быть пустым", nameof(title));

            if (!Enum.IsDefined(typeof(PublicationType), type))
                throw new ArgumentException("Некорректный тип издания", nameof(type));

            if (themeId <= 0)
                throw new ArgumentException("Некорректный ID тематики", nameof(themeId));

            return new Publication(id, title, type, themeId);
        }
    }
}
