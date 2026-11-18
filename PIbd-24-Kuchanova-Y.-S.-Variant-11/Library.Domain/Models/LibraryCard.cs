using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Models
{
    public class LibraryCard
    {
        public int Id { get; private set; }
        public string Number { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime FinishDate { get; private set; }

        private LibraryCard(int id, string number, DateTime startDate, DateTime finishDate)
        {
            Id = id;
            Number = number;
            StartDate = startDate;
            FinishDate = finishDate;
        }

        public static LibraryCard Create(int id, string number, DateTime startDate, DateTime finishDate)
        {
            if (id <= 0)
                throw new ArgumentException("ID должен быть больше 0", nameof(id));

            if (string.IsNullOrWhiteSpace(number))
                throw new ArgumentException("Номер билета не может быть пустым", nameof(number));

            if (finishDate < startDate)
                throw new ArgumentException("Дата окончания не может быть раньше даты выдачи", nameof(finishDate));

            return new LibraryCard(id, number, startDate, finishDate);
        }
    }
}
