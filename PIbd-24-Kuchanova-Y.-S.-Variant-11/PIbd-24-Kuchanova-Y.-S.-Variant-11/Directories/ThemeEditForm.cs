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
    public partial class ThemeEditForm : Form
    {
        private readonly IThemeRepository _themeRepository;
        private readonly Theme? _theme;

        public ThemeEditForm(IThemeRepository themeRepository)
        {
            InitializeComponent();
            _themeRepository = themeRepository ?? throw new ArgumentNullException(nameof(themeRepository));
            _theme = null;
        }

        public ThemeEditForm(IThemeRepository themeRepository, Theme themeToEdit)
        {
            InitializeComponent();
            _themeRepository = themeRepository ?? throw new ArgumentNullException(nameof(themeRepository));
            _theme = themeToEdit ?? throw new ArgumentNullException(nameof(themeToEdit));

            txtName.Text = _theme.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Введите название тематики!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_theme == null)
                {
                    var newTheme = Theme.Create(1, txtName.Text);
                    _themeRepository.Add(newTheme);
                }
                else
                {
                    var updatedTheme = Theme.Create(_theme.Id, txtName.Text);
                    _themeRepository.Update(updatedTheme);
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
