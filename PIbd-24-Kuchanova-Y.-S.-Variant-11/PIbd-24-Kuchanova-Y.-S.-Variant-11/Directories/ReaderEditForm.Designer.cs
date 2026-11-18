namespace LibraryApp
{
    public partial class ReaderEditForm
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
            txtFullName = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            cmbCard = new ComboBox();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(82, 42);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(125, 27);
            txtFullName.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(97, 132);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(97, 167);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbCard
            // 
            cmbCard.FormattingEnabled = true;
            cmbCard.Location = new Point(70, 75);
            cmbCard.Name = "cmbCard";
            cmbCard.Size = new Size(151, 28);
            cmbCard.TabIndex = 3;
            // 
            // ReaderEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 258);
            Controls.Add(cmbCard);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtFullName);
            Name = "ReaderEditForm";
            Text = "ReaderEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullName;
        private Button btnSave;
        private Button btnCancel;
        private ComboBox cmbCard;
    }
}