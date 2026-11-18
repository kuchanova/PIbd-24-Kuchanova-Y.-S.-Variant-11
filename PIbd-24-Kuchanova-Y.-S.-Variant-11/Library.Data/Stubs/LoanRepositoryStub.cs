using Library.Data.Interfaces;
using Library.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Stubs
{
    internal class LoanRepositoryStub : ILoanRepository
    {
        public void Add(Loan loan) { }
        public IEnumerable<Loan> GetAll() => [];
    }
}
