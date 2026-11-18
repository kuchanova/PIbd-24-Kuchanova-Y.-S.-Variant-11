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
    public partial class CardEditForm : Form
    {
        private readonly ILibraryCardRepository _cardRepository;
        private readonly LibraryCard? _card;

        public CardEditForm(ILibraryCardRepository cardRepository)
        {
            InitializeComponent();
            _cardRepository = cardRepository ?? throw new ArgumentNullException(nameof(cardRepository));
            _card = null;
        }

        public CardEditForm(ILibraryCardRepository cardRepository, LibraryCard cardToEdit)
        {
            InitializeComponent();
            _cardRepository = cardRepository ?? throw new ArgumentNullException(nameof(cardRepository));
            _card = cardToEdit ?? throw new ArgumentNullException(nameof(cardToEdit));

            txtNumber.Text = _card.Number;
            dtpStartDate.Value = _card.StartDate;
            dtpFinishDate.Value = _card.FinishDate;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNumber.Text))
                {
                    MessageBox.Show("Введите номер билета!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dtpFinishDate.Value < dtpStartDate.Value)
                {
                    MessageBox.Show("Дата окончания не может быть раньше даты выдачи!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_card == null)
                {
                    var newCard = LibraryCard.Create(1, txtNumber.Text, dtpStartDate.Value, dtpFinishDate.Value);
                    _cardRepository.Add(newCard);
                }
                else
                {
                    var updatedCard = LibraryCard.Create(_card.Id, txtNumber.Text, dtpStartDate.Value, dtpFinishDate.Value);
                    _cardRepository.Update(updatedCard);
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
