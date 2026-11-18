namespace LibraryApp
{
    public partial class ReaderListForm
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
            dgvReaders = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReaders).BeginInit();
            SuspendLayout();
            // 
            // dgvReaders
            // 
            dgvReaders.AllowUserToAddRows = false;
            dgvReaders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReaders.Dock = DockStyle.Top;
            dgvReaders.Location = new Point(0, 0);
            dgvReaders.Name = "dgvReaders";
            dgvReaders.ReadOnly = true;
            dgvReaders.RowHeadersWidth = 51;
            dgvReaders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReaders.Size = new Size(800, 403);
            dgvReaders.TabIndex = 0;
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
            // ReaderListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvReaders);
            Name = "ReaderListForm";
            Text = "ReaderListForm";
            ((System.ComponentModel.ISupportInitialize)dgvReaders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvReaders;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}