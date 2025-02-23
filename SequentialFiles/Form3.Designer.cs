namespace SequentialFiles
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            txtId = new TextBox();
            txtAge = new TextBox();
            txtName = new TextBox();
            dgvData = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnCreate = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 38);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 111);
            label2.Name = "label2";
            label2.Size = new Size(31, 17);
            label2.TabIndex = 1;
            label2.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 145);
            label3.Name = "label3";
            label3.Size = new Size(19, 17);
            label3.TabIndex = 2;
            label3.Text = "Id";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtAge);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(33, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(272, 192);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // txtId
            // 
            txtId.Location = new Point(70, 145);
            txtId.Name = "txtId";
            txtId.Size = new Size(157, 25);
            txtId.TabIndex = 13;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(70, 112);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(157, 25);
            txtAge.TabIndex = 12;
            // 
            // txtName
            // 
            txtName.Location = new Point(70, 44);
            txtName.Name = "txtName";
            txtName.Size = new Size(157, 25);
            txtName.TabIndex = 11;
            // 
            // dgvData
            // 
            dgvData.BackgroundColor = Color.Pink;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { Name, Age, Id });
            dgvData.Location = new Point(498, 39);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(343, 241);
            dgvData.TabIndex = 7;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.Name = "Name";
            // 
            // Age
            // 
            Age.HeaderText = "Age";
            Age.Name = "Age";
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Yu Gothic UI", 9.75F);
            btnAdd.Location = new Point(345, 99);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 31);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Yu Gothic UI", 9.75F);
            btnCreate.Location = new Point(345, 137);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 31);
            btnCreate.TabIndex = 9;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Yu Gothic UI", 9.75F);
            btnSearch.Location = new Point(279, 39);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 31);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(50, 44);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(210, 23);
            txtSearch.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 77);
            label4.Name = "label4";
            label4.Size = new Size(31, 17);
            label4.TabIndex = 14;
            label4.Text = "Age";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 346);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnCreate);
            Controls.Add(btnAdd);
            Controls.Add(dgvData);
            Controls.Add(groupBox1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private DataGridView dgvData;
        private Button btnAdd;
        private Button btnCreate;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Id;
        private Button btnSearch;
        private TextBox txtSearch;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtId;
        private Label label4;
    }
}