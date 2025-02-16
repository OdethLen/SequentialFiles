using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SequentialFiles
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvDat.Rows.Add(txtName.Text, txtAge.Text, txtGender.Text,txtYear.Text, txtCourse.Text);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Student student = new Student();    
            student.Name= txtName.Text;
            student.Age= txtAge.Text;
            student.Gender = txtGender.Text;
            student.Year = txtYear.Text;
            student.Course = txtCourse.Text;
            
        }
    }
}
