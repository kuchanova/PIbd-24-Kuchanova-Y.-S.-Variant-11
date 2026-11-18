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
    public partial class LibrarianListForm : Form
    {
        private readonly ILibrarianRepository _librarianRepository;

        public LibrarianListForm(ILibrarianRepository librarianRepository)
        {
            InitializeComponent();
            _librarianRepository = librarianRepository ?? throw new ArgumentNullException(nameof(librarianRepository));
        }

        private void LoadData()
        {
            dgvLibrarians.DataSource = _librarianRepository.GetAll().ToList();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var editForm = new LibrarianEditForm(_librarianRepository))
            {
                if (editForm.ShowDialog() == DialogResult.OK) LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvLibrarians.CurrentRow?.DataBoundItem is Librarian selected)
            {
                using (var editForm = new LibrarianEditForm(_librarianRepository, selected))
                {
                    if (editForm.ShowDialog() == DialogResult.OK) LoadData();
                }
            }
            else MessageBox.Show("Выберите строку.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvLibrarians.CurrentRow?.DataBoundItem is Librarian selected)
            {
                if (MessageBox.Show($"Удалить '{selected.FullName}'?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _librarianRepository.Delete(selected.Id);
                    LoadData();
                }
            }
            else MessageBox.Show("Выберите строку.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
