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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Enter a name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAge.Text))
            {
                MessageBox.Show("Enter a name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Enter a name.");
                return;
            }

            dgvData.Rows.Add(txtName.Text, txtAge.Text, txtId.Text);
            txtName.Clear();
            txtAge.Clear();
            txtId.Clear();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.Name = txtName.Text;
            person.Age = txtAge.Text;
            person.Id = txtId.Text;

            if (dgvData.Rows.Count == 1)
            {
                MessageBox.Show("There's no data to export.", "No data");
                return;
            }

            string fileName;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "text file |*.txt";
            saveFileDialog.Title = "Save text file";
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;
            fileName = saveFileDialog.FileName;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
