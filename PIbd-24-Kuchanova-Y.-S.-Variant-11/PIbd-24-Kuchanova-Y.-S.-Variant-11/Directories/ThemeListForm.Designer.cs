namespace LibraryApp
{
    partial class ThemeListForm
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
            dgvThemes = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvThemes).BeginInit();
            SuspendLayout();
            // 
            // dgvThemes
            // 
            dgvThemes.AllowUserToAddRows = false;
            dgvThemes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThemes.Dock = DockStyle.Top;
            dgvThemes.Location = new Point(0, 0);
            dgvThemes.Name = "dgvThemes";
            dgvThemes.ReadOnly = true;
            dgvThemes.RowHeadersWidth = 51;
            dgvThemes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThemes.Size = new Size(800, 403);
            dgvThemes.TabIndex = 0;
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
            // ThemeListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvThemes);
            Name = "ThemeListForm";
            Text = "ThemeListForm";
            ((System.ComponentModel.ISupportInitialize)dgvThemes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvThemes;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}