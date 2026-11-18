namespace LibraryApp
{
    partial class LibrarianThemeAddForm
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
            lblLibrarian = new Label();
            cmbLibrarian = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            lblTheme = new Label();
            cmbTheme = new ComboBox();
            SuspendLayout();
            // 
            // lblLibrarian
            // 
            lblLibrarian.AutoSize = true;
            lblLibrarian.Location = new Point(12, 81);
            lblLibrarian.Name = "lblLibrarian";
            lblLibrarian.Size = new Size(111, 20);
            lblLibrarian.TabIndex = 1;
            lblLibrarian.Text = "Библиотекарь:";
            // 
            // cmbLibrarian
            // 
            cmbLibrarian.FormattingEnabled = true;
            cmbLibrarian.Location = new Point(142, 73);
            cmbLibrarian.Name = "cmbLibrarian";
            cmbLibrarian.Size = new Size(151, 28);
            cmbLibrarian.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(49, 137);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(169, 137);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblTheme
            // 
            lblTheme.AutoSize = true;
            lblTheme.Location = new Point(49, 26);
            lblTheme.Name = "lblTheme";
            lblTheme.Size = new Size(77, 20);
            lblTheme.TabIndex = 12;
            lblTheme.Text = "Тематика:";
            // 
            // cmbTheme
            // 
            cmbTheme.FormattingEnabled = true;
            cmbTheme.Location = new Point(142, 23);
            cmbTheme.Name = "cmbTheme";
            cmbTheme.Size = new Size(151, 28);
            cmbTheme.TabIndex = 13;
            // 
            // LibrarianThemeAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 244);
            Controls.Add(cmbTheme);
            Controls.Add(lblTheme);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbLibrarian);
            Controls.Add(lblLibrarian);
            Name = "LibrarianThemeAddForm";
            Text = "LoanAddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReader;
        private Label lblLibrarian;
        private Label lblPublication;
        private Label lblDueDate;
        private Label lblIssueDate;
        private ComboBox cmbLibrarian;
        private ComboBox cmbPublication;
        private DateTimePicker dtpIssueDate;
        private DateTimePicker dtpDueDate;
        private Button btnSave;
        private Button btnCancel;
        private Label lblTheme;
        private ComboBox cmbTheme;
    }
}