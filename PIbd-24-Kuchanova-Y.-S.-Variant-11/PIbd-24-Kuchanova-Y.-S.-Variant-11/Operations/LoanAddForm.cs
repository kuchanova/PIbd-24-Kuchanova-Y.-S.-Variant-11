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
    public partial class LoanAddForm : Form
    {
        private readonly ILoanRepository _loanRepository;
        private readonly IReaderRepository _readerRepository;
        private readonly IPublicationRepository _publicationRepository;
        private readonly ILibrarianRepository _librarianRepository;

        public LoanAddForm(
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

            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            cmbReader.DataSource = _readerRepository.GetAll().ToList();
            cmbReader.DisplayMember = "FullName";
            cmbReader.ValueMember = "Id";

            cmbPublication.DataSource = _publicationRepository.GetAll().ToList();
            cmbPublication.DisplayMember = "Title";
            cmbPublication.ValueMember = "Id";

            cmbLibrarian.DataSource = _librarianRepository.GetAll().ToList();
            cmbLibrarian.DisplayMember = "FullName";
            cmbLibrarian.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbReader.SelectedItem == null || cmbPublication.SelectedItem == null || cmbLibrarian.SelectedItem == null)
                {
                    MessageBox.Show("Выберите читателя, издание и библиотекаря!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dtpDueDate.Value < dtpIssueDate.Value)
                {
                    MessageBox.Show("Срок возврата не может быть раньше даты выдачи!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Reader reader = (Reader)cmbReader.SelectedItem;
                Publication publication = (Publication)cmbPublication.SelectedItem;
                Librarian librarian = (Librarian)cmbLibrarian.SelectedItem;

                var newLoan = Loan.Create(1, dtpIssueDate.Value, dtpDueDate.Value, null, reader.Id, publication.Id, librarian.Id);
                _loanRepository.Add(newLoan);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
