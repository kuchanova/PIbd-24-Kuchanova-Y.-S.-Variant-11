using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace LibraryApp
{
    public partial class MainForm : Form
    {
        private readonly IUnityContainer _container;

        public MainForm(IUnityContainer container)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
        }

        private void menuThemes_Click(object sender, EventArgs e)
        {
            var form = _container.Resolve<ThemeListForm>();
            form.ShowDialog();
        }

        private void menuLibrarians_Click(object sender, EventArgs e)
        {
            var form = _container.Resolve<LibrarianListForm>();
            form.ShowDialog();
        }

        private void menuPublications_Click(object sender, EventArgs e)
        {
            var form = _container.Resolve<PublicationListForm>();
            form.ShowDialog();
        }

        private void menuCards_Click(object sender, EventArgs e)
        {
            var form = _container.Resolve<CardListForm>();
            form.ShowDialog();
        }

        private void menuReaders_Click(object sender, EventArgs e)
        {
            var form = _container.Resolve<ReaderListForm>();
            form.ShowDialog();
        }

        private void menuLoans_Click(object sender, EventArgs e)
        {
            var form = _container.Resolve<LoanListForm>();
            form.ShowDialog();
        }

        private void menuLibrarianThemes_Click(object sender, EventArgs e)
        {
            var form = _container.Resolve<LibrarianThemeListForm>();
            form.ShowDialog();
        }
    }
}
