using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace SequentialFiles
{
    public partial class Form3 : Form
    {
        private Dictionary<string, string> dataIndex = new Dictionary<string, string>();
        public Form3()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtId.Text))

            {
                MessageBox.Show("All fields are required.");
                return;
            }

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (row.Cells[0].Value?.ToString() == txtName.Text)
                {
                    MessageBox.Show("This name already exists.");
                    return;
                }
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


            if (dgvData.Rows.Count == 1)
            {
                MessageBox.Show("There's no data to export.", "No data");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file |*.txt";
            saveFileDialog.Title = "Save text file";

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string fileName = saveFileDialog.FileName;

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null)
                    {
                        string line = $"{row.Cells[0].Value}|{row.Cells[1].Value}|{row.Cells[2].Value}";
                        writer.WriteLine(line);
                    }
                }
            }

            MessageBox.Show("Data saved successfully.");

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files |*.txt";
            openFileDialog.Title = "Select a file to search";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string filePath = openFileDialog.FileName;
            string nameToSearch = txtSearch.Text;

            if (string.IsNullOrWhiteSpace(nameToSearch))
            {
                MessageBox.Show("Please enter a name to search.");
                return;
            }

            Dictionary<string, string> tempDataIndex = new Dictionary<string, string>();

            // Leer el archivo seleccionado y construir el índice temporal
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length == 3)
                {
                    string name = parts[0];
                    tempDataIndex[name] = line;
                }
            }

            if (tempDataIndex.TryGetValue(nameToSearch, out string? foundData))
            {
                var parts = foundData.Split('|');
                dgvData.Rows.Clear();
                dgvData.Rows.Add(parts[0], parts[1], parts[2]);
            }
            else
            {
                MessageBox.Show("No matches found.");
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files |*.txt";
            openFileDialog.Title = "Select a file to search";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            string filePath = openFileDialog.FileName;
            dgvData.Rows.Clear();

            try
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        dgvData.Rows.Add(parts[0], parts[1], parts[2]);
                    }
                }

                MessageBox.Show("Data loaded successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file.");
            }
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
        }
    }
}
