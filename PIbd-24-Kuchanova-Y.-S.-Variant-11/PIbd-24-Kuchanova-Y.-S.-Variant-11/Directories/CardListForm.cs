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
    public partial class CardListForm : Form
    {
        private readonly ILibraryCardRepository _cardRepository;

        public CardListForm(ILibraryCardRepository cardRepository)
        {
            InitializeComponent();
            _cardRepository = cardRepository ?? throw new ArgumentNullException(nameof(cardRepository));
        }

        private void LoadData()
        {
            dgvCards.DataSource = _cardRepository.GetAll().ToList();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var editForm = new CardEditForm(_cardRepository))
            {
                if (editForm.ShowDialog() == DialogResult.OK) LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCards.CurrentRow?.DataBoundItem is LibraryCard selected)
            {
                using (var editForm = new CardEditForm(_cardRepository, selected))
                {
                    if (editForm.ShowDialog() == DialogResult.OK) LoadData();
                }
            }
            else MessageBox.Show("Выберите строку.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCards.CurrentRow?.DataBoundItem is LibraryCard selected)
            {
                if (MessageBox.Show($"Удалить билет '{selected.Number}'?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _cardRepository.Delete(selected.Id);
                    LoadData();
                }
            }
            else MessageBox.Show("Выберите строку.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
