namespace LibraryApp
{
    public partial class LibrarianListForm
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
            dgvLibrarians = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLibrarians).BeginInit();
            SuspendLayout();
            // 
            // dgvLibrarians
            // 
            dgvLibrarians.AllowUserToAddRows = false;
            dgvLibrarians.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibrarians.Dock = DockStyle.Top;
            dgvLibrarians.Location = new Point(0, 0);
            dgvLibrarians.Name = "dgvLibrarians";
            dgvLibrarians.ReadOnly = true;
            dgvLibrarians.RowHeadersWidth = 51;
            dgvLibrarians.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLibrarians.Size = new Size(800, 403);
            dgvLibrarians.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(455, 409);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(555, 409);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(133, 29);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Редактировать";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(694, 409);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // LibrarianListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvLibrarians);
            Name = "LibrarianListForm";
            Text = "LibrarianListForm";
            ((System.ComponentModel.ISupportInitialize)dgvLibrarians).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvLibrarians;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}