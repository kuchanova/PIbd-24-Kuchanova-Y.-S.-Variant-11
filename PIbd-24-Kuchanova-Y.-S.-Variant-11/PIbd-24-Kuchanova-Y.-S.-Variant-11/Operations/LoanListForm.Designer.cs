namespace LibraryApp
{
    public partial class LoanListForm
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
            dgvLoans = new DataGridView();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLoans).BeginInit();
            SuspendLayout();
            // 
            // dgvLoans
            // 
            dgvLoans.AllowUserToAddRows = false;
            dgvLoans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoans.Dock = DockStyle.Top;
            dgvLoans.Location = new Point(0, 0);
            dgvLoans.Name = "dgvLoans";
            dgvLoans.ReadOnly = true;
            dgvLoans.RowHeadersWidth = 51;
            dgvLoans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoans.Size = new Size(800, 403);
            dgvLoans.TabIndex = 0;
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
            // LoanListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(dgvLoans);
            Name = "LoanListForm";
            Text = "LoanListForm";
            ((System.ComponentModel.ISupportInitialize)dgvLoans).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvLoans;
        private Button btnAdd;
    }
}