using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Models
{
    public class Reader
    {
        public int Id { get; private set; }
        public string FullName { get; private set; }
        public int CardId { get; private set; }

        private Reader(int id, string fullName, int cardId)
        {
            Id = id;
            FullName = fullName;
            CardId = cardId;
        }

        public static Reader Create(int id, string fullName, int cardId)
        {
            if (id <= 0)
                throw new ArgumentException("ID должен быть больше 0", nameof(id));

            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("ФИО читателя не может быть пустым", nameof(fullName));

            if (cardId <= 0)
                throw new ArgumentException("Некорректный ID читательского билета", nameof(cardId));

            return new Reader(id, fullName, cardId);
        }
    }
}
