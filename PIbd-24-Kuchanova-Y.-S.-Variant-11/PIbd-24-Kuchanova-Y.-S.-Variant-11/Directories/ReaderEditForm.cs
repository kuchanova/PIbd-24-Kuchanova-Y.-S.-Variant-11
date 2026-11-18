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
    public partial class ReaderEditForm : Form
    {
        private readonly IReaderRepository _readerRepository;
        private readonly ILibraryCardRepository _cardRepository;
        private readonly Reader? _reader;

        public ReaderEditForm(IReaderRepository readerRepository, ILibraryCardRepository cardRepository)
        {
            InitializeComponent();
            _readerRepository = readerRepository ?? throw new ArgumentNullException(nameof(readerRepository));
            _cardRepository = cardRepository ?? throw new ArgumentNullException(nameof(cardRepository));
            _reader = null;

            LoadCards();
        }

        public ReaderEditForm(IReaderRepository readerRepository, ILibraryCardRepository cardRepository, Reader readerToEdit)
        {
            InitializeComponent();
            _readerRepository = readerRepository ?? throw new ArgumentNullException(nameof(readerRepository));
            _cardRepository = cardRepository ?? throw new ArgumentNullException(nameof(cardRepository));
            _reader = readerToEdit ?? throw new ArgumentNullException(nameof(readerToEdit));

            LoadCards();

            txtFullName.Text = _reader.FullName;

            foreach (LibraryCard card in cmbCard.Items)
            {
                if (card.Id == _reader.CardId)
                {
                    cmbCard.SelectedItem = card;
                    break;
                }
            }
        }

        private void LoadCards()
        {
            cmbCard.DataSource = _cardRepository.GetAll().ToList();
            cmbCard.DisplayMember = "Number";
            cmbCard.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFullName.Text))
                {
                    MessageBox.Show("Введите ФИО читателя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbCard.SelectedItem == null)
                {
                    MessageBox.Show("Выберите читательский билет!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                LibraryCard selectedCard = (LibraryCard)cmbCard.SelectedItem;

                if (_reader == null)
                {
                    var newReader = Reader.Create(1, txtFullName.Text, selectedCard.Id);
                    _readerRepository.Add(newReader);
                }
                else
                {
                    var updatedReader = Reader.Create(_reader.Id, txtFullName.Text, selectedCard.Id);
                    _readerRepository.Update(updatedReader);
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
