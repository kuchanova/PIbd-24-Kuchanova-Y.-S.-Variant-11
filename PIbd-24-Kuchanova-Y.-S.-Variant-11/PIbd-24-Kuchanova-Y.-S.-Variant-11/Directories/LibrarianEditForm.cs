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
using System.Xml.Linq;

namespace LibraryApp
{
    public partial class LibrarianEditForm : Form
    {
        private readonly ILibrarianRepository _librarianRepository;
        private readonly Librarian _librarian;

        public LibrarianEditForm(ILibrarianRepository librarianRepository)
        {
            InitializeComponent();
            _librarianRepository = librarianRepository ?? throw new ArgumentNullException(nameof(librarianRepository));
            _librarian = null;
        }

        public LibrarianEditForm(ILibrarianRepository librarianRepository, Librarian librarianToEdit)
        {
            InitializeComponent();
            _librarianRepository = librarianRepository ?? throw new ArgumentNullException(nameof(librarianRepository));
            _librarian = librarianToEdit ?? throw new ArgumentNullException(nameof(librarianToEdit));
            txtFullName.Text = _librarian.FullName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFullName.Text))
                {
                    MessageBox.Show("Введите ФИО!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_librarian == null)
                {
                    var newLibrarian = Librarian.Create(1, txtFullName.Text);
                    _librarianRepository.Add(newLibrarian);
                }
                else
                {
                    var updatedLibrarian = Librarian.Create(_librarian.Id, txtFullName.Text);
                    _librarianRepository.Update(updatedLibrarian);
                }

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
