using Library.Data.Interfaces;
using Library.Domain.Enums;
using Library.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Linq;

namespace LibraryApp
{
    public partial class PublicationEditForm : Form
    {
        private readonly IPublicationRepository _publicationRepository;
        private readonly IThemeRepository _themeRepository;
        private readonly Publication? _publication;

        public PublicationEditForm(IPublicationRepository publicationRepository, IThemeRepository themeRepository)
        {
            InitializeComponent();
            _publicationRepository = publicationRepository ?? throw new ArgumentNullException(nameof(publicationRepository));
            _themeRepository = themeRepository ?? throw new ArgumentNullException(nameof(themeRepository));
            _publication = null;

            LoadThemes();
        }

        public PublicationEditForm(IPublicationRepository publicationRepository, IThemeRepository themeRepository, Publication publicationToEdit)
        {
            InitializeComponent();
            _publicationRepository = publicationRepository ?? throw new ArgumentNullException(nameof(publicationRepository));
            _themeRepository = themeRepository ?? throw new ArgumentNullException(nameof(themeRepository));
            _publication = publicationToEdit ?? throw new ArgumentNullException(nameof(publicationToEdit));

            LoadThemes();

            txtTitle.Text = _publication.Title;
            cmbTheme.SelectedItem = _publication.Type;

            foreach (Theme theme in cmbTheme.Items)
            {
                if (theme.Id == _publication.ThemeId)
                {
                    cmbTheme.SelectedItem = theme;
                    break;
                }
            }
        }

        private void LoadThemes()
        {
            cmbTheme.DataSource = _themeRepository.GetAll().ToList();
            cmbTheme.DisplayMember = "Name"; 
            cmbTheme.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTitle.Text))
                {
                    MessageBox.Show("Введите название издания!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbTheme.SelectedItem == null)
                {
                    MessageBox.Show("Выберите тематику!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbTheme.SelectedItem == null)
                {
                    MessageBox.Show("Выберите тип издания!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                PublicationType type = (PublicationType)cmbTheme.SelectedItem;
                Theme selectedTheme = (Theme)cmbTheme.SelectedItem;

                if (_publication == null)
                {
                    var newPublication = Publication.Create(1, txtTitle.Text, type, selectedTheme.Id);
                    _publicationRepository.Add(newPublication);
                }
                else
                {
                    var updatedPublication = Publication.Create(_publication.Id, txtTitle.Text, type, selectedTheme.Id);
                    _publicationRepository.Update(updatedPublication);
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
