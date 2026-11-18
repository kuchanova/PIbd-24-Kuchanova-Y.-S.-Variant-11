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
    public partial class ReaderListForm : Form
    {
        private readonly IReaderRepository _readerRepository;
        private readonly ILibraryCardRepository _cardRepository;

        public ReaderListForm(IReaderRepository readerRepository, ILibraryCardRepository cardRepository)
        {
            InitializeComponent();
            _readerRepository = readerRepository ?? throw new ArgumentNullException(nameof(readerRepository));
            _cardRepository = cardRepository ?? throw new ArgumentNullException(nameof(cardRepository));
        }

        private void LoadData()
        {
            dgvReaders.DataSource = _readerRepository.GetAll().ToList();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var editForm = new ReaderEditForm(_readerRepository, _cardRepository))
            {
                if (editForm.ShowDialog() == DialogResult.OK) LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvReaders.CurrentRow?.DataBoundItem is Reader selected)
            {
                using (var editForm = new ReaderEditForm(_readerRepository, _cardRepository, selected))
                {
                    if (editForm.ShowDialog() == DialogResult.OK) LoadData();
                }
            }
            else MessageBox.Show("Выберите строку.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvReaders.CurrentRow?.DataBoundItem is Reader selected)
            {
                if (MessageBox.Show($"Удалить читателя '{selected.FullName}'?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _readerRepository.Delete(selected.Id);
                    LoadData();
                }
            }
            else MessageBox.Show("Выберите строку.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
