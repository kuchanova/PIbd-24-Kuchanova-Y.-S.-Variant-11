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
    public partial class LibrarianThemeListForm : Form
    {
        private readonly ILibrarianThemeRepository _librarianThemeRepository;
        private readonly ILibrarianRepository _librarianRepository;
        private readonly IThemeRepository _themeRepository;

        public LibrarianThemeListForm(
            ILibrarianThemeRepository librarianThemeRepository,
            ILibrarianRepository librarianRepository,
            IThemeRepository themeRepository)
        {
            InitializeComponent();
            _librarianThemeRepository = librarianThemeRepository ?? throw new ArgumentNullException(nameof(librarianThemeRepository));
            _librarianRepository = librarianRepository ?? throw new ArgumentNullException(nameof(librarianRepository));
            _themeRepository = themeRepository ?? throw new ArgumentNullException(nameof(themeRepository));
        }

        private void LoadData()
        {
            dgvLibrarianThemes.DataSource = _librarianThemeRepository.GetAll().ToList();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var addForm = new LibrarianThemeAddForm(_librarianThemeRepository, _librarianRepository, _themeRepository))
            {
                if (addForm.ShowDialog() == DialogResult.OK) LoadData();
            }
        }
    }
}
