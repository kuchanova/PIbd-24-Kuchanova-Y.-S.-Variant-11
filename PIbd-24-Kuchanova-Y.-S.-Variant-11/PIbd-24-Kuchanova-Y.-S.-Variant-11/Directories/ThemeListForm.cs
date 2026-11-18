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
    public partial class ThemeListForm : Form
    {
        private readonly IThemeRepository _themeRepository;

        public ThemeListForm(IThemeRepository themeRepository)
        {
            InitializeComponent();
            _themeRepository = themeRepository ?? throw new ArgumentNullException(nameof(themeRepository));
        }

        private void LoadData()
        {
            dgvThemes.DataSource = _themeRepository.GetAll().ToList();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var editForm = new ThemeEditForm(_themeRepository))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvThemes.CurrentRow?.DataBoundItem is Theme selectedTheme)
            {
                using (var editForm = new ThemeEditForm(_themeRepository, selectedTheme))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для редактирования.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvThemes.CurrentRow?.DataBoundItem is Theme selectedTheme)
            {
                var result = MessageBox.Show($"Удалить тематику '{selectedTheme.Name}'?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _themeRepository.Delete(selectedTheme.Id);
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
