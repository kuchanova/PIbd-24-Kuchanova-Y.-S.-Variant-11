using Library.Data.Interfaces;
using Library.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class LoanListForm : Form
    {
        private readonly ILoanRepository _loanRepository;
        private readonly IReaderRepository _readerRepository;
        private readonly IPublicationRepository _publicationRepository;
        private readonly ILibrarianRepository _librarianRepository;

        public LoanListForm(
            ILoanRepository loanRepository,
            IReaderRepository readerRepository,
            IPublicationRepository publicationRepository,
            ILibrarianRepository librarianRepository)
        {
            InitializeComponent();
            _loanRepository = loanRepository ?? throw new ArgumentNullException(nameof(loanRepository));
            _readerRepository = readerRepository ?? throw new ArgumentNullException(nameof(readerRepository));
            _publicationRepository = publicationRepository ?? throw new ArgumentNullException(nameof(publicationRepository));
            _librarianRepository = librarianRepository ?? throw new ArgumentNullException(nameof(librarianRepository));
        }

        private void LoadData()
        {
            dgvLoans.DataSource = _loanRepository.GetAll().ToList();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var addForm = new LoanAddForm(_loanRepository, _readerRepository, _publicationRepository, _librarianRepository))
            {
                if (addForm.ShowDialog() == DialogResult.OK) LoadData();
            }
        }
    }
}
