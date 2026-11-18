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
    public partial class LibrarianThemeAddForm : Form
    {
        private readonly ILibrarianThemeRepository _librarianThemeRepository;
        private readonly ILibrarianRepository _librarianRepository;
        private readonly IThemeRepository _themeRepository;

        public LibrarianThemeAddForm(
            ILibrarianThemeRepository librarianThemeRepository,
            ILibrarianRepository librarianRepository,
            IThemeRepository themeRepository)
        {
            InitializeComponent();
            _librarianThemeRepository = librarianThemeRepository ?? throw new ArgumentNullException(nameof(librarianThemeRepository));
            _librarianRepository = librarianRepository ?? throw new ArgumentNullException(nameof(librarianRepository));
            _themeRepository = themeRepository ?? throw new ArgumentNullException(nameof(themeRepository));

            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            cmbLibrarian.DataSource = _librarianRepository.GetAll().ToList();
            cmbLibrarian.DisplayMember = "FullName";
            cmbLibrarian.ValueMember = "Id";

            cmbTheme.DataSource = _themeRepository.GetAll().ToList();
            cmbTheme.DisplayMember = "Name";
            cmbTheme.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbLibrarian.SelectedItem == null || cmbTheme.SelectedItem == null)
                {
                    MessageBox.Show("Выберите библиотекаря и тематику!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Librarian librarian = (Librarian)cmbLibrarian.SelectedItem;
                Theme theme = (Theme)cmbTheme.SelectedItem;

                var newLink = LibrarianTheme.Create(librarian.Id, theme.Id);
                _librarianThemeRepository.Add(newLink);

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
