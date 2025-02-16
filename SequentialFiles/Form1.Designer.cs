namespace SequentialFiles
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtAlias = new TextBox();
            txtGender = new TextBox();
            txtAge = new TextBox();
            txtQuirk = new TextBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            btnCreate = new Button();
            dgvData = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Alias = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Quirk = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnRead = new Button();
            btnDelete = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(81, 49);
            txtName.Name = "txtName";
            txtName.Size = new Size(168, 28);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 49);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 89);
            label2.Name = "label2";
            label2.Size = new Size(36, 17);
            label2.TabIndex = 3;
            label2.Text = "Alias";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 150);
            label3.Name = "label3";
            label3.Size = new Size(0, 17);
            label3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 125);
            label4.Name = "label4";
            label4.Size = new Size(52, 17);
            label4.TabIndex = 5;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 165);
            label5.Name = "label5";
            label5.Size = new Size(30, 17);
            label5.TabIndex = 6;
            label5.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 208);
            label6.Name = "label6";
            label6.Size = new Size(41, 17);
            label6.TabIndex = 7;
            label6.Text = "Quirk";
            // 
            // txtAlias
            // 
            txtAlias.Location = new Point(81, 89);
            txtAlias.Name = "txtAlias";
            txtAlias.Size = new Size(168, 28);
            txtAlias.TabIndex = 8;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(81, 125);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(168, 28);
            txtGender.TabIndex = 9;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(81, 165);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(168, 28);
            txtAge.TabIndex = 10;
            // 
            // txtQuirk
            // 
            txtQuirk.Location = new Point(81, 208);
            txtQuirk.Name = "txtQuirk";
            txtQuirk.Size = new Size(168, 28);
            txtQuirk.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAlias);
            groupBox1.Controls.Add(txtQuirk);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtAge);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtGender);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(23, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(288, 268);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(368, 251);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 13;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(329, 101);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(96, 31);
            btnCreate.TabIndex = 14;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // dgvData
            // 
            dgvData.BackgroundColor = Color.DarkSeaGreen;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { Name, Alias, Gender, Age, Quirk });
            dgvData.Location = new Point(450, 23);
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.Size = new Size(487, 268);
            dgvData.TabIndex = 15;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // Alias
            // 
            Alias.HeaderText = "Alias";
            Alias.Name = "Alias";
            Alias.ReadOnly = true;
            // 
            // Gender
            // 
            Gender.HeaderText = "Gender";
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            // 
            // Age
            // 
            Age.HeaderText = "Age";
            Age.Name = "Age";
            Age.ReadOnly = true;
            // 
            // Quirk
            // 
            Quirk.HeaderText = "Quirk";
            Quirk.Name = "Quirk";
            Quirk.ReadOnly = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(329, 58);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 31);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(329, 142);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(96, 31);
            btnRead.TabIndex = 17;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(329, 184);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(96, 31);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 346);
            Controls.Add(btnDelete);
            Controls.Add(btnRead);
            Controls.Add(btnAdd);
            Controls.Add(dgvData);
            Controls.Add(btnCreate);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtAlias;
        private TextBox txtGender;
        private TextBox txtAge;
        private TextBox txtQuirk;
        private GroupBox groupBox1;
        private Button button1;
        private Button btnCreate;
        private DataGridView dgvData;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Alias;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Quirk;
        private Button btnAdd;
        private Button btnRead;
        private Button btnDelete;
    }
}
