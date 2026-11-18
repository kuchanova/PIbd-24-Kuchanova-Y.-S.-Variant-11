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
    public partial class PublicationListForm : Form
    {
        private readonly IPublicationRepository _publicationRepository;
        private readonly IThemeRepository _themeRepository;

        public PublicationListForm(IPublicationRepository publicationRepository, IThemeRepository themeRepository)
        {
            InitializeComponent();
            _publicationRepository = publicationRepository ?? throw new ArgumentNullException(nameof(publicationRepository));
            _themeRepository = themeRepository ?? throw new ArgumentNullException(nameof(themeRepository));
        }

        private void LoadData()
        {
            dgvPublications.DataSource = _publicationRepository.GetAll().ToList();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var editForm = new PublicationEditForm(_publicationRepository, _themeRepository))
            {
                if (editForm.ShowDialog() == DialogResult.OK) LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPublications.CurrentRow?.DataBoundItem is Publication selected)
            {
                using (var editForm = new PublicationEditForm(_publicationRepository, _themeRepository, selected))
                {
                    if (editForm.ShowDialog() == DialogResult.OK) LoadData();
                }
            }
            else MessageBox.Show("Выберите строку.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPublications.CurrentRow?.DataBoundItem is Publication selected)
            {
                if (MessageBox.Show($"Удалить '{selected.Title}'?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _publicationRepository.Delete(selected.Id);
                    LoadData();
                }
            }
            else MessageBox.Show("Выберите строку.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
