using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Models
{
    public class Loan
    {
        public int Id { get; private set; }
        public DateTime IssueDate { get; private set; }
        public DateTime DueDate { get; private set; }
        public DateTime? ActualReturnDate { get; private set; }
        public int ReaderId { get; private set; }
        public int PublicationId { get; private set; }
        public int LibrarianId { get; private set; }

        private Loan(int id, DateTime issueDate, DateTime dueDate, DateTime? actualReturnDate, int readerId, int publicationId, int librarianId)
        {
            Id = id;
            IssueDate = issueDate;
            DueDate = dueDate;
            ActualReturnDate = actualReturnDate;
            ReaderId = readerId;
            PublicationId = publicationId;
            LibrarianId = librarianId;
        }

        public static Loan Create(int id, DateTime issueDate, DateTime dueDate, DateTime? actualReturnDate, int readerId, int publicationId, int librarianId)
        {
            if (id <= 0)
                throw new ArgumentException("ID должен быть больше 0", nameof(id));

            if (dueDate < issueDate)
                throw new ArgumentException("Срок возврата не может быть раньше даты выдачи", nameof(dueDate));

            if (actualReturnDate.HasValue && actualReturnDate.Value < issueDate)
                throw new ArgumentException("Дата возврата не может быть раньше даты выдачи", nameof(actualReturnDate));

            if (readerId <= 0)
                throw new ArgumentException("Некорректный ID читателя", nameof(readerId));

            if (publicationId <= 0)
                throw new ArgumentException("Некорректный ID издания", nameof(publicationId));

            if (librarianId <= 0)
                throw new ArgumentException("Некорректный ID библиотекаря", nameof(librarianId));

            return new Loan(id, issueDate, dueDate, actualReturnDate, readerId, publicationId, librarianId);
        }
    }
}
