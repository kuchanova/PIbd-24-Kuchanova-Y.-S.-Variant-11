namespace LibraryApp
{
    public partial class CardEditForm
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
            txtNumber = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            dtpStartDate = new DateTimePicker();
            dtpFinishDate = new DateTimePicker();
            lblStartDate = new Label();
            lblFinishDate = new Label();
            SuspendLayout();
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(82, 42);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(125, 27);
            txtNumber.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(97, 95);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(97, 130);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(25, 227);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(250, 27);
            dtpStartDate.TabIndex = 3;
            // 
            // dtpFinishDate
            // 
            dtpFinishDate.Location = new Point(25, 303);
            dtpFinishDate.Name = "dtpFinishDate";
            dtpFinishDate.Size = new Size(250, 27);
            dtpFinishDate.TabIndex = 4;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(97, 204);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(100, 20);
            lblStartDate.TabIndex = 5;
            lblStartDate.Text = "Дата выдачи:";
            // 
            // lblFinishDate
            // 
            lblFinishDate.AutoSize = true;
            lblFinishDate.Location = new Point(83, 280);
            lblFinishDate.Name = "lblFinishDate";
            lblFinishDate.Size = new Size(124, 20);
            lblFinishDate.TabIndex = 6;
            lblFinishDate.Text = "Дата окончания:";
            // 
            // CardEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 354);
            Controls.Add(lblFinishDate);
            Controls.Add(lblStartDate);
            Controls.Add(dtpFinishDate);
            Controls.Add(dtpStartDate);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtNumber);
            Name = "CardEditForm";
            Text = "CardEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumber;
        private Button btnSave;
        private Button btnCancel;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpFinishDate;
        private Label lblStartDate;
        private Label lblFinishDate;
    }
}