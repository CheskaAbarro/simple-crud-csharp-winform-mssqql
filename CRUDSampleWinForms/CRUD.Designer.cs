namespace CRUDSampleWinForms
{
    partial class CRUD
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtAge = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnSave = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dataRecordsView = new DataGridView();
            label3 = new Label();
            idLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataRecordsView).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10.2F);
            txtName.Location = new Point(451, 91);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(301, 34);
            txtName.TabIndex = 0;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 10.2F);
            txtAge.Location = new Point(451, 166);
            txtAge.Multiline = true;
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(301, 34);
            txtAge.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(451, 63);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(451, 138);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 1;
            label2.Text = "Age:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 255, 192);
            btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSave.Location = new Point(451, 232);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(84, 45);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(255, 192, 128);
            btnEdit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnEdit.Location = new Point(558, 232);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(84, 45);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Update";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnDelete.Location = new Point(668, 232);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(84, 45);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataRecordsView
            // 
            dataRecordsView.AllowUserToAddRows = false;
            dataRecordsView.AllowUserToDeleteRows = false;
            dataRecordsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataRecordsView.Location = new Point(23, 33);
            dataRecordsView.Name = "dataRecordsView";
            dataRecordsView.ReadOnly = true;
            dataRecordsView.RowHeadersVisible = false;
            dataRecordsView.RowHeadersWidth = 51;
            dataRecordsView.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dataRecordsView.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataRecordsView.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Red;
            dataRecordsView.ScrollBars = ScrollBars.Vertical;
            dataRecordsView.Size = new Size(395, 244);
            dataRecordsView.TabIndex = 3;
            dataRecordsView.CellClick += dataRecordsView_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(451, 33);
            label3.Name = "label3";
            label3.Size = new Size(29, 20);
            label3.TabIndex = 1;
            label3.Text = "ID:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            idLabel.Location = new Point(486, 33);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(45, 20);
            idLabel.TabIndex = 1;
            idLabel.Text = "0000";
            // 
            // CRUD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 303);
            Controls.Add(dataRecordsView);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(idLabel);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Name = "CRUD";
            Text = "Form1";
            Load += CRUD_Load;
            ((System.ComponentModel.ISupportInitialize)dataRecordsView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtAge;
        private Label label1;
        private Label label2;
        private Button btnSave;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dataRecordsView;
        private Label label3;
        private Label idLabel;
    }
}
