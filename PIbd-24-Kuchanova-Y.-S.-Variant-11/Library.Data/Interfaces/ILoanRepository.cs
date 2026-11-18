using Library.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Interfaces
{
    public interface ILoanRepository
    {
        IEnumerable<Loan> GetAll();
        void Add(Loan loan);
    }
}
