namespace SequentialFiles
{
    partial class Form2
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
            groupBox1 = new GroupBox();
            txtAge = new TextBox();
            txtCourse = new TextBox();
            txtName = new TextBox();
            txtYear = new TextBox();
            label1 = new Label();
            txtGender = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            dgvDat = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Alias = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Quirk = new DataGridViewTextBoxColumn();
            btnDelete = new Button();
            btnRead = new Button();
            btnAdd = new Button();
            btnCreate = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDat).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAge);
            groupBox1.Controls.Add(txtCourse);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtYear);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtGender);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(34, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 268);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(97, 89);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(168, 28);
            txtAge.TabIndex = 8;
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(97, 205);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(168, 28);
            txtCourse.TabIndex = 11;
            // 
            // txtName
            // 
            txtName.Location = new Point(97, 49);
            txtName.Name = "txtName";
            txtName.Size = new Size(168, 28);
            txtName.TabIndex = 1;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(97, 164);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(168, 28);
            txtYear.TabIndex = 10;
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
            // txtGender
            // 
            txtGender.Location = new Point(97, 125);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(168, 28);
            txtGender.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 89);
            label2.Name = "label2";
            label2.Size = new Size(30, 17);
            label2.TabIndex = 3;
            label2.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 150);
            label3.Name = "label3";
            label3.Size = new Size(0, 17);
            label3.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 208);
            label6.Name = "label6";
            label6.Size = new Size(51, 17);
            label6.TabIndex = 7;
            label6.Text = "Course";
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
            label5.Location = new Point(39, 167);
            label5.Name = "label5";
            label5.Size = new Size(34, 17);
            label5.TabIndex = 6;
            label5.Text = "Year";
            // 
            // dgvDat
            // 
            dgvDat.BackgroundColor = Color.LightBlue;
            dgvDat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDat.Columns.AddRange(new DataGridViewColumn[] { Name, Alias, Gender, Age, Quirk });
            dgvDat.Location = new Point(478, 40);
            dgvDat.Name = "dgvDat";
            dgvDat.ReadOnly = true;
            dgvDat.Size = new Size(487, 268);
            dgvDat.TabIndex = 16;
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
            // btnDelete
            // 
            btnDelete.Location = new Point(360, 215);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(96, 31);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(360, 173);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(96, 31);
            btnRead.TabIndex = 22;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(360, 89);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 31);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(360, 132);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(96, 31);
            btnCreate.TabIndex = 20;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // button1
            // 
            button1.Location = new Point(387, 282);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 19;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnRead);
            Controls.Add(btnAdd);
            Controls.Add(btnCreate);
            Controls.Add(button1);
            Controls.Add(dgvDat);
            Controls.Add(groupBox1);
            
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtAge;
        private TextBox txtCourse;
        private TextBox txtName;
        private TextBox txtYear;
        private Label label1;
        private TextBox txtGender;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label4;
        private Label label5;
        private DataGridView dgvDat;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Alias;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Quirk;
        private Button btnDelete;
        private Button btnRead;
        private Button btnAdd;
        private Button btnCreate;
        private Button button1;
    }
}