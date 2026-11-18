namespace LibraryApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuDirectories = new ToolStripMenuItem();
            menuThemes = new ToolStripMenuItem();
            menuLibrarians = new ToolStripMenuItem();
            menuPublications = new ToolStripMenuItem();
            menuReaders = new ToolStripMenuItem();
            menuCards = new ToolStripMenuItem();
            menuOperations = new ToolStripMenuItem();
            menuLoans = new ToolStripMenuItem();
            menuLibrarianThemes = new ToolStripMenuItem();
            menuReports = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuDirectories, menuOperations, menuReports });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuDirectories
            // 
            menuDirectories.DropDownItems.AddRange(new ToolStripItem[] { menuThemes, menuLibrarians, menuPublications, menuReaders, menuCards });
            menuDirectories.Name = "menuDirectories";
            menuDirectories.Size = new Size(117, 24);
            menuDirectories.Text = "Справочники";
            // 
            // menuThemes
            // 
            menuThemes.Name = "menuThemes";
            menuThemes.Size = new Size(192, 26);
            menuThemes.Text = "Тематики";
            menuThemes.Click += menuThemes_Click;
            // 
            // menuLibrarians
            // 
            menuLibrarians.Name = "menuLibrarians";
            menuLibrarians.Size = new Size(192, 26);
            menuLibrarians.Text = "Библиотекари";
            menuLibrarians.Click += menuLibrarians_Click;
            // 
            // menuPublications
            // 
            menuPublications.Name = "menuPublications";
            menuPublications.Size = new Size(192, 26);
            menuPublications.Text = "Издания";
            menuPublications.Click += menuPublications_Click;
            // 
            // menuReaders
            // 
            menuReaders.Name = "menuReaders";
            menuReaders.Size = new Size(192, 26);
            menuReaders.Text = "Читатели";
            menuReaders.Click += menuReaders_Click;
            // 
            // menuCards
            // 
            menuCards.Name = "menuCards";
            menuCards.Size = new Size(192, 26);
            menuCards.Text = "Билеты";
            menuCards.Click += menuCards_Click;
            // 
            // menuOperations
            // 
            menuOperations.DropDownItems.AddRange(new ToolStripItem[] { menuLoans, menuLibrarianThemes });
            menuOperations.Name = "menuOperations";
            menuOperations.Size = new Size(95, 24);
            menuOperations.Text = "Операции";
            // 
            // menuLoans
            // 
            menuLoans.Name = "menuLoans";
            menuLoans.Size = new Size(242, 26);
            menuLoans.Text = "Выдачи";
            menuLoans.Click += menuLoans_Click;
            // 
            // menuLibrarianThemes
            // 
            menuLibrarianThemes.Name = "menuLibrarianThemes";
            menuLibrarianThemes.Size = new Size(242, 26);
            menuLibrarianThemes.Text = "Закрепление тематик";
            menuLibrarianThemes.Click += menuLibrarianThemes_Click;
            // 
            // menuReports
            // 
            menuReports.Name = "menuReports";
            menuReports.Size = new Size(73, 24);
            menuReports.Text = "Отчеты";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuDirectories;
        private ToolStripMenuItem menuThemes;
        private ToolStripMenuItem menuLibrarians;
        private ToolStripMenuItem menuPublications;
        private ToolStripMenuItem menuReaders;
        private ToolStripMenuItem menuCards;
        private ToolStripMenuItem menuOperations;
        private ToolStripMenuItem menuLoans;
        private ToolStripMenuItem menuLibrarianThemes;
        private ToolStripMenuItem menuReports;
    }
}