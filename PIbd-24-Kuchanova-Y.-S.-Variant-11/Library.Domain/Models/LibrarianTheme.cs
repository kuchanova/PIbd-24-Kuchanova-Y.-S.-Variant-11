using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Models
{
    public class LibrarianTheme
    {
        public int LibrarianId { get; private set; }
        public int ThemeId { get; private set; }

        private LibrarianTheme(int librarianId, int themeId)
        {
            LibrarianId = librarianId;
            ThemeId = themeId;
        }

        public static LibrarianTheme Create(int librarianId, int themeId)
        {
            if (librarianId <= 0)
                throw new ArgumentException("Некорректный ID библиотекаря", nameof(librarianId));

            if (themeId <= 0)
                throw new ArgumentException("Некорректный ID тематики", nameof(themeId));

            return new LibrarianTheme(librarianId, themeId);
        }
    }
}
