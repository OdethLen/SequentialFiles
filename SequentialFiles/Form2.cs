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
        List<string> Courses;
        public Form2()
        {
            InitializeComponent();
            Courses = new List<string>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Enter a name.");
                return;
            }

            if (!int.TryParse(txtCourse.Text, out int courseIndex) || courseIndex < 1)
            {
                MessageBox.Show("Enter a valid number in course field.");
                return;
            }

            // Abrir OpenFileDialog para que el usuario elija el archivo de carreras
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            openFileDialog.Title = "Select Courses File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                if (!File.Exists(filePath))
                {
                    MessageBox.Show("File not found.");
                    return;
                }

                try
                {
                    List<string> carreras = File.ReadAllLines(filePath).ToList(); // Cargar carreras desde el archivo

                    if (courseIndex > carreras.Count)
                    {
                        MessageBox.Show("The number entered exceeds the available courses.");
                        return;
                    }

                    string selectedCourse = carreras[courseIndex - 1]; // Obtener la carrera correspondiente al número ingresado
                    dgvData.Rows.Add(txtName.Text,txtAge.Text,txtGender.Text,txtYear.Text, selectedCourse);

                    txtName.Clear();
                    txtCourse.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading file: " + ex.Message);
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = txtName.Text;
            student.Age = txtAge.Text;
            student.Gender = txtGender.Text;
            student.Year = txtYear.Text;
            student.Course = txtCourse.Text;

        }

        private void btnCreateCourses_Click(object sender, EventArgs e)
        {
            SaveTotxt();
        }

        private void btnAddcourses_Click(object sender, EventArgs e)
        {
            Courses.Add(txtCoursesName.Text);

            if (txtCoursesName.Text == "")
            {
                MessageBox.Show("Enter data.");
                return;
            }

            txtCoursesName.Clear();
            MessageBox.Show("Text correcly saved.");
        }



        private void SaveTotxt()
        {
            if (Courses.Count == 0)
            {
                MessageBox.Show("No data to save.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog.Title = "Save as";
            saveFileDialog.FileName = "Courses.txt"; // Nombre predeterminado

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = saveFileDialog.FileName;
                    string fileContent = string.Join("\n", Courses); // Guardar cada curso en una línea
                    File.WriteAllText(filePath, fileContent);
                    MessageBox.Show("File saved successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message);
                }
            }
        }

    }
}
