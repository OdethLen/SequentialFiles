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
                    dgvData.Rows.Add(txtName.Text, txtAge.Text, txtGender.Text, txtYear.Text, selectedCourse);

                    txtName.Clear();
                    txtAge.Clear();
                    txtGender.Clear();
                    txtYear.Clear();
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

            if (dgvData.Rows.Count == 1)
            {
                MessageBox.Show("There's no data to export.", "No data");
                return;
            }

            string fileName;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files |*.txt";
            saveFileDialog.Title = "Save a Text File";
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            fileName = saveFileDialog.FileName;
            if (fileName != null)
            {
                StreamWriter sw = new StreamWriter(fileName);
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    if (row.IsNewRow) continue;
                    var values = row.Cells.OfType<DataGridViewCell>()
                                          .Select(cell => cell.Value?.ToString() ?? string.Empty)
                                          .ToArray();

                    sw.WriteLine(string.Join(",", values));
                    sw.Flush();
                    sw.Close();
                }
            }

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

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files |*.txt";
            openFileDialog.Title = "Open txt file";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string filePath = openFileDialog.FileName;
            string[] lines = File.ReadAllLines(filePath);
            dgvData.Rows.Clear();

            foreach (string line in lines)
            {

                string[] values = line.Split(',');
                dgvData.Rows.Add(values);
            }
            MessageBox.Show("Data loaded successfully into DataGridView.");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0)
            {
                // Asegurarse de que no intentamos eliminar la fila nueva vacía
                if (!dgvData.Rows[dgvData.SelectedRows[0].Index].IsNewRow)
                {
                    // Eliminar la fila seleccionada
                    dgvData.Rows.RemoveAt(dgvData.SelectedRows[0].Index);
                    MessageBox.Show("Selected row deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Cannot delete the new empty row.");
                }
            }

            else
            {
                MessageBox.Show("No row selected to delete.");
            }
        }
    }
}
