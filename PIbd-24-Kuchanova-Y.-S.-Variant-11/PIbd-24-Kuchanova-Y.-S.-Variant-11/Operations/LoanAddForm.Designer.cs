namespace LibraryApp
{
    partial class LoanAddForm
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
            lblReader = new Label();
            lblLibrarian = new Label();
            lblPublication = new Label();
            lblDueDate = new Label();
            lblIssueDate = new Label();
            cmbReader = new ComboBox();
            cmbLibrarian = new ComboBox();
            cmbPublication = new ComboBox();
            dtpIssueDate = new DateTimePicker();
            dtpDueDate = new DateTimePicker();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblReader
            // 
            lblReader.AutoSize = true;
            lblReader.Location = new Point(218, 30);
            lblReader.Name = "lblReader";
            lblReader.Size = new Size(75, 20);
            lblReader.TabIndex = 0;
            lblReader.Text = "Читатель:";
            // 
            // lblLibrarian
            // 
            lblLibrarian.AutoSize = true;
            lblLibrarian.Location = new Point(182, 124);
            lblLibrarian.Name = "lblLibrarian";
            lblLibrarian.Size = new Size(111, 20);
            lblLibrarian.TabIndex = 1;
            lblLibrarian.Text = "Библиотекарь:";
            // 
            // lblPublication
            // 
            lblPublication.AutoSize = true;
            lblPublication.Location = new Point(221, 77);
            lblPublication.Name = "lblPublication";
            lblPublication.Size = new Size(72, 20);
            lblPublication.TabIndex = 2;
            lblPublication.Text = "Издание:";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(97, 247);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(111, 20);
            lblDueDate.TabIndex = 3;
            lblDueDate.Text = "Дата возврата:";
            // 
            // lblIssueDate
            // 
            lblIssueDate.AutoSize = true;
            lblIssueDate.Location = new Point(108, 197);
            lblIssueDate.Name = "lblIssueDate";
            lblIssueDate.Size = new Size(100, 20);
            lblIssueDate.TabIndex = 4;
            lblIssueDate.Text = "Дата выдачи:";
            // 
            // cmbReader
            // 
            cmbReader.FormattingEnabled = true;
            cmbReader.Location = new Point(299, 27);
            cmbReader.Name = "cmbReader";
            cmbReader.Size = new Size(151, 28);
            cmbReader.TabIndex = 5;
            // 
            // cmbLibrarian
            // 
            cmbLibrarian.FormattingEnabled = true;
            cmbLibrarian.Location = new Point(299, 121);
            cmbLibrarian.Name = "cmbLibrarian";
            cmbLibrarian.Size = new Size(151, 28);
            cmbLibrarian.TabIndex = 6;
            // 
            // cmbPublication
            // 
            cmbPublication.FormattingEnabled = true;
            cmbPublication.Location = new Point(299, 74);
            cmbPublication.Name = "cmbPublication";
            cmbPublication.Size = new Size(151, 28);
            cmbPublication.TabIndex = 7;
            // 
            // dtpIssueDate
            // 
            dtpIssueDate.Location = new Point(214, 192);
            dtpIssueDate.Name = "dtpIssueDate";
            dtpIssueDate.Size = new Size(250, 27);
            dtpIssueDate.TabIndex = 8;
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(214, 242);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(250, 27);
            dtpDueDate.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(256, 300);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(356, 300);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // LoanAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 387);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dtpDueDate);
            Controls.Add(dtpIssueDate);
            Controls.Add(cmbPublication);
            Controls.Add(cmbLibrarian);
            Controls.Add(cmbReader);
            Controls.Add(lblIssueDate);
            Controls.Add(lblDueDate);
            Controls.Add(lblPublication);
            Controls.Add(lblLibrarian);
            Controls.Add(lblReader);
            Name = "LoanAddForm";
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
        private ComboBox cmbReader;
        private ComboBox cmbLibrarian;
        private ComboBox cmbPublication;
        private DateTimePicker dtpIssueDate;
        private DateTimePicker dtpDueDate;
        private Button btnSave;
        private Button btnCancel;
    }
}