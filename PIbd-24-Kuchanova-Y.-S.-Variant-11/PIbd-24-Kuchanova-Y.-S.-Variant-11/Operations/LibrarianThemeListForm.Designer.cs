namespace LibraryApp
{
    public partial class LibrarianThemeListForm
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
            dgvLibrarianThemes = new DataGridView();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLibrarianThemes).BeginInit();
            SuspendLayout();
            // 
            // dgvLibrarianThemes
            // 
            dgvLibrarianThemes.AllowUserToAddRows = false;
            dgvLibrarianThemes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibrarianThemes.Dock = DockStyle.Top;
            dgvLibrarianThemes.Location = new Point(0, 0);
            dgvLibrarianThemes.Name = "dgvLibrarianThemes";
            dgvLibrarianThemes.ReadOnly = true;
            dgvLibrarianThemes.RowHeadersWidth = 51;
            dgvLibrarianThemes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLibrarianThemes.Size = new Size(800, 403);
            dgvLibrarianThemes.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(694, 409);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // LibrarianThemeListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(dgvLibrarianThemes);
            Name = "LibrarianThemeListForm";
            Text = "LibrarianThemeListForm";
            ((System.ComponentModel.ISupportInitialize)dgvLibrarianThemes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvLibrarianThemes;
        private Button btnAdd;
    }
}