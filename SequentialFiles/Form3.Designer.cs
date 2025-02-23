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
            txtName = new TextBox();
            txtAge = new TextBox();
            txtId = new TextBox();
            groupBox1 = new GroupBox();
            dgvData = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            button2 = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
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
            label2.Location = new Point(17, 74);
            label2.Name = "label2";
            label2.Size = new Size(31, 17);
            label2.TabIndex = 1;
            label2.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 108);
            label3.Name = "label3";
            label3.Size = new Size(19, 17);
            label3.TabIndex = 2;
            label3.Text = "Id";
            // 
            // txtName
            // 
            txtName.Location = new Point(62, 38);
            txtName.Name = "txtName";
            txtName.Size = new Size(167, 25);
            txtName.TabIndex = 3;
            txtName.TextAlign = HorizontalAlignment.Right;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(62, 74);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(167, 25);
            txtAge.TabIndex = 4;
            txtAge.TextAlign = HorizontalAlignment.Right;
            // 
            // txtId
            // 
            txtId.Location = new Point(62, 108);
            txtId.Name = "txtId";
            txtId.Size = new Size(167, 25);
            txtId.TabIndex = 5;
            txtId.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtAge);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(33, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(272, 160);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { Name, Age, Id });
            dgvData.Location = new Point(498, 76);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(343, 204);
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
            btnAdd.Location = new Point(345, 99);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 31);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // button2
            // 
            button2.Location = new Point(345, 137);
            button2.Name = "button2";
            button2.Size = new Size(94, 31);
            button2.TabIndex = 9;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(279, 39);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 31);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(50, 44);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(210, 23);
            txtSearch.TabIndex = 6;
            txtSearch.TextAlign = HorizontalAlignment.Right;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 346);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(button2);
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
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtId;
        private GroupBox groupBox1;
        private DataGridView dgvData;
        private Button btnAdd;
        private Button button2;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Id;
        private Button btnSearch;
        private TextBox txtSearch;
    }
}